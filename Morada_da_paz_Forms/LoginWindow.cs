using Morada_da_paz_Forms.wcf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Windows.Forms;



namespace Morada_da_paz_Forms
{
    public partial class LoginWindow : Form
    {
        public usuario login = new usuario();
        public usuario resultadoU = new usuario();
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.login.Login = textBox1.Text;
            this.login.Senha = textBox2.Text;
            //usuario resultadoU = new usuario();
            try
            {
                
                Service1Client serviceInstance = new Service1Client();                
                this.resultadoU = serviceInstance.pesquisaUsuarioLogin(this.login);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            if (resultadoU.Id != 0)
            {
                if (this.resultadoU.Senha.Equals(login.Senha))
                {
                    this.DialogResult = DialogResult.OK;
                }

                else
                {
                    MessageBox.Show("Usuário ou senha Invalido");                    
                    return;
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha Invalido");                
                return;
            }
        }
    }
}
