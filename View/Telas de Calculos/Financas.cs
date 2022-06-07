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

namespace View.Telas_de_Calculos
{
    public partial class FrmFinancas : Form
    {
        public FrmFinancas()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClientesBanco cadastro = new CadastroClientesBanco();
            cadastro.Show();
        }

        private void depositosESaquesToolStripMenuItem_Click(object sender, EventArgs e)
        {                       

            FrmDepoistos deposito = new FrmDepoistos();
            deposito.Show();
        }

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLancamentos_Saldos_e_Extratos lancamentos = new FrmLancamentos_Saldos_e_Extratos();
            lancamentos.Show();
        }
    }
}
