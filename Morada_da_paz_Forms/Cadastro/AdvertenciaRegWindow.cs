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

//using Morada_da_paz_Biblioteca.basicas;

namespace Morada_da_paz_Forms.Cadastro
{
    public partial class AdvertenciaRegWindow : Form
    {
        public AdvertenciaRegWindow()
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
                advertencia adv = new advertencia() { Descricao = richTextBoxAdvertencia.Text };
                Service1Client serviceInstance = new Service1Client();
                
                serviceInstance.inserirAdvertencia(adv);
                MessageBox.Show("Advertencia Cadastrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdvertenciaRegWindow_Load(object sender, EventArgs e)
        {
            Service1Client serviceInstance = new Service1Client();
            advertencia[] listaAdvertencia = serviceInstance.listarAdvertencias();
            for (int i = 0; i < listaAdvertencia.Count(); i++)
            {
                ListViewItem linha = listView1.Items.Add(listaAdvertencia.ElementAt(i).Descricao);
            }
        }
    }
}
