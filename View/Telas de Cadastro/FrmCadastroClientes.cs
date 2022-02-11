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
    public partial class FrmCadastroClientes : Form
    {

        public FrmCadastroClientes()
        {
            InitializeComponent();
            GroupBox1.Enabled = false;
            GroupBox2.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

        }

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;


        private void guna2Button10_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                strSQL = "SELECT * FROM CADASTROCLIENTE";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);
                //abre a conexao
                conexao.Open();
                da.Fill(ds);
                //Seta o DataGridView da interface, tranformando em tabela, 
                //e jogando as informaçoes da tabela dentro.
                dataGridView1.DataSource = ds.Tables[0];
                GroupBox1.Enabled = true;

            } catch (Exception ex) {

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                strSQL = "INSERT INTO CADASTROCLIENTE(NOME , ENDERECO , CIDADE , EMAIL , TELEFONE , SEXO , UF , CEP) VALUES(@NOME, @ENDERECO, @CIDADE, @EMAIL, @TELEFONE, @SEXO, @UF, @CEP)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@UF", comboUF.Text);
                comando.Parameters.AddWithValue("@CEP", txtCEP.Text);


                if (radioMasculino.Checked == true)
                {
                    comando.Parameters.AddWithValue("@SEXO", radioMasculino.Text);
                }
                else
                {
                    comando.Parameters.AddWithValue("@SEXO", radioFeminino.Text);
                }

                MessageBox.Show("Inserido com sucesso!");

                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                LimparControles();
                conexao.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }







        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {


                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                strSQL = "SELECT * FROM CADASTROCLIENTE WHERE NOME = @NOME";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", txtPesquisar.Text);
                
                //abre a conexao
                conexao.Open();

                //instancia o datareader
                dr = comando.ExecuteReader();


                //faz o loop para varrer os campos para trazer as informaçoes da tabela
                while (dr.Read())
                {
                    txtNome.Text = (string)dr["nome"];

                    txtEndereco.Text = (string)dr["endereco"];

                    txtCidade.Text = (string)dr["cidade"];

                    txtEmail.Text = (string)dr["email"];

                    txtTelefone.Text = Convert.ToString(dr["telefone"]);

                    comboUF.Text = Convert.ToString(dr["uf"]);

                    txtCEP.Text = Convert.ToString(dr["cep"]);
                }
                GroupBox1.Enabled = true;
                GroupBox2.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            txtPesquisar.Enabled = false;
            btnTodos.Enabled = false;
            GroupBox1.Enabled = true;
            GroupBox2.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            LimparControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //Vai alterar o valor anterior para o que o usuario digitar
                strSQL = "UPDATE CADASTROCLIENTE SET ENDERECO = @ENDERECO, CIDADE = @CIDADE, EMAIL = @EMAIL, TELEFONE = @TELEFONE, UF = @UF, CEP = @CEP WHERE NOME = @NOME";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPOS DA TABELA COM OS TEXTBOX DA INTERFACE

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@UF", comboUF.Text);
                comando.Parameters.AddWithValue("@CEP", txtCEP.Text);


                if (radioMasculino.Checked == true)
                {
                    comando.Parameters.AddWithValue("@SEXO", radioMasculino.Text);
                }
                else
                {
                    comando.Parameters.AddWithValue("@SEXO", radioFeminino.Text);
                }
                LimparControles();

                //ABRINDO CONEXAO
                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso!");
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

            btnNovo.Enabled = true;
            txtPesquisar.Enabled = true;
            btnTodos.Enabled = true;
            GroupBox1.Enabled = false;
            GroupBox2.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }


        public void LimparControles()
        {
            this.LimparControles(this);
        }

        public void LimparControles(Control parent)
        {
            foreach (Control cont in parent.Controls)
            {
                if (cont is TextBox)
                    (cont as TextBox).Text = "";
                if (cont is ComboBox)
                    (cont as ComboBox).Text = "";
                if (cont is MaskedTextBox)
                    (cont as MaskedTextBox).Text = "";
                if (cont is RadioButton)
                    (cont as RadioButton).Checked = false;
                if (cont is CheckedListBox)
                {
                    foreach (ListControl item in (cont as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
                if (cont is ListView)
                    (cont as ListView).Items.Clear();

                // varre os filhos...
                this.LimparControles(cont);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            txtPesquisar.Enabled = true;
            btnTodos.Enabled = true;
            GroupBox1.Enabled = false;
            GroupBox2.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //Excluindo DADOS no banco de dados na tabela CAD_CLIENTE
                strSQL = "DELETE CADASTROCLIENTE WHERE NOME = @NOME";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPO ID DA TABELA COM O TEXTBOX ID DA INTERFASE

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                btnNovo.Enabled = true;
                txtPesquisar.Enabled = true;
                btnTodos.Enabled = true;
                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                LimparControles();


                //ABRINDO CONEXAO
                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Excluido com Sucesso!");
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}


