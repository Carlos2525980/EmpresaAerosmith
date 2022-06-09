using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Telas_de_Cadastro
{
    public partial class FrmCadastroprodutosCelinhaloja : Form
    {
        public FrmCadastroprodutosCelinhaloja()
        {
            InitializeComponent();
            txtcodProduto.Enabled = false;
            carregar();
           

        }

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        String strSQL;

        private void guna2Button2_Click(object sender, EventArgs e)
        {



            if (txtNomeProduto.Text == "" || txtQuantidade.Text == "" || txtPrecoDoProduto.Text == "")
            {
                MessageBox.Show("Campos são obrigatórios");
            }
            else
            {
                if (txtDesconto.Text != "")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");
                        strSQL = "INSERT INTO CELINHALOJA (NOMEDOPRODUTO, QUANTIDADE, PRECODOPRODUTO, DESCONTO) VALUES (@NOMEDOPRODUTO, @QUANTIDADE, @PRECODOPRODUTO, @DESCONTO)";
                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@NOMEDOPRODUTO", txtNomeProduto.Text);
                        comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                        comando.Parameters.AddWithValue("@PRECODOPRODUTO", txtPrecoDoProduto.Text);
                        comando.Parameters.AddWithValue("@DESCONTO", txtDesconto.Text);



                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("INSERIDO COM SUCESSO!!");
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
                else
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");
                        strSQL = "INSERT INTO CELINHALOJA (NOMEDOPRODUTO, QUANTIDADE, PRECODOPRODUTO) VALUES (@NOMEDOPRODUTO, @QUANTIDADE, @PRECODOPRODUTO)";
                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@NOMEDOPRODUTO", txtNomeProduto.Text);
                        comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                        comando.Parameters.AddWithValue("@PRECODOPRODUTO", txtPrecoDoProduto.Text);

                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("INSERIDO COM SUCESSO!!");
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
              
            }
}
        private void txtCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //vai mostrar todas as informações da tabela CAD_CLIENTE
                strSQL = "SELECT * FROM  CELINHALOJA";

                //Instancia uma tabela a ser preenchida
                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);


                //abre a conexao
                conexao.Open();
                da.Fill(ds);

                //Seta o DataGridView da interface, tranformando em tabela, 
                //e jogando as informaçoes da tabela dentro.

                dataGridView1.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {

                // SE DER ALGUM ERRO ESSA MENSAGEM DE ERRO SERÁ ATIVADA.
                MessageBox.Show(ex.Message);


            }
            finally
            {

                //FECHANDO A CONEXAO
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void FrmCadastroprodutosCelinhaloja_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
        }

        //atualizar tabela
        public void carregar()
        {

            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //vai mostrar todas as informações da tabela CAD_CLIENTE
                strSQL = "SELECT * FROM  CELINHALOJA";

                //Instancia uma tabela a ser preenchida
                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);


                //abre a conexao
                conexao.Open();
                da.Fill(ds);

                //Seta o DataGridView da interface, tranformando em tabela, 
                //e jogando as informaçoes da tabela dentro.

                dataGridView1.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {

                // SE DER ALGUM ERRO ESSA MENSAGEM DE ERRO SERÁ ATIVADA.
                MessageBox.Show(ex.Message);


            }
            finally
            {

                //FECHANDO A CONEXAO
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

            if (txtPrecoDoProduto.Text == "")
            {

                MessageBox.Show("Digite o preço para realizar o Desconto!");

            }
            else
            {
                  
                    var preco = Convert.ToDecimal(txtPrecoDoProduto.Text);
                    var desconto = Convert.ToDecimal(txtDesconto.Text);
                    decimal resultado;



                    resultado = preco - desconto;

                    txtTotal.Text = resultado.ToString();
                   txtPrecoDoProduto.Text = txtTotal.Text;
            }
              
        }
        private void txtPrecoDoProduto_TextChanged(object sender, EventArgs e)
        {
            txtSubtotal.Text = txtPrecoDoProduto.Text;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == "" && txtQuantidade.Text == "" && txtPrecoDoProduto.Text =="")
            {
                MessageBox.Show("Não existe dados para limpar");
            }
            else
            {
                txtNomeProduto.Clear();
                txtQuantidade.Clear();
                txtPrecoDoProduto.Clear();
            }
          
        }
        private void txtPrecoDoProduto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e PONTO");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        private void txtPrecoDoProduto_TextChanged_1(object sender, EventArgs e)
        {
            txtSubtotal.Text = txtPrecoDoProduto.Text;
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            txtPrecoDoProduto.Text = txtSubtotal.Text;
        }

        private void txtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e PONTO");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e PONTO");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        private void txtNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
                {
                    e.Handled = true;

                    e = null;
                   MessageBox.Show("este campo aceita somente letras");

                }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {


                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                strSQL = "SELECT * FROM CELINHALOJA WHERE NOMEDOPRODUTO = @NOMEDOPRODUTO";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOMEDOPRODUTO", txtNomeProduto.Text);

                //abre a conexao
                conexao.Open();

                //instancia o datareader
                dr = comando.ExecuteReader();


                //faz o loop para varrer os campos para trazer as informaçoes da tabela
                while (dr.Read())
                {
                  

                    txtNomeProduto.Text = (string)dr["nomedoproduto"];

                    txtQuantidade.Text = Convert.ToString(dr["quantidade"]);

                    txtPrecoDoProduto.Text = (string)dr["precodoproduto"];

                    txtDesconto.Text = Convert.ToString(dr["desconto"]);



                }
               

                MessageBox.Show("Pesquisa realizada com Sucesso!");

            }
            catch (Exception ex)
            {

                // SE DER ALGUM ERRO ESSA MENSAGEM DE ERRO SERÁ ATIVADA.
                MessageBox.Show(ex.Message);


            }
            finally
            {

                //FECHANDO A CONEXAO
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }
    }
    
}
    


