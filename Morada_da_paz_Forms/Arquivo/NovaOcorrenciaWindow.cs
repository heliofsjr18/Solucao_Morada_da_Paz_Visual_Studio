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
            ocorrencia oco = new ocorrencia() { Situacao = "Em Aberto", Numero_ocorrencia = "156" };
            oco.Descricao = richTextBox1.Text;
            oco.TipoPublico = false;
            oco.Id_usuario.Id = 1;
            oco.Id_unidade_residencial.Id = 1;
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
    }
}
