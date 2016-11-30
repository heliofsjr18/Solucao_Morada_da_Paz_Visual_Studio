namespace Morada_da_paz_Forms
{
    partial class PrincipalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarNovaOcorrênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muralDeOcorrenciasPublicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeResidencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sançãoAdministrativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewMinhasOcorrencias = new System.Windows.Forms.ListView();
            this.Número = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGeraXml = new System.Windows.Forms.Button();
            this.buttonAtulizar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarNovaOcorrênciaToolStripMenuItem,
            this.muralDeOcorrenciasPublicasToolStripMenuItem,
            this.mudarUsuárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // gerarNovaOcorrênciaToolStripMenuItem
            // 
            this.gerarNovaOcorrênciaToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Gakuseisean_Ivista_2_Files_New_File;
            this.gerarNovaOcorrênciaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gerarNovaOcorrênciaToolStripMenuItem.Name = "gerarNovaOcorrênciaToolStripMenuItem";
            this.gerarNovaOcorrênciaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.gerarNovaOcorrênciaToolStripMenuItem.Text = "Gerar Nova Ocorrência";
            this.gerarNovaOcorrênciaToolStripMenuItem.Click += new System.EventHandler(this.gerarNovaOcorrênciaToolStripMenuItem_Click);
            // 
            // muralDeOcorrenciasPublicasToolStripMenuItem
            // 
            this.muralDeOcorrenciasPublicasToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Hopstarter_Soft_Scraps_Network_Firewall;
            this.muralDeOcorrenciasPublicasToolStripMenuItem.Name = "muralDeOcorrenciasPublicasToolStripMenuItem";
            this.muralDeOcorrenciasPublicasToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.muralDeOcorrenciasPublicasToolStripMenuItem.Text = "Mural de Ocorrencias Publicas";
            this.muralDeOcorrenciasPublicasToolStripMenuItem.Click += new System.EventHandler(this.muralDeOcorrenciasPublicasToolStripMenuItem_Click);
            // 
            // mudarUsuárioToolStripMenuItem
            // 
            this.mudarUsuárioToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Paomedia_Small_N_Flat_Sign_sync;
            this.mudarUsuárioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mudarUsuárioToolStripMenuItem.Name = "mudarUsuárioToolStripMenuItem";
            this.mudarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.mudarUsuárioToolStripMenuItem.Text = "Mudar Usuário";
            this.mudarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.mudarUsuárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Graphicloads_100_Flat_Close;
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidadeResidencialToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.sançãoAdministrativaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // unidadeResidencialToolStripMenuItem
            // 
            this.unidadeResidencialToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Graphicloads_100_Flat_Home;
            this.unidadeResidencialToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unidadeResidencialToolStripMenuItem.Name = "unidadeResidencialToolStripMenuItem";
            this.unidadeResidencialToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.unidadeResidencialToolStripMenuItem.Text = "Unidade Residencial";
            this.unidadeResidencialToolStripMenuItem.Click += new System.EventHandler(this.unidadeResidencialToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Man;
            this.usuárioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // sançãoAdministrativaToolStripMenuItem
            // 
            this.sançãoAdministrativaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multaToolStripMenuItem,
            this.advertênciaToolStripMenuItem});
            this.sançãoAdministrativaToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Treetog_Junior_Folder_documents;
            this.sançãoAdministrativaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sançãoAdministrativaToolStripMenuItem.Name = "sançãoAdministrativaToolStripMenuItem";
            this.sançãoAdministrativaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sançãoAdministrativaToolStripMenuItem.Text = "Sanção Administrativa";
            // 
            // multaToolStripMenuItem
            // 
            this.multaToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Document;
            this.multaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.multaToolStripMenuItem.Name = "multaToolStripMenuItem";
            this.multaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.multaToolStripMenuItem.Text = "Multa";
            this.multaToolStripMenuItem.Click += new System.EventHandler(this.multaToolStripMenuItem_Click);
            // 
            // advertênciaToolStripMenuItem
            // 
            this.advertênciaToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Document_Write;
            this.advertênciaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.advertênciaToolStripMenuItem.Name = "advertênciaToolStripMenuItem";
            this.advertênciaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.advertênciaToolStripMenuItem.Text = "Advertência";
            this.advertênciaToolStripMenuItem.Click += new System.EventHandler(this.advertênciaToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::Morada_da_paz_Forms.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_help_about;
            this.sobreToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click_1);
            // 
            // listViewMinhasOcorrencias
            // 
            this.listViewMinhasOcorrencias.AllowColumnReorder = true;
            this.listViewMinhasOcorrencias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Número,
            this.Descrição,
            this.Status});
            this.listViewMinhasOcorrencias.FullRowSelect = true;
            this.listViewMinhasOcorrencias.GridLines = true;
            this.listViewMinhasOcorrencias.Location = new System.Drawing.Point(28, 205);
            this.listViewMinhasOcorrencias.Name = "listViewMinhasOcorrencias";
            this.listViewMinhasOcorrencias.Size = new System.Drawing.Size(597, 131);
            this.listViewMinhasOcorrencias.TabIndex = 1;
            this.listViewMinhasOcorrencias.UseCompatibleStateImageBehavior = false;
            this.listViewMinhasOcorrencias.View = System.Windows.Forms.View.Details;
            this.listViewMinhasOcorrencias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMinhasOcorrencias_MouseDoubleClick);
            // 
            // Número
            // 
            this.Número.Text = "Número";
            this.Número.Width = 72;
            // 
            // Descrição
            // 
            this.Descrição.Text = "Descrição";
            this.Descrição.Width = 440;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minhas Ocorrências";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atualizar Ocorrências";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gerar XML";
            // 
            // buttonGeraXml
            // 
            this.buttonGeraXml.Image = ((System.Drawing.Image)(resources.GetObject("buttonGeraXml.Image")));
            this.buttonGeraXml.Location = new System.Drawing.Point(525, 151);
            this.buttonGeraXml.Name = "buttonGeraXml";
            this.buttonGeraXml.Size = new System.Drawing.Size(75, 41);
            this.buttonGeraXml.TabIndex = 5;
            this.buttonGeraXml.UseVisualStyleBackColor = true;
            this.buttonGeraXml.Click += new System.EventHandler(this.buttonGeraXml_Click);
            // 
            // buttonAtulizar
            // 
            this.buttonAtulizar.Image = global::Morada_da_paz_Forms.Properties.Resources.Paomedia_Small_N_Flat_Sign_sync;
            this.buttonAtulizar.Location = new System.Drawing.Point(410, 151);
            this.buttonAtulizar.Name = "buttonAtulizar";
            this.buttonAtulizar.Size = new System.Drawing.Size(75, 42);
            this.buttonAtulizar.TabIndex = 4;
            this.buttonAtulizar.UseVisualStyleBackColor = true;
            this.buttonAtulizar.Click += new System.EventHandler(this.buttonAtulizar_Click);
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(656, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGeraXml);
            this.Controls.Add(this.buttonAtulizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMinhasOcorrencias);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalWindow_FormClosing);
            this.Load += new System.EventHandler(this.PrincipalWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarNovaOcorrênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeResidencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sançãoAdministrativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advertênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ListView listViewMinhasOcorrencias;
        private System.Windows.Forms.ColumnHeader Número;
        private System.Windows.Forms.ColumnHeader Descrição;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ToolStripMenuItem muralDeOcorrenciasPublicasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAtulizar;
        private System.Windows.Forms.Button buttonGeraXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem mudarUsuárioToolStripMenuItem;
    }
}

