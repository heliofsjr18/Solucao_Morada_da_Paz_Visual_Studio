
using Morada_da_paz_Forms.wcf;
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
        List<unidade_residencial> unidade;
        List<multa> multa;
        List<advertencia> advertencia;
        List<ocorrencia> listaOcorrencia;


        ocorrencia selectOco = new ocorrencia();

        public EditOcorrenciaWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void preencheComponentes()
        {
            this.unidade = new Service1Client().listarUnidades().ToList();
            for (int i = 0; i < unidade.Count(); i++)
            {
                comboBox1.Items.Add(unidade.ElementAt(i).Numero_residencia);
            }
            comboBox1.Text = unidade.ElementAt(0).Numero_residencia;


            comboBox2.Items.Add("Em Aberto");
            comboBox2.Items.Add("Em Análise");
            comboBox2.Items.Add("Cancelada");
            comboBox2.Items.Add("Finalizada");
            comboBox2.Text = "Em Aberto";

            
            this.multa = new Service1Client().listarMulta().ToList();
            for (int i = 0; i < multa.Count(); i++)
            {
                comboBoxMulta.Items.Add(multa.ElementAt(i).Descricao);
            }

            this.advertencia = new Service1Client().listarAdvertencias().ToList();
            for (int i = 0; i < advertencia.Count(); i++)
            {
                comboBoxAdvertencia.Items.Add(advertencia.ElementAt(i).Descricao);
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((checkBoxMulta.Checked == false) || (checkBoxAdvertencia.Checked == false))
                {
                    MessageBox.Show("Favor selecionar uma Sanção");
                    return;
                }



                Service1Client sv = new Service1Client();
                int index = listViewMinhasOcorrencias.FocusedItem.Index;
                ocorrencia o = this.listaOcorrencia.ElementAt(index);
                if (o.Numero_ocorrencia == null)
                {
                    MessageBox.Show("Nenhuma Ocorrência Selecionada");
                    return;
                }

                if (!comboBox1.Text.Equals(""))
                {
                    int indexUnd = comboBox1.SelectedIndex;
                    unidade_residencial und = this.unidade.ElementAt(indexUnd);
                    o.Id_unidade_residencial = und;
                }
                else
                {
                    MessageBox.Show("Selecione uma Unidade Residencial!");
                    return;
                }

                if (!comboBox2.Text.Equals(""))
                {
                    o.Situacao = comboBox2.Text;
                }

                if (checkBox1.Checked)
                {
                    o.TipoPublico = 1;
                }
                else
                {
                    o.TipoPublico = 0;
                }

                sv.editarOcorrencia(o);

                if (checkBoxMulta.Checked == true)
                {
                    if (comboBoxMulta.Text.Equals(""))
                    {
                        MessageBox.Show("Selecione uma multa!");
                        return;
                    }
                    else
                    {
                        int indexM = comboBoxMulta.SelectedIndex;
                        multa m = this.multa.ElementAt(indexM);
                        sv.inserirMultaOcorrencia(m, o);
                    }
                }

                if (checkBoxAdvertencia.Checked == true)
                {
                    if (comboBoxAdvertencia.Text.Equals(""))
                    {
                        MessageBox.Show("Selecione uma advertência!");
                        return;
                    }
                    else
                    {
                        int indexA = comboBoxAdvertencia.SelectedIndex;
                        advertencia a = this.advertencia.ElementAt(indexA);
                        sv.inserirAdvertenciaOcorrencia(a, o);
                    }
                }

                MessageBox.Show("Transação concluída!");
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

        }

        private void preenheListViewSancao(ocorrencia o)
        {
            Service1Client sv = new Service1Client();
            List<multa> lm = sv.listaMultaPorOcorrencia(o).ToList();
            List<advertencia> la = sv.listaAdvertenciaPorOcorrencia(o).ToList();

            Boolean controle = true;
            int x = 0;

            while (controle)
            {
                ListViewItem linha = listView1.Items.Add(o.Numero_ocorrencia);
                if (x < lm.Count)
                {
                    linha.SubItems.Add(lm.ElementAt(x).Descricao);
                    linha.SubItems.Add(""+lm.ElementAt(x).Preco);
                    if (x >= la.Count)
                    {
                        linha.SubItems.Add(o.Id_unidade_residencial.Descricao);
                        controle = false;
                        break;

                    }
                }else
                {
                    linha.SubItems.Add("Nenhuma");
                    linha.SubItems.Add("0");
                    if (x >= la.Count)
                    {
                        linha.SubItems.Add(o.Id_unidade_residencial.Descricao);
                        controle = false;
                        break;

                    }
                }

                if(x < la.Count)
                {
                    linha.SubItems.Add(la.ElementAt(x).Descricao);
                    if (x >= lm.Count)
                    {
                        linha.SubItems.Add(o.Id_unidade_residencial.Descricao);
                        controle = false;
                        break;
                    }
                }else
                {
                    linha.SubItems.Add("Nenhuma");
                    if (x >= lm.Count)
                    {
                        linha.SubItems.Add(o.Id_unidade_residencial.Descricao);
                        controle = false;
                        break;
                    }
                }

                linha.SubItems.Add(o.Id_unidade_residencial.Descricao);
            }
                
            
            
            
            

        }

        private void EditOcorrenciaWindow_Load(object sender, EventArgs e)
        {
            preencherGrid();
            preencheComponentes();
        }

        private void EditOcorrenciaWindow_Shown(object sender, EventArgs e)
        {

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
                    Service1Client instanceService = new Service1Client();
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
            Service1Client serviceInstance = new Service1Client();
            this.listaOcorrencia = serviceInstance.listarOcorrencias().ToList();
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
            Service1Client serviceInstance = new Service1Client();
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

        private void listViewMinhasOcorrencias_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void listViewMinhasOcorrencias_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void listViewMinhasOcorrencias_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listViewMinhasOcorrencias.FocusedItem.Index;
            ocorrencia o = this.listaOcorrencia.ElementAt(index);

            comboBox1.Text = o.Id_unidade_residencial.Numero_residencia;
            comboBox2.Text = o.Situacao;
            //preenheListViewSancao(o);

        }
    }
}