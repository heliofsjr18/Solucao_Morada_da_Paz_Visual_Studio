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

namespace Morada_da_paz_Forms
{
    public partial class PrincipalWindow : Form
    {        
        public PrincipalWindow()
        {
            InitializeComponent();
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
    }
}