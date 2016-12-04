namespace Morada_da_paz_Forms.Arquivo
{
    partial class NovaOcorrenciaWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaOcorrenciaWindow));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.listViewMinhasOcorrencias = new System.Windows.Forms.ListView();
            this.Número = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnidadeRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Condição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(624, 115);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a sua ocorrência com maior quantidade de detalhes que puder.";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.Color.Green;
            this.buttonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviar.ForeColor = System.Drawing.Color.White;
            this.buttonEnviar.Location = new System.Drawing.Point(6, 162);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(135, 41);
            this.buttonEnviar.TabIndex = 2;
            this.buttonEnviar.Text = "Salvar";
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Red;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(147, 162);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(135, 41);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // listViewMinhasOcorrencias
            // 
            this.listViewMinhasOcorrencias.AllowColumnReorder = true;
            this.listViewMinhasOcorrencias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Número,
            this.Descrição,
            this.NomeCompleto,
            this.UnidadeRes,
            this.Condição,
            this.Status});
            this.listViewMinhasOcorrencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMinhasOcorrencias.FullRowSelect = true;
            this.listViewMinhasOcorrencias.GridLines = true;
            this.listViewMinhasOcorrencias.Location = new System.Drawing.Point(6, 19);
            this.listViewMinhasOcorrencias.Name = "listViewMinhasOcorrencias";
            this.listViewMinhasOcorrencias.Size = new System.Drawing.Size(970, 175);
            this.listViewMinhasOcorrencias.TabIndex = 25;
            this.listViewMinhasOcorrencias.UseCompatibleStateImageBehavior = false;
            this.listViewMinhasOcorrencias.View = System.Windows.Forms.View.Details;
            // 
            // Número
            // 
            this.Número.Text = "Número";
            this.Número.Width = 72;
            // 
            // Descrição
            // 
            this.Descrição.Text = "Descrição";
            this.Descrição.Width = 355;
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.DisplayIndex = 3;
            this.NomeCompleto.Text = "Nome Completo";
            this.NomeCompleto.Width = 249;
            // 
            // UnidadeRes
            // 
            this.UnidadeRes.DisplayIndex = 4;
            this.UnidadeRes.Text = "Unidade Residencial";
            this.UnidadeRes.Width = 121;
            // 
            // Condição
            // 
            this.Condição.DisplayIndex = 5;
            this.Condição.Text = "Condição";
            this.Condição.Width = 82;
            // 
            // Status
            // 
            this.Status.DisplayIndex = 2;
            this.Status.Text = "Status";
            this.Status.Width = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewMinhasOcorrencias);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 211);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocorrências";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonEnviar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 220);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ocorrências";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(718, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 220);
            this.panel1.TabIndex = 29;
            // 
            // NovaOcorrenciaWindow
            // 
            this.AcceptButton = this.buttonEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(1025, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaOcorrenciaWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ocorrência";
            this.Load += new System.EventHandler(this.NovaOcorrenciaWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ListView listViewMinhasOcorrencias;
        private System.Windows.Forms.ColumnHeader Número;
        private System.Windows.Forms.ColumnHeader Descrição;
        private System.Windows.Forms.ColumnHeader NomeCompleto;
        private System.Windows.Forms.ColumnHeader UnidadeRes;
        private System.Windows.Forms.ColumnHeader Condição;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}