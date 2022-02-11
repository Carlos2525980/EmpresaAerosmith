using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Telas_de_Cadastro;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeAssociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmCadastroAssociados cadastro = new FrmCadastroAssociados();
            cadastro.Show();
           
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void cadastroJardimBotânicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroJardimBotanico jardim = new FrmCadastroJardimBotanico();

            jardim.Show();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar aplicação?", "SAIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
                
            }
            else 
            {
                e.Cancel = true;
            }
        }

        private void cadastroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes cadastro = new FrmCadastroClientes();
            cadastro.Show();
        }
    }
}
