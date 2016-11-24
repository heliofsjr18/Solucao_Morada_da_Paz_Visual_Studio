using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_WebService;

namespace Morada_da_paz_Forms.Arquivo
{
    public partial class NovaOcorrenciaWindow : Form
    {
        public NovaOcorrenciaWindow()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();            

            ocorrencia oco = new ocorrencia() { Numero_ocorrencia = "" + rnd.Next(int.MaxValue), Situacao = "Em Aberto" };
            oco.Id_usuario.Id = PrincipalWindow.usuarioAtivo.Id;
            
            oco.Descricao = richTextBox1.Text;
            if (checkBox1.Checked ==  true)            
                oco.TipoPublico = 1;
            else
                oco.TipoPublico = 0;

            
            ServiceMoradaDaPaz serviceinstance = new ServiceMoradaDaPaz();
            
            try
            {
                serviceinstance.inserirOcorrencia(oco);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Ocorrencia Cadastrada");
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
        }
    }
}
