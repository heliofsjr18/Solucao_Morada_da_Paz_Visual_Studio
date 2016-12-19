using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Web.Services.Protocols;
using Morada_da_paz_Forms.wcf;
using System.ServiceModel;
using System.Xml;
using System.Diagnostics;

namespace Morada_da_paz_Forms.Arquivo
{
    public partial class NovaOcorrenciaWindow : Form
    {

        #region Atributos Sockets
        private NetworkStream networkStream;
        private BinaryWriter binaryWriter;
        private BinaryReader binaryReader;
        private TcpClient tcpClient;

        //private Thread thread;
        #endregion
        usuario us;
        string caminho;
        public NovaOcorrenciaWindow(usuario u)
        {

            InitializeComponent();
            this.us = u;
            caminho = @"" + Application.StartupPath +"\\Ocorrencias"+u.Nome_completo+".xml";
            if (u.Id_especializacao_usuario.Id > 1)
            {
                //checkBox1.Visible = false;
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            ocorrencia oco = new ocorrencia() { Numero_ocorrencia = "" + rnd.Next(1000), Situacao = "Em Aberto" };
            
            oco.Id_usuario = this.us;

            oco.Descricao = richTextBox1.Text;
            /*if (checkBox1.Checked == true)
                oco.TipoPublico = 1;
            else
                oco.TipoPublico = 0;*/


            Service1Client serviceinstance = new Service1Client();

            try
            {
                serviceinstance.inserirOcorrencia(oco);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("Ocorrencia Cadastrada");

            #region comunicando com o lado servidor pelo socket

            try
            {
                if (PrincipalWindow.binaryWriter != null)
                {
                    PrincipalWindow.binaryWriter.Write("Uma nova ocorrência foi adcionada!");
                }

            }
            catch (SocketException socketEx)
            {
                MessageBox.Show(socketEx.Message, "Erro");
            }
            #endregion

            //this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        public void runCliente()
        {
            try
            {
                tcpClient = new TcpClient();
                //conectando ao servidor
                tcpClient.Connect("127.0.0.1", 2001);

                networkStream = tcpClient.GetStream();
                binaryWriter = new BinaryWriter(networkStream);
                binaryReader = new BinaryReader(networkStream);
                //binaryWriter.Write("Uma nova ocorrência foi adcionada!\n\nAtualize a Lista!");
                String message = "";

                #region laço para receber mensagem do servidor
                do
                {
                    try
                    {
                        message = binaryReader.ReadString();
                        Invoke(new MethodInvoker(
                          delegate { MessageBox.Show("lado cliente" + message); }
                          ));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                        message = "FIM";
                    }
                } while (message != "FIM");
                #endregion

                binaryWriter.Close();
                binaryReader.Close();
                networkStream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void NovaOcorrenciaWindow_Load(object sender, EventArgs e)
        {
            try
            {


                Service1Client serviceInstance = new Service1Client();
                if (PrincipalWindow.usuarioAtivo.Id_especializacao_usuario.Id != 1)
                {
                    ocorrencia[] listaOcorrencia = serviceInstance.listarOcorrenciasPorUsuario(PrincipalWindow.usuarioAtivo);
                    for (int i = 0; i < listaOcorrencia.Count(); i++)
                    {
                        usuario usu = new usuario();
                        especializacao_usuario usuES = new especializacao_usuario();
                        unidade_residencial usuUR = new unidade_residencial();
                        //listaUsu.ElementAt(i).Id_unidade_residencial.Descricao = "Busca";
                        //listaUsu.ElementAt(i).Id_unidade_residencial.Numero_residencia = "0";

                        usu = serviceInstance.pesquisaUsuario(listaOcorrencia.ElementAt(i).Id_usuario);
                        //usu.Id_especializacao_usuario.Id = serviceInstance.pesquisaUsuario(listaOcorrencia.ElementAt(i).Id_usuario).Id_especializacao_usuario.Id;
                        //usu.Id_unidade_residencial.Id = serviceInstance.pesquisaUsuario(listaOcorrencia.ElementAt(i).Id_usuario).Id_unidade_residencial.Id;
                        usuES.Descricao = serviceInstance.pesquisaEspecializacao(usu.Id_especializacao_usuario).Descricao;
                        usuUR.Numero_residencia = serviceInstance.pesquisaUnidade(usu.Id_unidade_residencial).Numero_residencia;


                        ListViewItem linha = listViewMinhasOcorrencias.Items.Add(listaOcorrencia.ElementAt(i).Numero_ocorrencia);
                        linha.SubItems.Add(listaOcorrencia.ElementAt(i).Descricao);
                        linha.SubItems.Add(listaOcorrencia.ElementAt(i).Situacao);
                        linha.SubItems.Add(usu.Nome_completo);
                        linha.SubItems.Add(usuUR.Numero_residencia);
                        linha.SubItems.Add(usuES.Descricao);
                    }
                }
                else
                {
                    ocorrencia[] listaOcorrencia = serviceInstance.listarOcorrencias();
                    for (int i = 0; i < listaOcorrencia.Count(); i++)
                    {
                        usuario usu = new usuario();
                        especializacao_usuario usuES = new especializacao_usuario();
                        unidade_residencial usuUR = new unidade_residencial();
                        //listaUsu.ElementAt(i).Id_unidade_residencial.Descricao = "Busca";
                        //listaUsu.ElementAt(i).Id_unidade_residencial.Numero_residencia = "0";

                        usu = serviceInstance.pesquisaUsuario(listaOcorrencia.ElementAt(i).Id_usuario);
                        //usu.Id_especializacao_usuario.Id = serviceInstance.pesquisaUsuario(listaOcorrencia.ElementAt(i).Id_usuario).Id_especializacao_usuario.Id;
                        //usu.Id_unidade_residencial.Id = serviceInstance.pesquisaUsuario(listaOcorrencia.ElementAt(i).Id_usuario).Id_unidade_residencial.Id;
                        usuES.Descricao = serviceInstance.pesquisaEspecializacao(usu.Id_especializacao_usuario).Descricao;
                        usuUR.Numero_residencia = serviceInstance.pesquisaUnidade(usu.Id_unidade_residencial).Numero_residencia;


                        ListViewItem linha = listViewMinhasOcorrencias.Items.Add(listaOcorrencia.ElementAt(i).Numero_ocorrencia);
                        linha.SubItems.Add(listaOcorrencia.ElementAt(i).Descricao);
                        linha.SubItems.Add(usu.Nome_completo);
                        linha.SubItems.Add(usuUR.Numero_residencia);
                        linha.SubItems.Add(usuES.Descricao);
                        linha.SubItems.Add(listaOcorrencia.ElementAt(i).Situacao);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void gerarBackupXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Service1Client serviceInstance = new Service1Client();
            List<ocorrencia> listaOcorrencia = serviceInstance.listarOcorrenciasPorUsuario(PrincipalWindow.usuarioAtivo).ToList();
            for (int i = 0; i < listaOcorrencia.Count(); i++)
            {
                this.criarArquivo();

                usuario usu = serviceInstance.pesquisaUsuario(listaOcorrencia.ElementAt(i).Id_usuario);
                especializacao_usuario usuES = serviceInstance.pesquisaEspecializacao(usu.Id_especializacao_usuario);
                unidade_residencial usuUR = serviceInstance.pesquisaUnidade(usu.Id_unidade_residencial);
                

                #region abrir aquivo
                XmlDocument doc = new XmlDocument();
                doc.Load(this.caminho);
                #endregion

                #region definição dos elementos do xml
                XmlNode ocorrencia = doc.CreateElement("ocorrencia");
                XmlNode id = doc.CreateElement("id");
                XmlNode numero = doc.CreateElement("numero");
                XmlNode descricao = doc.CreateElement("descricao");
                XmlNode usuario = doc.CreateElement("usuario");
                XmlNode id_usuario = doc.CreateElement("idUsuario");
                XmlNode nome_usuario = doc.CreateElement("nomeUsuario");
                XmlNode status = doc.CreateElement("status");
                XmlNode publico = doc.CreateElement("publico");
                XmlNode undResidencial = doc.CreateElement("unidadeResidencial");
                XmlNode id_und = doc.CreateElement("id_und");
                XmlNode num_und = doc.CreateElement("numUnidadeResidencial");


                #endregion


                #region colocar valores nos elementos xml
                id.InnerText = "" + listaOcorrencia.ElementAt(i).Id;
                numero.InnerText = listaOcorrencia.ElementAt(i).Numero_ocorrencia;
                descricao.InnerText = listaOcorrencia.ElementAt(i).Descricao;
                id_usuario.InnerText = "" + usu.Id;
                nome_usuario.InnerText = "" + usu.Nome_completo;
                status.InnerText = listaOcorrencia.ElementAt(i).Situacao;
                publico.InnerText = "" + listaOcorrencia.ElementAt(i).TipoPublico;
                id_und.InnerText = "" + usuUR.Id;
                num_und.InnerText = "" + usuUR.Numero_residencia;
                #endregion

                #region definido hierarquia
                ocorrencia.AppendChild(id);
                ocorrencia.AppendChild(numero);
                ocorrencia.AppendChild(descricao);

                usuario.AppendChild(id_usuario);
                usuario.AppendChild(nome_usuario);


                ocorrencia.AppendChild(usuario);
                ocorrencia.AppendChild(status);
                ocorrencia.AppendChild(publico);

                undResidencial.AppendChild(id_und);
                undResidencial.AppendChild(num_und);

                ocorrencia.AppendChild(undResidencial);
                #endregion


                #region adicionando ao elemento raiz
                doc.SelectSingleNode("/minhasOcorrencias").AppendChild(ocorrencia);
                doc.Save(this.caminho);
                #endregion


            }
            MessageBox.Show("Documento salvo em " + this.caminho);
            Process.Start("Explorer", @"" + Application.StartupPath);
        }


    }
}