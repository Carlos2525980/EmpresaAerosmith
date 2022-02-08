using Microsoft.Data.SqlClient;
using Model;
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

        List<Aluno> lista = new List<Aluno>();
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                //inserindo DADOS no banco de dados na tabela CAD_CLIENTE
                strSQL = "INSERT INTO CADASTROJARDIMBOTANICO(ALUNO, CONTRATO_N, DATA_NASCIMENTO, CPF, CURSO, ANO, TURNO) VALUES (@ALUNO, @CONTRATO_N, @DATA_NASCIMENTO, @CPF, @CURSO, @ANO, @TURNO)";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPOS DA TABELA COM OS TEXTBOX DA INTERFACE

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ALUNO", txtNome.Text);
                comando.Parameters.AddWithValue("@CONTRATO_N", txtContrato.Text);
                comando.Parameters.AddWithValue("@DATA_NASCIMENTO", txtNascimento.Text);
                comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                comando.Parameters.AddWithValue("@CURSO", txtCurso.Text);
                comando.Parameters.AddWithValue("@ANO", txtAno.Text);
                comando.Parameters.AddWithValue("@TURNO", txtTurno.Text);

                //dataGridView1.ColumnCount = 7;
                //dataGridView1.Columns[0].Name = "Contrato";
                //dataGridView1.Columns[1].Name = "Nome";
                //dataGridView1.Columns[2].Name = "Nascimento";
                //dataGridView1.Columns[3].Name = "CPF";
                //dataGridView1.Columns[4].Name = "Curso";
                //dataGridView1.Columns[5].Name = "Ano";
                //dataGridView1.Columns[6].Name = "Turno";

                //ABRINDO CONEXAO
                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Inserido com sucesso!");
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
    }
}
