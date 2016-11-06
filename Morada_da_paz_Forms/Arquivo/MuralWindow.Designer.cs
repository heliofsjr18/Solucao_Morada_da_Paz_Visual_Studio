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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocorrências Públicas";
            // 
            // listViewMinhasOcorrencias
            // 
            this.listViewMinhasOcorrencias.AllowColumnReorder = true;
            this.listViewMinhasOcorrencias.CheckBoxes = true;
            this.listViewMinhasOcorrencias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Número,
            this.Descrição,
            this.Status});
            this.listViewMinhasOcorrencias.FullRowSelect = true;
            this.listViewMinhasOcorrencias.GridLines = true;
            this.listViewMinhasOcorrencias.Location = new System.Drawing.Point(12, 99);
            this.listViewMinhasOcorrencias.Name = "listViewMinhasOcorrencias";
            this.listViewMinhasOcorrencias.Size = new System.Drawing.Size(597, 131);
            this.listViewMinhasOcorrencias.TabIndex = 2;
            this.listViewMinhasOcorrencias.UseCompatibleStateImageBehavior = false;
            this.listViewMinhasOcorrencias.View = System.Windows.Forms.View.Details;
            // 
            // Número
            // 
            this.Número.Text = "Número";
            // 
            // Descrição
            // 
            this.Descrição.Text = "Descrição";
            this.Descrição.Width = 473;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Image = global::Morada_da_paz_Forms.Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_system_software_update;
            this.buttonUpdate.Location = new System.Drawing.Point(513, 52);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 41);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Atualizar";
            // 
            // MuralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdate);
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
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label2;
    }
}