﻿namespace Morada_da_paz_Forms.Edicao
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
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.checkBoxOcorrenciaPublica = new System.Windows.Forms.CheckBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUnd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAdvertencia = new System.Windows.Forms.ComboBox();
            this.checkBoxAdvertencia = new System.Windows.Forms.CheckBox();
            this.comboBoxMulta = new System.Windows.Forms.ComboBox();
            this.checkBoxMulta = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = global::Morada_da_paz_Forms.Properties.Resources.Hopstarter_Button_Button_Close;
            this.buttonCancelar.Location = new System.Drawing.Point(189, 293);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 54);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Image = global::Morada_da_paz_Forms.Properties.Resources.Gakuseisean_Ivista_2_Alarm_Tick;
            this.buttonSalvar.Location = new System.Drawing.Point(48, 293);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 54);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Enabled = false;
            this.richTextBoxDescricao.Location = new System.Drawing.Point(26, 111);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(423, 153);
            this.richTextBoxDescricao.TabIndex = 2;
            this.richTextBoxDescricao.Text = "";
            // 
            // checkBoxOcorrenciaPublica
            // 
            this.checkBoxOcorrenciaPublica.AutoSize = true;
            this.checkBoxOcorrenciaPublica.Location = new System.Drawing.Point(334, 270);
            this.checkBoxOcorrenciaPublica.Name = "checkBoxOcorrenciaPublica";
            this.checkBoxOcorrenciaPublica.Size = new System.Drawing.Size(115, 17);
            this.checkBoxOcorrenciaPublica.TabIndex = 6;
            this.checkBoxOcorrenciaPublica.Text = "Ocorrência publica";
            this.checkBoxOcorrenciaPublica.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Em Análise",
            "Finalizada",
            "Cancelada"});
            this.comboBoxStatus.Location = new System.Drawing.Point(313, 85);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ocorrência";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Enabled = false;
            this.textBoxNumero.Location = new System.Drawing.Point(189, 86);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nº";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status";
            // 
            // comboBoxUnd
            // 
            this.comboBoxUnd.FormattingEnabled = true;
            this.comboBoxUnd.Location = new System.Drawing.Point(43, 84);
            this.comboBoxUnd.Name = "comboBoxUnd";
            this.comboBoxUnd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUnd.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Und. Residencial";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAdvertencia);
            this.groupBox1.Controls.Add(this.checkBoxAdvertencia);
            this.groupBox1.Controls.Add(this.comboBoxMulta);
            this.groupBox1.Controls.Add(this.checkBoxMulta);
            this.groupBox1.Location = new System.Drawing.Point(473, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 253);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sanção Administrativa";
            // 
            // comboBoxAdvertencia
            // 
            this.comboBoxAdvertencia.FormattingEnabled = true;
            this.comboBoxAdvertencia.Location = new System.Drawing.Point(51, 151);
            this.comboBoxAdvertencia.Name = "comboBoxAdvertencia";
            this.comboBoxAdvertencia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdvertencia.TabIndex = 3;
            // 
            // checkBoxAdvertencia
            // 
            this.checkBoxAdvertencia.AutoSize = true;
            this.checkBoxAdvertencia.Location = new System.Drawing.Point(51, 128);
            this.checkBoxAdvertencia.Name = "checkBoxAdvertencia";
            this.checkBoxAdvertencia.Size = new System.Drawing.Size(83, 17);
            this.checkBoxAdvertencia.TabIndex = 2;
            this.checkBoxAdvertencia.Text = "Advertência";
            this.checkBoxAdvertencia.UseVisualStyleBackColor = true;
            // 
            // comboBoxMulta
            // 
            this.comboBoxMulta.FormattingEnabled = true;
            this.comboBoxMulta.Location = new System.Drawing.Point(51, 85);
            this.comboBoxMulta.Name = "comboBoxMulta";
            this.comboBoxMulta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMulta.TabIndex = 1;
            // 
            // checkBoxMulta
            // 
            this.checkBoxMulta.AutoSize = true;
            this.checkBoxMulta.Location = new System.Drawing.Point(51, 62);
            this.checkBoxMulta.Name = "checkBoxMulta";
            this.checkBoxMulta.Size = new System.Drawing.Size(52, 17);
            this.checkBoxMulta.TabIndex = 0;
            this.checkBoxMulta.Text = "Multa";
            this.checkBoxMulta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(319, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditOcorrenciaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(734, 359);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxUnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.checkBoxOcorrenciaPublica);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditOcorrenciaWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.CheckBox checkBoxOcorrenciaPublica;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxAdvertencia;
        private System.Windows.Forms.CheckBox checkBoxAdvertencia;
        private System.Windows.Forms.ComboBox comboBoxMulta;
        private System.Windows.Forms.CheckBox checkBoxMulta;
        private System.Windows.Forms.Button button1;
    }
}