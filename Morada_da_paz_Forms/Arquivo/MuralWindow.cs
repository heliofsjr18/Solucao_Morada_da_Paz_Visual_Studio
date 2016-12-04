
using Morada_da_paz_Forms.MRDP;
//using Morada_Da_Paz_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Morada_da_paz_Forms.Arquivo
{
    public partial class MuralWindow : Form
    {

        List<ocorrencia> ocorrenciaLista;
        public MuralWindow()
        {
            InitializeComponent();
            this.carregaOcorrencias();
        }

        public void carregaOcorrencias()
        {
            try
            {


                //this.ocorrenciaLista = sv.listarOcorrencasPublicas();
                
                ocorrenciaLista = new Service1().listarOcorrencasPublicas().ToList();

                listViewMinhasOcorrencias.Items.Clear();
                for (int index = 0; index < ocorrenciaLista.Count; index++)
                {

                    ListViewItem linha = listViewMinhasOcorrencias.Items.Add(ocorrenciaLista.ElementAt(index).Numero_ocorrencia);
                    linha.SubItems.Add(ocorrenciaLista.ElementAt(index).Descricao);
                    linha.SubItems.Add(ocorrenciaLista.ElementAt(index).Situacao);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.carregaOcorrencias();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
