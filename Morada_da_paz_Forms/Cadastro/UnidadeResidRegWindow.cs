using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Morada_da_paz_WebService;
using Morada_da_paz_Biblioteca.basicas;

namespace Morada_da_paz_Forms.Cadastro
{
    public partial class UnidadeResidRegWindow : Form
    {
        public UnidadeResidRegWindow()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            unidade_residencial uR = new unidade_residencial() { Numero_residencia = textBox1.Text, Descricao = textBox2.Text };
            ServiceMoradaDaPaz serviceinstance = new ServiceMoradaDaPaz();
            try
            {
                serviceinstance.inseirUnidadeResidencial(uR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Unidade Residencial Cadastrada");
            this.Dispose();
        }
    }
}
