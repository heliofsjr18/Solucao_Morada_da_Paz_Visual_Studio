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
    public partial class UserRegWindow : Form
    {
        List<especializacao_usuario> listaEspecial;
        List<unidade_residencial> ListaUnidade;
        public UserRegWindow()
        {
            InitializeComponent();
            if (PrincipalWindow.usuarioAtivo.Id_especializacao_usuario.Id == 1)
            {
                this.Height = 574;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox getSender = (CheckBox)sender;
            textBoxSenha.UseSystemPasswordChar = !getSender.Checked;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario u = new usuario()
                {
                    Nome_completo = textBoxNomeCompleto.Text,
                    Email = textBoxEmail.Text,
                    Login = textBoxLogin.Text,
                    Senha = textBoxSenha.Text
                };

                int indexEU = comboBoxEspecializacao.SelectedIndex;
                especializacao_usuario esp = listaEspecial.ElementAt(indexEU);
                int indexUR = comboBoxUnidadeResidencial.SelectedIndex;
                unidade_residencial und = ListaUnidade.ElementAt(indexUR);

                u.Id_especializacao_usuario = esp;
                u.Id_unidade_residencial = und;


                MRDP.ServiceMorada_Da_PazClient serviceinstance = new ServiceMorada_Da_PazClient();
                serviceinstance.inseirUsuario(u);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Usuario Cadastrado");
            this.Dispose();
        }

        private void UserRegWindow_Shown(object sender, EventArgs e)
        {


            MRDP.ServiceMorada_Da_PazClient serviceinstance = new ServiceMorada_Da_PazClient();
            this.listaEspecial = serviceinstance.listarEspecializacao().ToList();
            this.ListaUnidade = serviceinstance.listarUnidades().ToList();
            for (int i = 0; i < listaEspecial.Count; i++)
            {
                comboBoxEspecializacao.Items.Add(listaEspecial.ElementAt(i).Descricao);
            }
            for (int i = 0; i < ListaUnidade.Count; i++)
            {
                comboBoxUnidadeResidencial.Items.Add(ListaUnidade.ElementAt(i).Numero_residencia);
            }
        }

        private void UserRegWindow_Load(object sender, EventArgs e)
        {
            MRDP.ServiceMorada_Da_PazClient serviceInstance = new MRDP.ServiceMorada_Da_PazClient();
            usuario[] listaUsuario = serviceInstance.listarUsuarios().ToArray();
            for (int i = 0; i < listaUsuario.Count(); i++)
            {
                unidade_residencial usuUR;
                listaUsuario.ElementAt(i).Id_unidade_residencial.Descricao = "Busca";
                listaUsuario.ElementAt(i).Id_unidade_residencial.Numero_residencia = "0";
                listaUsuario.ElementAt(i).Id_especializacao_usuario.Descricao = "Busca";
                especializacao_usuario usuES;
                usuUR = new MRDP.ServiceMorada_Da_PazClient().pesquisaUnidade(listaUsuario.ElementAt(i).Id_unidade_residencial);
                usuES = new MRDP.ServiceMorada_Da_PazClient().pesquisaEspecializacao(listaUsuario.ElementAt(i).Id_especializacao_usuario);
                ListViewItem linha = listViewUsuarios.Items.Add(listaUsuario.ElementAt(i).Nome_completo);
                linha.SubItems.Add(listaUsuario.ElementAt(i).Email);
                linha.SubItems.Add(usuUR.Numero_residencia);
                linha.SubItems.Add(usuES.Descricao);
            }
        }
    }
}
