using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PrincipalWindow window = new PrincipalWindow(this);
            window.Show();
            textBox1.Text = null;
            textBox2.Text = null;
            checkBox1.Checked = false;
            this.Hide();
        }

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult getResult = MessageBox.Show(this, "Deseja encerrar a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (getResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
