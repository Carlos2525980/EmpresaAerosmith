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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAssociadosToolStripMenuItem,
            this.cadastroJardimBotânicoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cadastrosToolStripMenuItem.Text = "1 - Cadastros";
            // 
            // cadastroDeAssociadosToolStripMenuItem
            // 
            this.cadastroDeAssociadosToolStripMenuItem.Name = "cadastroDeAssociadosToolStripMenuItem";
            this.cadastroDeAssociadosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDeAssociadosToolStripMenuItem.Text = "1 - Cadastro de Associados";
            this.cadastroDeAssociadosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAssociadosToolStripMenuItem_Click);
            // 
            // cadastroJardimBotânicoToolStripMenuItem
            // 
            this.cadastroJardimBotânicoToolStripMenuItem.Name = "cadastroJardimBotânicoToolStripMenuItem";
            this.cadastroJardimBotânicoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroJardimBotânicoToolStripMenuItem.Text = "2 - Cadastro Jardim Botânico";
            this.cadastroJardimBotânicoToolStripMenuItem.Click += new System.EventHandler(this.cadastroJardimBotânicoToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}