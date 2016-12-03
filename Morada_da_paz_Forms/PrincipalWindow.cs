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

using System.IO;
using System.Xml;
using Morada_da_paz_Forms.Edicao;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using Morada_da_paz_Forms.MRDP;

namespace Morada_da_paz_Forms
{

    public partial class PrincipalWindow : Form
    {
        #region Atributos de sockets
        private Socket socket;
        private Thread thread;
        private TcpClient tcpClient;

        private NetworkStream networkStream;
        public static BinaryWriter binaryWriter;
        private BinaryReader binaryReader;

        TcpListener tcpListener;
        #endregion
        public static usuario usuarioAtivo;
        private string caminho;

        NovaOcorrenciaWindow now;
        MRDP.ServiceMorada_Da_PazClient sv;
        List<ocorrencia> ocorrenciaLista;

        public PrincipalWindow(usuario login)
        {
            usuarioAtivo = login;
            now = new NovaOcorrenciaWindow(login);
            InitializeComponent();
            caminho = @"" + Application.StartupPath + "\\ocorrencias" + usuarioAtivo.Nome_completo + ".xml";
            this.verificaUsuario(login);
            this.Text += " -> " + usuarioAtivo.Nome_completo;

            if (usuarioAtivo.Id_especializacao_usuario.Id == 1)
            {
                thread = new Thread(new ThreadStart(RunServidor));
                thread.Start();
                //this.carregaOcorrencias();                
                this.labelCadastro.Location = new Point(281, 25);
                this.labelCadastro.Visible = true;
                this.labelConsulta.Visible = false;
            }
            else
            {
                thread = new Thread(new ThreadStart(runCliente));
                thread.Start();
                this.labelCadastro.Visible = false;
                this.labelConsulta.Visible = true;
            }
            mudarUsuárioToolStripMenuItem.Visible = false;

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


            if (usuarioAtivo.Id_especializacao_usuario.Id == 1)
            {

                if (tcpListener != null)
                {
                    tcpListener.Stop();
                }

                /*if(thread != null)
                {
                    thread.Abort();
                }*/
                Environment.Exit(0);

            }
            else
            {

                Application.Exit();
            }





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
            if (usuarioAtivo.Id_especializacao_usuario.Id > 1)
            {
                //thread = new Thread(new ThreadStart(runCliente));
                //thread.Abort();     
            }
            NovaOcorrenciaWindow window = new NovaOcorrenciaWindow(usuarioAtivo);
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
                Application.Restart();
            }
        }

