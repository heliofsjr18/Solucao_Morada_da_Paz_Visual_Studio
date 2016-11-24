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
                if(comboBoxUnd.Text == "")
                {
                    MessageBox.Show("Defina a Und. Residencial!");
                }else
                {
                    int index = comboBoxUnd.SelectedIndex;
                    unidade_residencial und = ListaUnidade.ElementAt(index);
                    oc.Id_unidade_residencial = und;

                    if (checkBoxOcorrenciaPublica.Checked == true)
                    {
                        oc.TipoPublico = 1;
                    }else
                    {
                        oc.TipoPublico = 0;
                    }

                    oc.Situacao = comboBoxStatus.Text;
                    ServiceMoradaDaPaz sv = new ServiceMoradaDaPaz();
                    sv.editarOcorrencia(oc);
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
            ServiceMoradaDaPaz sv = new ServiceMoradaDaPaz();
            this.ListaUnidade = sv.listarUnidades();
            for (int i = 0; i < ListaUnidade.Count; i++)
            {
                comboBoxUnd.Items.Add(ListaUnidade.ElementAt(i).Descricao);
            }
        }
    }
}
