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
using System.Web.Services.Protocols;

namespace Morada_da_paz_Forms.Cadastro
{
    public partial class UserRegWindow : Form
    {
        List<especializacao_usuario> listaEspecial;
        List<unidade_residencial> ListaUnidade;
        public UserRegWindow()
        {
            InitializeComponent();
            if (PrincipalWindow.usuarioAtivo.Id_especializacao_usuario.Id != 1)
            {
                this.Height = 301;
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


                Service1 serviceinstance = new Service1();
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


            Service1 serviceinstance = new Service1();
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
            Service1 serviceInstance = new Service1();
            usuario[] listaUsu = serviceInstance.listarUsuarios();
            for (int i = 0; i < listaUsu.Count(); i++)
            {
                unidade_residencial usuUR = new unidade_residencial();
                listaUsu.ElementAt(i).Id_unidade_residencial.Descricao = "Busca";
                listaUsu.ElementAt(i).Id_unidade_residencial.Numero_residencia = "0";
                usuUR.Numero_residencia = serviceInstance.pesquisaUnidade(listaUsu.ElementAt(i).Id_unidade_residencial).Numero_residencia;
                especializacao_usuario usuES = new especializacao_usuario();
                listaUsu.ElementAt(i).Id_especializacao_usuario.Descricao = "Busca";
                usuES.Descricao = serviceInstance.pesquisaEspecializacao(listaUsu.ElementAt(i).Id_especializacao_usuario).Descricao;
                ListViewItem linha = listView1.Items.Add(listaUsu.ElementAt(i).Nome_completo);
                linha.SubItems.Add(listaUsu.ElementAt(i).Email);
                linha.SubItems.Add(usuUR.Numero_residencia);
                linha.SubItems.Add(usuES.Descricao);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
