using Morada_da_paz_Biblioteca.RegraDeNegocio;
using projeto_morada_da_paz.basicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morada_da_paz_Biblioteca
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            usuario u = new usuario();

            u.Nome_completo = textBoxNome.Text;
            u.Email = textBoxEmail.Text;
            u.Login = textBoxUsuario.Text;
            u.Senha = textBoxSenha.Text;

            RNusuario rnu = new RNusuario();
            try
            {
                MessageBox.Show(""+rnu.validaUsuario(u));
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }
    }
}
