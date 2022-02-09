using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing.Bitmap;


namespace View.Telas_de_Cadastro
{
    public partial class CadastroJardimBotanico : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;
        public CadastroJardimBotanico()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                //inserindo DADOS no banco de dados na tabela CAD_CLIENTE
                strSQL = "INSERT INTO CADASTROJARDIMBOTANICO(CONTRATO_N, ALUNO, DATA_NASCIMENTO, CPF, CURSO, ANO, TURNO ) VALUES (@CONTRATO_N, @ALUNO, @DATA_NASCIMENTO, @CPF, @CURSO, @ANO, @TURNO)";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPOS DA TABELA COM OS TEXTBOX DA INTERFACE

                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CONTRATO_N", txtContrato.Text);
                comando.Parameters.AddWithValue("@ALUNO", txtNome.Text);
                comando.Parameters.AddWithValue("@DATA_NASCIMENTO", txtNascimento.Text);
                comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                comando.Parameters.AddWithValue("@CURSO", txtCurso.Text);
                comando.Parameters.AddWithValue("@ANO", txtAno.Text);
                comando.Parameters.AddWithValue("@TURNO", txtTurno.Text);

                //ABRINDO CONEXAO
                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Inserido com sucesso!");
            }
            catch (Exception ex) {
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

        private void txtCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //vai mostrar todas as informações da tabela CAD_CLIENTE
                strSQL = "SELECT * FROM CADASTROJARDIMBOTANICO";

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

        private void guna2Button6_Click(object sender, EventArgs e)
        {


            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //Faz um consulta pelo nome do aluno
                strSQL = "SELECT * FROM CADASTROJARDIMBOTANICO WHERE ALUNO = @ALUNO";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPO ID da interface com o campo id do banco de dados

                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ALUNO", txtBuscaAluno.Text);

                //abre a conexao
                conexao.Open();

                //instancia o datareader
                dr = comando.ExecuteReader();


                //faz o loop para varrer os campos para trazer as informaçoes da tabela
                while (dr.Read())
                {
                    txtContrato.Text = Convert.ToString(dr["contrato_n"]);
                    txtNome.Text = (string)dr["aluno"];
                    txtNascimento.Text = Convert.ToString(dr["data_nascimento"]);
                    txtCPF.Text = (string)dr["cpf"];
                    txtCurso.Text = (string)dr["curso"];
                    txtAno.Text = Convert.ToString(dr["ano"]);
                    txtTurno.Text = (string)dr["turno"];
                }

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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //Faz um consulta pelo cpf
                strSQL = "SELECT * FROM CADASTROJARDIMBOTANICO WHERE CPF = @CPF";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPO ID da interface com o campo id do banco de dados

                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CPF", txtBuscaCPF.Text);

                //abre a conexao
                conexao.Open();

                //instancia o datareader
                dr = comando.ExecuteReader();


                //faz o loop para varrer os campos para trazer as informaçoes da tabela
                while (dr.Read())
                {

                    txtContrato.Text = Convert.ToString(dr["contrato_n"]);
                    txtNome.Text = (string)dr["aluno"];
                    txtNascimento.Text = Convert.ToString(dr["data_nascimento"]);
                    txtCPF.Text = Convert.ToString(dr["cpf"]);
                    txtCurso.Text = (string)dr["curso"];
                    txtAno.Text = Convert.ToString(dr["ano"]);
                    txtTurno.Text = (string)dr["turno"];
                }

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

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {

                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                strSQL = "SELECT * FROM CADASTROJARDIMBOTANICO WHERE CONTRATO_N = @CONTRATO_N";

                //Faz um consulta pelo cpf


                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPO ID da interface com o campo id do banco de dados


                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CONTRATO_N", txtBuscaContrato.Text);

                //abre a conexao
                conexao.Open();

                //instancia o datareader
                dr = comando.ExecuteReader();


                //faz o loop para varrer os campos para trazer as informaçoes da tabela
                while (dr.Read())
                {

                    txtContrato.Text = Convert.ToString(dr["contrato_n"]);
                    txtNome.Text = (string)dr["aluno"];
                    txtNascimento.Text = Convert.ToString(dr["data_nascimento"]);
                    txtCPF.Text = (string)dr["cpf"];
                    txtCurso.Text = (string)dr["curso"];
                    txtAno.Text = Convert.ToString(dr["ano"]);
                    txtTurno.Text = (string)dr["turno"];
                }
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
                //comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //Vai alterar o valor anterior para o que o usuario digitar
                strSQL = "UPDATE CADASTROJARDIMBOTANICO SET ALUNO = @ALUNO, DATA_NASCIMENTO = @DATA_NASCIMENTO, CPF = @CPF, CURSO = @CURSO, ANO = @ANO, TURNO = @TURNO WHERE CONTRATO_N = @CONTRATO_N;";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPOS DA TABELA COM OS TEXTBOX DA INTERFACE

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@CONTRATO_N", txtContrato.Text);
                comando.Parameters.AddWithValue("@ALUNO", txtNome.Text);
                comando.Parameters.AddWithValue("@DATA_NASCIMENTO", txtNascimento.Text);
                comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                comando.Parameters.AddWithValue("@CURSO", txtCurso.Text);
                comando.Parameters.AddWithValue("@ANO", txtAno.Text);
                comando.Parameters.AddWithValue("@TURNO", txtTurno.Text);



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
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LimparControles();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //Excluindo DADOS no banco de dados na tabela CAD_CLIENTE
                strSQL = "DELETE CADASTROJARDIMBOTANICO WHERE CONTRATO_N = @CONTRATO_N";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPO ID DA TABELA COM O TEXTBOX ID DA INTERFASE

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@CONTRATO_N", txtContrato.Text);



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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            CarregaImagem();
        }
        public void CarregaImagem()
        {
            
                //verifica se a imagem foi carregada 
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //seleciona a imgaem e vincula a mesma ao pictureBox chamado "exibirImagem"
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    //carrega a imagem selecionada no Picture box "exibirImagem"
                    pictureBox1.Load();
                    //salva o caminho da imagem selecionada em um Label
                    // Caminho2.Text = "Caminho" + openFileDialog1.FileName;
                }
        }
    }
}

