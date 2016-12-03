using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Morada_da_paz_Forms.MRDP;

namespace Morada_da_paz_Forms.Cadastro
{
    public partial class MultaRegWindow : Form
    {
        public MultaRegWindow()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                multa mult = new multa() { Descricao = richTextBox1.Text, Preco = Convert.ToDouble(numericUpDown1.Value)};
                
                MRDP.ServiceMorada_Da_PazClient serviceInstance = new ServiceMorada_Da_PazClient();
                serviceInstance.inserirMulta(mult);
                MessageBox.Show("Multa Cadastrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
