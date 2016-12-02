using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morada_da_paz_Forms.Edicao
{
    public partial class EditOcorrenciaWindow : Form
    {
        ocorrencia oc;
        List<unidade_residencial> ListaUnidade;
        List<multa> listaMulta;
        List<advertencia> listaAdvertencia;
        public EditOcorrenciaWindow(ocorrencia o)
        {
            oc = o;
            InitializeComponent();
            this.preencheComponentes(o);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void preencheComponentes(ocorrencia o)
        {
            textBoxNumero.Text = o.Numero_ocorrencia;
            richTextBoxDescricao.Text = o.Descricao;
            comboBoxStatus.Text = o.Situacao;
            if (o.TipoPublico == 1)
            {
                checkBoxOcorrenciaPublica.Checked = true;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUnd.Text == "")
                {
                    MessageBox.Show("Defina a Und. Residencial!");
                }
                else
                {
                    int index = comboBoxUnd.SelectedIndex;
                    unidade_residencial und = ListaUnidade.ElementAt(index);

                    oc.Id_unidade_residencial = und;


                    if (checkBoxOcorrenciaPublica.Checked == true)
                    {
                        oc.TipoPublico = 1;
                    }
                    else
                    {
                        oc.TipoPublico = 0;
                    }

                    oc.Situacao = comboBoxStatus.Text;
                    ServiceMoradaDaPaz sv = new ServiceMoradaDaPaz();
                    sv.editarOcorrencia(oc);


                    if (checkBoxMulta.Checked)
                    {
                        if (!comboBoxMulta.Text.Equals(""))
                        {
                            int indexMulta = comboBoxMulta.SelectedIndex;
                            multa mu = listaMulta.ElementAt(indexMulta);
                            sv.inserirMultaOcorrencia(mu, oc);
                        }
                        else
                        {
                            MessageBox.Show("Escolha a multa!");
                            return;
                        }

                    }
                    else {
                        if (!comboBoxMulta.Text.Equals(""))
                        {
                            MessageBox.Show("Indique quão sanção você deseja aplicar!");
                            return;
                        }
                    }

                    if (checkBoxAdvertencia.Checked)
                    {
                        if (!comboBoxAdvertencia.Text.Equals(""))
                        {
                            int indexAdvertencia = comboBoxAdvertencia.SelectedIndex;
                            advertencia ad = listaAdvertencia.ElementAt(indexAdvertencia);
                            sv.inserirAdvertenciaOcorrencia(ad, oc);
                        }
                        else
                        {
                            MessageBox.Show("Escolha a advertêcia!");
                            return;
                        }
                    }
                    else
                    {
                        if (!comboBoxAdvertencia.Text.Equals(""))
                        {
                            MessageBox.Show("Indique quão sanção você deseja aplicar!");
                            return;
                        }
                    }
                    MessageBox.Show("Transação concluida!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void EditOcorrenciaWindow_Load(object sender, EventArgs e)
        {

        }

        private void EditOcorrenciaWindow_Shown(object sender, EventArgs e)
        {
            try
            {
                ServiceMoradaDaPaz sv = new ServiceMoradaDaPaz();
                this.ListaUnidade = sv.listarUnidades();


                for (int i = 0; i < ListaUnidade.Count; i++)
                {
                    comboBoxUnd.Items.Add(ListaUnidade.ElementAt(i).Numero_residencia);
                }

                this.listaMulta = sv.listarMulta();

                for (int x = 0; x < listaMulta.Count; x++)
                {
                    comboBoxMulta.Items.Add(listaMulta.ElementAt(x).Descricao);
                }

                this.listaAdvertencia = sv.listarAdvertencias();

                for (int y = 0; y < listaAdvertencia.Count; y++)
                {
                    comboBoxAdvertencia.Items.Add(listaAdvertencia.ElementAt(y).Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceMoradaDaPaz sv = new ServiceMoradaDaPaz();
            sv.excluiOcorrencia(this.oc);
            MessageBox.Show("Ocorrência Excluida!");
            this.Dispose();
        }
    }
}
