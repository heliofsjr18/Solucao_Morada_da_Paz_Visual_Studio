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
using Morada_da_paz_Forms.MRDP;

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
        public NovaOcorrenciaWindow(usuario u)
        {

            InitializeComponent();
            this.us = u;
            if (u.Id_especializacao_usuario.Id > 1)
            {
                //checkBox1.Visible = false;
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            ocorrencia oco = new ocorrencia() { Numero_ocorrencia = "" + rnd.Next(1000), Situacao = "Em Aberto" };
            MessageBox.Show("" + this.us.Id);
            oco.Id_usuario = this.us;

            oco.Descricao = richTextBox1.Text;
            /*if (checkBox1.Checked == true)
                oco.TipoPublico = 1;
            else
                oco.TipoPublico = 0;*/


            Service1 serviceinstance = new Service1();

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

            #region comunicando com o lado servidor pelo socket

            try
            {
                if (PrincipalWindow.binaryWriter != null)
                {
                    PrincipalWindow.binaryWriter.Write("Uma nova ocorrência foi adcionada!\n\nAtualize a Lista!");
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
            Service1 serviceInstance = new Service1();
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
    }
}