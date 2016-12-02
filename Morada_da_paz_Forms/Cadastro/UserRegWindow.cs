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

namespace Morada_da_paz_Forms.Cadastro
{
    public partial class UserRegWindow : Form
    {
        List<especializacao_usuario> listaEspecial;
        List<unidade_residencial> ListaUnidade;
        public UserRegWindow()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox getSender = (CheckBox)sender;
            textBoxSenha.UseSystemPasswordChar = !getSender.Checked;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            usuario u = new usuario() { Nome_completo = textBoxNomeCompleto.Text,
                                        Email = textBoxEmail.Text,
                                        Login = textBoxLogin.Text,
                                        Senha = textBoxSenha.Text};

            int indexEU = comboBoxEspecializacao.SelectedIndex;
            especializacao_usuario esp = listaEspecial.ElementAt(indexEU);
            int indexUR = comboBoxUnidadeResidencial.SelectedIndex;
            unidade_residencial und = ListaUnidade.ElementAt(indexUR);

            u.Id_especializacao_usuario = esp;
            u.Id_unidade_residencial = und;

            ServiceMoradaDaPaz serviceinstance = new ServiceMoradaDaPaz();
            try
            {
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
            ServiceMoradaDaPaz serviceInstance = new ServiceMoradaDaPaz();
            this.listaEspecial = serviceInstance.listarEspecializacao();
            this.ListaUnidade = serviceInstance.listarUnidades();
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

        }
    }
}
