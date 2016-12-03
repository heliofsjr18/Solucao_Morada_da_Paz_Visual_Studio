using Morada_da_paz_Forms.MRDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Morada_da_paz_Biblioteca.basicas;

namespace Morada_da_paz_Forms.Cadastro
{
    public partial class AdvertenciaRegWindow : Form
    {
        public AdvertenciaRegWindow()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                advertencia adv = new advertencia() { Descricao = richTextBoxAdvertencia.Text };
                
                MRDP.ServiceMorada_Da_PazClient serviceInstance = new ServiceMorada_Da_PazClient();
                serviceInstance.inserirAdvertencia(adv);
                MessageBox.Show("Advertencia Cadastrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
