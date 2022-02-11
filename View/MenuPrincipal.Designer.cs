namespace View
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAssociadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroJardimBotânicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.controllersToolStripMenuItem,
            this.utilitáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAssociadosToolStripMenuItem,
            this.cadastroJardimBotânicoToolStripMenuItem,
            this.cadastroClientesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cadastrosToolStripMenuItem.Text = "1 - Cadastros";
            // 
            // cadastroDeAssociadosToolStripMenuItem
            // 
            this.cadastroDeAssociadosToolStripMenuItem.Name = "cadastroDeAssociadosToolStripMenuItem";
            this.cadastroDeAssociadosToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.cadastroDeAssociadosToolStripMenuItem.Text = "1 - Cadastro de Associados";
            this.cadastroDeAssociadosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAssociadosToolStripMenuItem_Click);
            // 
            // cadastroJardimBotânicoToolStripMenuItem
            // 
            this.cadastroJardimBotânicoToolStripMenuItem.Name = "cadastroJardimBotânicoToolStripMenuItem";
            this.cadastroJardimBotânicoToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.cadastroJardimBotânicoToolStripMenuItem.Text = "2 - Cadastro Jardim Botânico";
            this.cadastroJardimBotânicoToolStripMenuItem.Click += new System.EventHandler(this.cadastroJardimBotânicoToolStripMenuItem_Click);
            // 
            // controllersToolStripMenuItem
            // 
            this.controllersToolStripMenuItem.Name = "controllersToolStripMenuItem";
            this.controllersToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.controllersToolStripMenuItem.Text = "2 - Controllers";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.utilitáriosToolStripMenuItem.Text = "3 - Utilitários ";
            // 
            // cadastroClientesToolStripMenuItem
            // 
            this.cadastroClientesToolStripMenuItem.Name = "cadastroClientesToolStripMenuItem";
            this.cadastroClientesToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.cadastroClientesToolStripMenuItem.Text = "3 - Cadastro Clientes";
            this.cadastroClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroClientesToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAssociadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroJardimBotânicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controllersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClientesToolStripMenuItem;
    }
}