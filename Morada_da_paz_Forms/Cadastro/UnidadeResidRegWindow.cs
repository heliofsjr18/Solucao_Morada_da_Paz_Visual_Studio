using Morada_da_paz_Forms.wcf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Morada_da_paz_Forms.Cadastro
{
    public partial class UnidadeResidRegWindow : Form
    {
        public UnidadeResidRegWindow()
        {
            InitializeComponent();
            if (PrincipalWindow.usuarioAtivo.Id_especializacao_usuario.Id != 1)
            {
                this.Height = 301;
            }
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
            Service1Client serviceinstance = new Service1Client();


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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void UnidadeResidRegWindow_Load(object sender, EventArgs e)
        {
            Service1Client serviceInstance = new Service1Client();
            unidade_residencial[] listaunidade_residencial = serviceInstance.listarUnidades();
            for (int i = 0; i < listaunidade_residencial.Count(); i++)
            {
                ListViewItem linha = listView1.Items.Add(listaunidade_residencial.ElementAt(i).Numero_residencia);
                linha.SubItems.Add(listaunidade_residencial.ElementAt(i).Descricao);
            }
        }
    }
}
