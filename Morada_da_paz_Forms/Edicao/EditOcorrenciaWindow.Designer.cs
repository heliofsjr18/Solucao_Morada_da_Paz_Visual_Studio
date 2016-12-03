namespace Morada_da_paz_Forms.Edicao
{
    partial class EditOcorrenciaWindow
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAdvertencia = new System.Windows.Forms.ComboBox();
            this.checkBoxAdvertencia = new System.Windows.Forms.CheckBox();
            this.comboBoxMulta = new System.Windows.Forms.ComboBox();
            this.checkBoxMulta = new System.Windows.Forms.CheckBox();
            this.listViewMinhasOcorrencias = new System.Windows.Forms.ListView();
            this.Número = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnidadeRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Condição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = global::Morada_da_paz_Forms.Properties.Resources.Hopstarter_Button_Button_Close;
            this.buttonCancelar.Location = new System.Drawing.Point(755, 255);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 54);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Image = global::Morada_da_paz_Forms.Properties.Resources.Gakuseisean_Ivista_2_Alarm_Tick;
            this.buttonSalvar.Location = new System.Drawing.Point(851, 255);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 54);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ocorrência";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAdvertencia);
            this.groupBox1.Controls.Add(this.checkBoxAdvertencia);
            this.groupBox1.Controls.Add(this.comboBoxMulta);
            this.groupBox1.Controls.Add(this.checkBoxMulta);
            this.groupBox1.Location = new System.Drawing.Point(38, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 145);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sanção Administrativa";
            // 
            // comboBoxAdvertencia
            // 
            this.comboBoxAdvertencia.FormattingEnabled = true;
            this.comboBoxAdvertencia.Location = new System.Drawing.Point(6, 112);
            this.comboBoxAdvertencia.Name = "comboBoxAdvertencia";
            this.comboBoxAdvertencia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdvertencia.TabIndex = 3;
            // 
            // checkBoxAdvertencia
            // 
            this.checkBoxAdvertencia.AutoSize = true;
            this.checkBoxAdvertencia.Location = new System.Drawing.Point(6, 89);
            this.checkBoxAdvertencia.Name = "checkBoxAdvertencia";
            this.checkBoxAdvertencia.Size = new System.Drawing.Size(83, 17);
            this.checkBoxAdvertencia.TabIndex = 2;
            this.checkBoxAdvertencia.Text = "Advertência";
            this.checkBoxAdvertencia.UseVisualStyleBackColor = true;
            // 
            // comboBoxMulta
            // 
            this.comboBoxMulta.FormattingEnabled = true;
            this.comboBoxMulta.Location = new System.Drawing.Point(6, 46);
            this.comboBoxMulta.Name = "comboBoxMulta";
            this.comboBoxMulta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMulta.TabIndex = 1;
            // 
            // checkBoxMulta
            // 
            this.checkBoxMulta.AutoSize = true;
            this.checkBoxMulta.Location = new System.Drawing.Point(6, 23);
            this.checkBoxMulta.Name = "checkBoxMulta";
            this.checkBoxMulta.Size = new System.Drawing.Size(52, 17);
            this.checkBoxMulta.TabIndex = 0;
            this.checkBoxMulta.Text = "Multa";
            this.checkBoxMulta.UseVisualStyleBackColor = true;
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
            this.listViewMinhasOcorrencias.Location = new System.Drawing.Point(32, 62);
            this.listViewMinhasOcorrencias.Name = "listViewMinhasOcorrencias";
            this.listViewMinhasOcorrencias.Size = new System.Drawing.Size(1010, 163);
            this.listViewMinhasOcorrencias.TabIndex = 16;
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
            // Status
            // 
            this.Status.DisplayIndex = 2;
            this.Status.Text = "Status";
            this.Status.Width = 84;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(32, 434);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1010, 163);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Multa";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.Width = 355;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Advertência";
            this.columnHeader3.Width = 211;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "Unidade Residencial";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 4;
            this.columnHeader7.Text = "Número";
            // 
            // EditOcorrenciaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listViewMinhasOcorrencias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditOcorrenciaWindow";
            this.Text = "EditOcorrenciaWindow";
            this.Load += new System.EventHandler(this.EditOcorrenciaWindow_Load);
            this.Shown += new System.EventHandler(this.EditOcorrenciaWindow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxAdvertencia;
        private System.Windows.Forms.CheckBox checkBoxAdvertencia;
        private System.Windows.Forms.ComboBox comboBoxMulta;
        private System.Windows.Forms.CheckBox checkBoxMulta;
        private System.Windows.Forms.ListView listViewMinhasOcorrencias;
        private System.Windows.Forms.ColumnHeader Número;
        private System.Windows.Forms.ColumnHeader Descrição;
        private System.Windows.Forms.ColumnHeader NomeCompleto;
        private System.Windows.Forms.ColumnHeader UnidadeRes;
        private System.Windows.Forms.ColumnHeader Condição;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}