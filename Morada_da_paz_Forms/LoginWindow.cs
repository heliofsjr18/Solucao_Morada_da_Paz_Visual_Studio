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

namespace Morada_da_paz_Forms
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox getSender = (CheckBox)sender;
            textBox2.UseSystemPasswordChar = !getSender.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario u = new usuario() { Login = textBox1.Text, Senha = textBox2.Text };
            IServiceMoradaDaPaz serviceInstance = new ServiceMoradaDaPaz();
            usuario resultadoU = serviceInstance.pesquisaUsuarioLogin(u);
            if (resultadoU.Id != 0)
            {
                if (resultadoU.Senha.Equals(textBox2.Text))
                    this.DialogResult = DialogResult.OK;
                else
                {
                    MessageBox.Show("Usuário ou senha Invalido");
                    this.DialogResult = DialogResult.Cancel;
                }                                    
            }
            else
            {
                MessageBox.Show("Usuário ou senha Invalido");
                this.DialogResult = DialogResult.Cancel;
            }            
        }

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult getResult = MessageBox.Show(this, "Deseja encerrar a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (getResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
