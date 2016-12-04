
using Morada_da_paz_Forms.MRDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morada_da_paz_Forms.Edicao
{
    public partial class EditOcorrenciaWindow : Form
    {
        //ocorrencia oc;
        List<unidade_residencial> ListaUnidade;
        List<multa> listaMulta;
        List<advertencia> listaAdvertencia;
        //Boolean controle;
        ocorrencia selectOco = new ocorrencia();

        public EditOcorrenciaWindow()
        {
            //oc = o;
            InitializeComponent();
            //this.preencheComponentes(o);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void preencheComponentes()
        {
            unidade_residencial[] unidade = new Service1().listarUnidades();
            for (int i = 0; i < unidade.Count(); i++)
            {
                comboBox1.Items.Add(unidade.ElementAt(i).Numero_residencia);
            }
            comboBox1.Text = unidade.ElementAt(0).Numero_residencia;

            //textBoxNumero.Text = o.Numero_ocorrencia;
            //richTextBoxDescricao.Text = o.Descricao;
            //es[] unidade = new Service1().listarUnidades();

            comboBox2.Items.Add("Em Aberto");
            comboBox2.Items.Add("Em Análise");
            comboBox2.Items.Add("Cancelada");
            comboBox2.Items.Add("Finalizada");
            comboBox2.Text = "Em Aberto";
            //comboBox2.Text = o.Situacao;
            //if (o.TipoPublico == 1)
            multa[] multa = new Service1().listarMulta();
            for (int i = 0; i < unidade.Count(); i++)
            {
                comboBoxMulta.Items.Add(multa.ElementAt(i).Descricao);
            }
            advertencia[] advertencia = new Service1().listarAdvertencias();
            for (int i = 0; i < advertencia.Count(); i++)
            {
                comboBoxAdvertencia.Items.Add(advertencia.ElementAt(i).Descricao);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if ((checkBoxMulta.Checked == false) || (checkBoxAdvertencia.Checked == false))
            {
                MessageBox.Show("Favor selecionar uma Sanção");
                return;
            }
            if (this.selectOco.Numero_ocorrencia == null)
            {
                MessageBox.Show("Nenhuma Ocorrência Selecionada");
            }
            else
            {
                Service1 instanceService = new Service1();
                //instanceService.atribuirUnidade(this.selectOco);
                
            }
        }

        private void EditOcorrenciaWindow_Load(object sender, EventArgs e)
        {
            preencherGrid();
            preencheComponentes();
        }

        private void EditOcorrenciaWindow_Shown(object sender, EventArgs e)
        {
            try
            {

                MRDP.Service1 sv = new Service1();
                this.ListaUnidade = sv.listarUnidades().ToList();


                for (int i = 0; i < ListaUnidade.Count; i++)
                {
                    //comboBoxUnd.Items.Add(ListaUnidade.ElementAt(i).Numero_residencia);
                }

                this.listaMulta = sv.listarMulta().ToList();

                for (int x = 0; x < listaMulta.Count; x++)
                {
                    comboBoxMulta.Items.Add(listaMulta.ElementAt(x).Descricao);
                }

                this.listaAdvertencia = sv.listarAdvertencias().ToList();

                for (int y = 0; y < listaAdvertencia.Count; y++)
                {
                    comboBoxAdvertencia.Items.Add(listaAdvertencia.ElementAt(y).Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.selectOco.Numero_ocorrencia == null)
            {
                MessageBox.Show("Nenhuma Ocorrência selecionada");
            }
            else
            {
                DialogResult confirma = MessageBox.Show(this, "Deseja mesmo excluir o registro de ocorrência selecionado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirma == DialogResult.Yes)
                {
                    Service1 instanceService = new Service1();
                    instanceService.excluiOcorrencia(this.selectOco);
                    MessageBox.Show(this, "A Ocorrência selecionada foi excluida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarGrid();
                }
                else
                    return;
            }
            /*int selectedrowindex = datagridview1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = datagridview1.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells["you have to mention you cell  corresponding column name"].Value);*/



            /*ocorrencia oco = new ocorrencia();
            oco.Numero_ocorrencia = listViewMinhasOcorrencias
            Service1 sv = new Service1();
            sv.excluiOcorrencia(oco);
            MessageBox.Show("Ocorrência Excluida!");
            this.Dispose();*/
        }


        private void preencherGrid()
        {
            Service1 serviceInstance = new Service1();
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

        private void checkBoxMulta_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMulta.Enabled = checkBoxMulta.Checked;
        }

        private void checkBoxAdvertencia_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxAdvertencia.Enabled = checkBoxAdvertencia.Checked;
        }

        private void listViewMinhasOcorrencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMinhasOcorrencias.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewMinhasOcorrencias.SelectedItems[0];
                this.selectOco.Numero_ocorrencia = item.SubItems[0].Text;
            }
            else
            {
                this.selectOco.Numero_ocorrencia = "";
            }
        }
        private void atualizarGrid()
        {
            listViewMinhasOcorrencias.Items.Clear();
            Service1 serviceInstance = new Service1();
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