using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Telas_de_Calculos
{
    public partial class FrmDepoistos : Form
    {
        public FrmDepoistos()
        {
            InitializeComponent();
        }
        SqlConnection conexao;
        SqlCommand comando;
        string strSQL;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
          FrmExtratoBancario extrato = new FrmExtratoBancario();
            extrato.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {

            if (radioDinheiro.Checked == false && radioCheque.Checked == false && radioPix.Checked == false)
            {
                MessageBox.Show("Informe o tipo de depósito que será feito! Dinheiro, Cheque ou Cartão");

                if (radioDinheiro.Checked == true)
                {

                }
                else if (radioCheque.Checked == true)
                {

                }
                else if (radioPix.Checked == true)
                {
                }
            }
            CamposDepositosVazios();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (radioDinheiro.Checked == false && radioCheque.Checked == false && radioPix.Checked == false)
            {
                MessageBox.Show("Informe o tipo de saque que será feito!  Dinheiro, Cheque ou Cartão");


                if (radioDinheiro.Checked == true)
                {

                }
                else if (radioCheque.Checked == true)
                {

                }
                else if (radioPix.Checked == true)
                {

                }

            }
            CamposSaqueVazios();
        }
        public void CamposDepositosVazios()
        {
            if (txtDataDeposito.Text == "") 
            {
                MessageBox.Show("Digite Data de Depósito!");
            }
            else if(txtValorDeposito.Text == "")
            {
                MessageBox.Show("Digite o Valor de Depósito!");
            }

            else
            {
                MessageBox.Show("Digite a descrição do depósito!");
            }
        }

        public void CamposSaqueVazios()
        {
            if (txtDataSaque.Text == "")
            {
                MessageBox.Show("Digite Data de Saque!");
            }
            else if (txtValorSaque.Text == "")
            {
                MessageBox.Show("Digite o Valor de Saque!");
            }

            else
            {
                MessageBox.Show("Digite a descrição do Saque!");
            }
        }

        private void FrmDepoistos_Load(object sender, EventArgs e)
        {
        }
    }
}
