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

namespace View.Telas_de_Cadastro
{
    public partial class CadastroClientesBanco : Form
    {
        public CadastroClientesBanco()
        {
            InitializeComponent();
        }


        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456");

                strSQL = "INSERT INTO CONTAS (CONTA , AGÊNCIA, CLIENTE) VALUES (@CONTA, @AGÊNCIA, @CLIENTE)";

                comando = new SqlCommand(strSQL , conexao);

                comando.Parameters.AddWithValue("@AGÊNCIA", txtAgencia.Text);
                comando.Parameters.AddWithValue("@CONTA" , txtConta.Text);
                comando.Parameters.AddWithValue("@CLIENTE", txtCliente.Text);


                conexao.Open(); 

                comando.ExecuteNonQuery();

                MessageBox.Show("CONTA CRIADA COM SUCESSO!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void CadastroClientesBanco_Load(object sender, EventArgs e)
        {

        }
    }
}
