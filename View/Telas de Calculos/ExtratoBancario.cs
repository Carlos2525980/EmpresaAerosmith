using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Telas_de_Calculos
{
    public partial class FrmExtratoBancario : Form
    {
        public FrmExtratoBancario()
        {
            InitializeComponent();
        }

        private void FrmExtratoBancario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDepoistos deposito = new FrmDepoistos();
            deposito.Show();
        }
    }
}