        public void carregaOcorrencias()
        {
            try
            {
                this.sv = new ServiceMorada_Da_PazClient();

                if (usuarioAtivo.Id_especializacao_usuario.Id == 1)
                {
                    this.ocorrenciaLista = sv.listarOcorrencias().ToList();
                }
                else
                {
                    this.ocorrenciaLista = sv.listarOcorrenciasPorUsuario(usuarioAtivo).ToList();
                }

                //listViewMinhasOcorrencias.Items.Clear();
                for (int index = 0; index < ocorrenciaLista.Count; index++)
                {

                    //ListViewItem linha = listViewMinhasOcorrencias.Items.Add(ocorrenciaLista.ElementAt(index).Numero_ocorrencia);
                    //linha.SubItems.Add(ocorrenciaLista.ElementAt(index).Descricao);
                    //linha.SubItems.Add(ocorrenciaLista.ElementAt(index).Situacao);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PrincipalWindow_Load(object sender, EventArgs e)
        {
            textBoxNameUser.Text = usuarioAtivo.Nome_completo;
            usuarioAtivo.Id_unidade_residencial.Descricao = "Busca";
            usuarioAtivo.Id_unidade_residencial.Numero_residencia = "0";
            unidade_residencial usuUR = new MRDP.ServiceMorada_Da_PazClient().pesquisaUnidade(usuarioAtivo.Id_unidade_residencial);
            textBoxUR.Text = usuUR.Numero_residencia;
            this.carregaOcorrencias();
        }

        private void buttonAtulizar_Click(object sender, EventArgs e)
        {
            this.carregaOcorrencias();

            if (usuarioAtivo.Id_especializacao_usuario.Id == 1)
            {
                try
                {
                    if (binaryWriter != null)
                    {
                        binaryWriter.Write("Ocorrencia disponível para o síndico!");
                    }

                }
                catch (SocketException socketEx)
                {
                    MessageBox.Show(socketEx.Message, "Erro1");
                }
                catch (Exception socketEx)
                {
                    MessageBox.Show(socketEx.Message, "Erro2");
                }
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
                XmlNode id = doc.CreateElement("id");
                XmlNode numero = doc.CreateElement("numero");
                XmlNode descricao = doc.CreateElement("descricao");
                XmlNode usuario = doc.CreateElement("usuario");
                XmlNode id_usuario = doc.CreateElement("idUsuario");
                XmlNode status = doc.CreateElement("status");
                XmlNode publico = doc.CreateElement("publico");
                XmlNode undResidencial = doc.CreateElement("unidadeResidencial");
                XmlNode id_und = doc.CreateElement("id_und");


                #endregion


                #region colocar valores nos elementos xml
                id.InnerText = "" + o.Id;
                numero.InnerText = o.Numero_ocorrencia;
                descricao.InnerText = o.Descricao;
                id_usuario.InnerText = "" + o.Id_usuario.Id;
                status.InnerText = o.Situacao;
                publico.InnerText = "" + o.TipoPublico;
                id_und.InnerText = "" + o.Id_unidade_residencial.Id;
                #endregion

                #region definido hierarquia
                ocorrencia.AppendChild(id);
                ocorrencia.AppendChild(numero);
                ocorrencia.AppendChild(descricao);

                usuario.AppendChild(id_usuario);

                ocorrencia.AppendChild(usuario);
                ocorrencia.AppendChild(status);
                ocorrencia.AppendChild(publico);

                undResidencial.AppendChild(id_und);

                ocorrencia.AppendChild(undResidencial);
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
            MRDP.ServiceMorada_Da_PazClient sv = new ServiceMorada_Da_PazClient();
            List<ocorrencia> ocorrenciaLista = this.ocorrenciaLista;//sv.listarOcorrencias();
            #endregion
            #region loop para preenchimento do XML
            for (int x = 0; x < ocorrenciaLista.Count; x++)
            {
                this.criarArquivo();
                this.novaLinha(ocorrenciaLista.ElementAt(x));
            }
            #endregion

            MessageBox.Show("Documento salvo em " + this.caminho);
            Process.Start("Explorer", @"" + Application.StartupPath);
        }

        private void listViewMinhasOcorrencias_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (usuarioAtivo.Id_especializacao_usuario.Id == 1)
            {
                //int indexListView = listViewMinhasOcorrencias.FocusedItem.Index;
                //ocorrencia oc = this.ocorrenciaLista.ElementAt(indexListView);
                //EditOcorrenciaWindow eo = new EditOcorrenciaWindow(oc);
                //eo.ShowDialog();
            }
        }


        private void verificaUsuario(usuario u)
        {



            if (u.Id_especializacao_usuario.Id > 1)
            {
                menuStrip1.Items[1].Visible = false;
                menuStrip1.Items[2].Visible = false;
            }
        }

        private void mostraMensagem(object ob)
        {
            if (usuarioAtivo.Id_especializacao_usuario.Id == 1)
            {
                Invoke(new MethodInvoker(
                         delegate { MessageBox.Show(this, "" + ob, "MRDP -> ADM"); }
                                         ));
            }

        }

        public void RunServidor()
        {
            if (usuarioAtivo.Id_especializacao_usuario.Id == 1)
            {
                try
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2001);
                    tcpListener = new TcpListener(ipEndPoint);
                    tcpListener.Start();



                    socket = tcpListener.AcceptSocket();
                    networkStream = new NetworkStream(socket);
                    binaryWriter = new BinaryWriter(networkStream);
                    binaryReader = new BinaryReader(networkStream);



                    string message = "";
                    do
                    {
                        try
                        {
                            if (binaryReader != null)
                            {
                                message = binaryReader.ReadString();

                                mostraMensagem("" + message);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, ex.Message, "ADM");
                        }


                    } while (socket.Connected);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (binaryReader != null)
                    {
                        binaryReader.Close();
                    }
                    if (binaryWriter != null)
                    {
                        binaryWriter.Close();
                    }
                    if (networkStream != null)
                    {
                        networkStream.Close();
                    }
                    if (socket != null)
                    {
                        socket.Close();
                    }
                    MessageBox.Show("conexão finalizada", "ADM");

                }
            }

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
                        if (binaryReader != null)
                        {
                            message = binaryReader.ReadString();
                            Invoke(new MethodInvoker(
                                delegate { MessageBox.Show(this, "" + message, "MRDP -> Morador"); }
                            ));
                        }

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
            catch (SocketException ex)
            {
                MessageBox.Show("No momento o síndico não está logado, sua Ocorrência pode demorar a ser visualizada!", "Síndico indisponivel!..." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                MessageBox.Show(ex.Message, "Erro2");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MuralWindow muralWindow = new MuralWindow();
            muralWindow.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegWindow userWindow = new UserRegWindow();
            userWindow.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdvertenciaRegWindow advertenciaWindow = new AdvertenciaRegWindow();
            advertenciaWindow.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MultaRegWindow multaWindow = new MultaRegWindow();
            multaWindow.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NovaOcorrenciaWindow ocorrenciaWindow = new NovaOcorrenciaWindow(PrincipalWindow.usuarioAtivo);
            ocorrenciaWindow.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelCadastro_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditOcorrenciaWindow sansaoWindow = new EditOcorrenciaWindow();
            sansaoWindow.ShowDialog();
        }
    }

}

