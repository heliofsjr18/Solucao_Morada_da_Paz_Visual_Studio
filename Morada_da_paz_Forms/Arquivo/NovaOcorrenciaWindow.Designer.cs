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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 295);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 153);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a sua ocorrência aqui, e clique em enviar ocorrência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gerar Nova Ocorrência";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEnviar.Image = global::Morada_da_paz_Forms.Properties.Resources.Custom_Icon_Design_Flatastic_10_Email_send;
            this.buttonEnviar.Location = new System.Drawing.Point(52, 492);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(135, 41);
            this.buttonEnviar.TabIndex = 2;
            this.buttonEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Image = global::Morada_da_paz_Forms.Properties.Resources.Hopstarter_Button_Button_Close;
            this.buttonCancelar.Location = new System.Drawing.Point(261, 492);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(124, 41);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(342, 454);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Ocorrência publica";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Multas Cadastradas";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(34, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(864, 198);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome Completo";
            this.columnHeader1.Width = 302;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 261;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "U.R";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Condição";
            this.columnHeader4.Width = 224;
            // 
            // NovaOcorrenciaWindow
            // 
            this.AcceptButton = this.buttonEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(1025, 549);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaOcorrenciaWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerar Nova Ocorrencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}