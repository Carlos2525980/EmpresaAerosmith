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
    public partial class Financas : Form
    {
        public Financas()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClientesBanco cadastro = new CadastroClientesBanco();
            cadastro.Show();
        }
    }
}
