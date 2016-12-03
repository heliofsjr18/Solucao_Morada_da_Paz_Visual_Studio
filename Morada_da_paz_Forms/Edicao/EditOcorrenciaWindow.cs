
using Morada_da_paz_Forms.MRDP;
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
        Boolean controle;

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
            comboBoxUnd.Text = o.Id_unidade_residencial.Numero_residencia;
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
                    unidade_residencial u = new unidade_residencial();
                    u.Id = 1;
                    u.Numero_residencia = "0";
                    u.Descricao = "Nenhuma";

                    oc.Id_unidade_residencial = u;
                }
                else
                {
                    int index = comboBoxUnd.SelectedIndex;
                    if(index >= 0)
                    {
                        unidade_residencial und = ListaUnidade.ElementAt(index);
                    
                        oc.Id_unidade_residencial = und;
                    }
                    
                }
                    


                    if (checkBoxOcorrenciaPublica.Checked == true)
                    {
                        oc.TipoPublico = 1;
                    }
                    else
                    {
                        oc.TipoPublico = 0;
                    }
                
                    oc.Situacao = comboBoxStatus.Text;

                    
                MRDP.ServiceMorada_Da_PazClient sv = new ServiceMorada_Da_PazClient();


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
                
                MRDP.ServiceMorada_Da_PazClient sv = new ServiceMorada_Da_PazClient();
                this.ListaUnidade = sv.listarUnidades().ToList();


                for (int i = 0; i < ListaUnidade.Count; i++)
                {
                    comboBoxUnd.Items.Add(ListaUnidade.ElementAt(i).Numero_residencia);
                }

                this.listaMulta = sv.listarMulta().ToList();

                for (int x = 0; x < listaMulta.Count; x++)
                {
                    comboBoxMulta.Items.Add(listaMulta.ElementAt(x).Descricao);
                }

                this.listaAdvertencia = sv.listarAdvertencias().ToList();

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
            
            MRDP.ServiceMorada_Da_PazClient sv = new ServiceMorada_Da_PazClient();
            sv.excluiOcorrencia(this.oc);
            MessageBox.Show("Ocorrência Excluida!");
            this.Dispose();
        }
    }
}
