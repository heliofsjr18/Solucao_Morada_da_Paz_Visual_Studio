using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morada_da_paz_Forms.Arquivo
{
    public partial class MuralWindow : Form
    {
        ServiceMoradaDaPaz sv;
        List<ocorrencia> ocorrenciaLista;
        public MuralWindow()
        {
            InitializeComponent();
            this.carregaOcorrencias();
        }

        public void carregaOcorrencias()
        {
            try
            {
                this.sv = new ServiceMoradaDaPaz();
                
                this.ocorrenciaLista = sv.listarOcorrencasPublicas();
                
                listViewMinhasOcorrencias.Items.Clear();
                for (int index = 0; index < ocorrenciaLista.Count; index++)
                {

                    ListViewItem linha = listViewMinhasOcorrencias.Items.Add(ocorrenciaLista.ElementAt(index).Numero_ocorrencia);
                    linha.SubItems.Add(ocorrenciaLista.ElementAt(index).Descricao);
                    linha.SubItems.Add(ocorrenciaLista.ElementAt(index).Situacao);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
