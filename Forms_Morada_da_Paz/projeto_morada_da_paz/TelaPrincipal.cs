﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_morada_da_paz
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void novaOcorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaOcorrencia nOcorrencia = new NovaOcorrencia();
            nOcorrencia.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NovoUsuario nUsuario = new NovoUsuario();
            nUsuario.ShowDialog();
        }

        private void multaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Multa nMulta = new Multa();
            nMulta.ShowDialog();
        }

        private void advertênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Advertencia nAdvertencia = new Advertencia();
            nAdvertencia.ShowDialog();
        }

        private void unidadeResidencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaUnidadeResidencial nUniResidencial = new NovaUnidadeResidencial();
            nUniResidencial.ShowDialog();
        }
    }
}