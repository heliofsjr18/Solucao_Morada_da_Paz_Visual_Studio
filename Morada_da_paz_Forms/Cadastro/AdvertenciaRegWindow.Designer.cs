namespace Morada_da_paz_Forms.Cadastro
{
    partial class AdvertenciaRegWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxAdvertencia = new System.Windows.Forms.RichTextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Nova Advertencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a Advertencia aqui";
            // 
            // richTextBoxAdvertencia
            // 
            this.richTextBoxAdvertencia.Location = new System.Drawing.Point(89, 338);
            this.richTextBoxAdvertencia.Name = "richTextBoxAdvertencia";
            this.richTextBoxAdvertencia.Size = new System.Drawing.Size(795, 96);
            this.richTextBoxAdvertencia.TabIndex = 2;
            this.richTextBoxAdvertencia.Text = "";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Image = global::Morada_da_paz_Forms.Properties.Resources.Hopstarter_Button_Button_Close;
            this.buttonCancelar.Location = new System.Drawing.Point(225, 445);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(102, 55);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Image = global::Morada_da_paz_Forms.Properties.Resources.Gakuseisean_Ivista_2_Alarm_Tick;
            this.buttonSalvar.Location = new System.Drawing.Point(89, 445);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(102, 55);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Multas Cadastradas";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descrição";
            this.columnHeader1.Width = 863;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(38, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(877, 198);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // AdvertenciaRegWindow
            // 
            this.AcceptButton = this.buttonSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(959, 513);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.richTextBoxAdvertencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdvertenciaRegWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdvertenciaRegWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxAdvertencia;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
    }
}