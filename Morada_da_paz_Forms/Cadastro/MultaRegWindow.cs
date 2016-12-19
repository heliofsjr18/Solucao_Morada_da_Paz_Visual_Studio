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
    public partial class MultaRegWindow : Form
    {
        public MultaRegWindow()
        {
            InitializeComponent();
            if (PrincipalWindow.usuarioAtivo.Id_especializacao_usuario.Id != 1)
            {
                this.Height = 301;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                multa mult = new multa() { Descricao = richTextBox1.Text, Preco = Convert.ToDouble(numericUpDown1.Value) };

                Service1Client serviceInstance = new Service1Client();
                serviceInstance.inserirMulta(mult);
                MessageBox.Show("Multa Cadastrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void MultaRegWindow_Load(object sender, EventArgs e)
        {
            Service1Client serviceInstance = new Service1Client();
            multa[] listamulta = serviceInstance.listarMulta();
            for (int i = 0; i < listamulta.Count(); i++)
            {                
                ListViewItem linha = listView1.Items.Add(listamulta.ElementAt(i).Descricao);
                linha.SubItems.Add(listamulta.ElementAt(i).Preco.ToString());
            }
        }
    }
}
