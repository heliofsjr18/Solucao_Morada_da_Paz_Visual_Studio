namespace Morada_da_paz_Forms.Arquivo
{
    partial class MuralWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuralWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewMinhasOcorrencias = new System.Windows.Forms.ListView();
            this.Número = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnidadeRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Condição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocorrências Públicas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.listViewMinhasOcorrencias.FullRowSelect = true;
            this.listViewMinhasOcorrencias.GridLines = true;
            this.listViewMinhasOcorrencias.Location = new System.Drawing.Point(33, 92);
            this.listViewMinhasOcorrencias.Name = "listViewMinhasOcorrencias";
            this.listViewMinhasOcorrencias.Size = new System.Drawing.Size(929, 154);
            this.listViewMinhasOcorrencias.TabIndex = 2;
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
            // Status
            // 
            this.Status.DisplayIndex = 2;
            this.Status.Text = "Status";
            this.Status.Width = 84;
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.DisplayIndex = 3;
            this.NomeCompleto.Text = "Nome Completo";
            this.NomeCompleto.Width = 211;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesquisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(603, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtro";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(606, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(757, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MuralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewMinhasOcorrencias);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MuralWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mural de Ocorrências";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewMinhasOcorrencias;
        private System.Windows.Forms.ColumnHeader Número;
        private System.Windows.Forms.ColumnHeader Descrição;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader NomeCompleto;
        private System.Windows.Forms.ColumnHeader UnidadeRes;
        private System.Windows.Forms.ColumnHeader Condição;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}