using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Morada_da_paz_Forms.Cadastro;
using Morada_da_paz_Forms.Arquivo;
using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_WebService;
using System.IO;
using System.Xml;
using Morada_da_paz_Forms.Edicao;

namespace Morada_da_paz_Forms
{
     
    public partial class PrincipalWindow : Form
    {
        private string caminho = @"c:\xml\ocorrencias.xml";
        public static usuario usuarioAtivo = new usuario();

        ServiceMoradaDaPaz sv;
        List<ocorrencia> ocorrenciaLista;

        public PrincipalWindow(usuario login)
        {
            usuarioAtivo = login;
            InitializeComponent();
            this.Text += " -> " + usuarioAtivo.Nome_completo;

        }

        

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Projeto para o gerenciamento de ocorrencias em um condominio, Desenvolvido por: ", "Sobre o Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this, "MORADA DA PAZ SOLUÇÕES - Sistemas de gerenciamento de Ocorrências\n\nDesenvolvedores:\n\nHélio Ferreira\nJorge Marçal\nGabriel Rodrigo\nDayvson Wellerson", "Projeto para Gerenciamento de Ocorrencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrincipalWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unidadeResidencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnidadeResidRegWindow window = new UnidadeResidRegWindow();
            window.ShowDialog();
        }

        private void advertênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvertenciaRegWindow window = new AdvertenciaRegWindow();
            window.ShowDialog();
        }

        private void multaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultaRegWindow window = new MultaRegWindow();
            window.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegWindow window = new UserRegWindow();
            window.ShowDialog();
        }

        private void gerarNovaOcorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaOcorrenciaWindow window = new NovaOcorrenciaWindow();
            window.ShowDialog();
        }

        private void muralDeOcorrenciasPublicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuralWindow window = new MuralWindow();
            window.ShowDialog();
        }

        private void mudarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult getResult = MessageBox.Show(this, "Deseja Trocar de Usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (getResult == DialogResult.Yes)
            {
            }
        }

        public void carregaOcorrencias()
        {
            try
            {
                this.sv = new ServiceMoradaDaPaz();
               this.ocorrenciaLista = sv.listarOcorrenciasPorUsuario(usuarioAtivo);
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

        private void PrincipalWindow_Load(object sender, EventArgs e)
        {
            this.carregaOcorrencias();
        }

        private void buttonAtulizar_Click(object sender, EventArgs e)
        {
            this.carregaOcorrencias();
        }

        #region codigos de manipulação de XML
        public void criarArquivo()
        {
            try
            {
                if (File.Exists(this.caminho) == false)
                {
                    XmlDocument doc = new XmlDocument();
                    XmlNode raiz = doc.CreateElement("minhasOcorrencias");
                    doc.AppendChild(raiz);
                    doc.Save(this.caminho);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region add nova linha
        public void novaLinha(ocorrencia o)
        {
            try
            {
                #region abrir aquivo
                XmlDocument doc = new XmlDocument();
                doc.Load(this.caminho);
                #endregion

                #region definição dos elementos do xml
                XmlNode ocorrencia = doc.CreateElement("ocorrencia");
                XmlNode numero = doc.CreateElement("numero");
                XmlNode descricao = doc.CreateElement("descricao");
                XmlNode status = doc.CreateElement("status");
                #endregion

                

                
                #region colocar valores nos elementos xml
                numero.InnerText = o.Numero_ocorrencia;
                descricao.InnerText = o.Descricao;
                status.InnerText = o.Situacao;
                #endregion

                #region definido hierarquia
                ocorrencia.AppendChild(numero);
                ocorrencia.AppendChild(descricao);
                ocorrencia.AppendChild(status);
                #endregion
                

                #region adicionando ao elemento raiz
                doc.SelectSingleNode("/minhasOcorrencias").AppendChild(ocorrencia);
                doc.Save(this.caminho);
                #endregion

                


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void buttonGeraXml_Click(object sender, EventArgs e)
        {
            #region instancia do webservice e criação da lista de ocorrencia
            ServiceMoradaDaPaz sv = new ServiceMoradaDaPaz();
            List<ocorrencia> ocorrenciaLista = sv.listarOcorrenciasPorUsuario(usuarioAtivo);
            #endregion
            #region loop para preenchimento do XML
            for (int x = 0; x < ocorrenciaLista.Count; x++)
            {
                this.criarArquivo();
                this.novaLinha(ocorrenciaLista.ElementAt(x));
            }
            #endregion

            MessageBox.Show("Documento salvo em " + this.caminho);
        }

        private void listViewMinhasOcorrencias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indexListView = listViewMinhasOcorrencias.FocusedItem.Index;
            ocorrencia oc = this.ocorrenciaLista.ElementAt(indexListView);
            //MessageBox.Show(oc.Numero_ocorrencia);
            EditOcorrenciaWindow eo = new EditOcorrenciaWindow(oc);
            eo.ShowDialog();
        }
    }
}
