using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace CadaastroDeImoveis
{
    public partial class FrmCadastroImoveis : Form
    {


        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;



        public FrmCadastroImoveis()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGravar_Click(object sender, EventArgs e)
        {


            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                strSQL = "INSERT INTO CADASTROIMOVEIS(ENDERECO, BAIRRO, CIDADE, NOME_DO_EDIFICIO, NOME_DO_PROPRIETARIO, AREA_MINIMA, " +
                    "VALOR_CONDOMINIO, VALOR_ENTRADA, VALOR_TOTAL, " +
                    "NUMERO_DORMITORIOS, NUMERO_SUITES, NUMERO_GARAGEM, SITUACAO_IMOVEL, CASA, APARTAMENTO, TERREO, RURAL, " +
                    "COMERCIAL, INDUSTRIAL, KITNET, COBERTURA, FLAT, STUDIO, " +
                    "SEM_CONDOMINIO, DUPLEX, TRIPLEX, PADRAO, ALTO_PADRAO, PENTHOUSE) " +
                    "VALUES(@ENDERECO, @BAIRRO, " +
                    "@CIDADE, @NOME_DO_EDIFICIO, @NOME_DO_PROPRIETARIO, @AREA_MINIMA, @VALOR_CONDOMINIO, " +
                    "@VALOR_ENTRADA, @VALOR_TOTAL, @NUMERO_DORMITORIOS, @NUMERO_SUITES, @NUMERO_GARAGEM, @SITUACAO_IMOVEL, @CASA, @APARTAMENTO, @TERREO, @RURAL, @COMERCIAL, @INDUSTRIAL, " +
                    "@KITNET, @COBERTURA, @FLAT, @STUDIO, @SEM_CONDOMINIO, @DUPLEX, @TRIPLEX, @PADRAO, @ALTO_PADRAO, @PENTHOUSE)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@NOME_DO_EDIFICIO", txtN_Ed.Text);
                comando.Parameters.AddWithValue("@NOME_DO_PROPRIETARIO", txtN_P.Text);
                comando.Parameters.AddWithValue("@AREA_MINIMA", txtArea_M.Text);
                comando.Parameters.AddWithValue("@VALOR_CONDOMINIO", txtV_M_C.Text);
                comando.Parameters.AddWithValue("@VALOR_ENTRADA", txtV_Entrada.Text);
                comando.Parameters.AddWithValue("@VALOR_TOTAL", txtV_M.Text);
                comando.Parameters.AddWithValue("@NUMERO_DORMITORIOS", txtDormitorio.Text);
                comando.Parameters.AddWithValue("@LOCACAO", radioLocacao.Text);
                comando.Parameters.AddWithValue("@NEGOCIADOS", radioNegociados.Text);
                comando.Parameters.AddWithValue("@SUSPENSOS", radioSuspensos.Text);
                comando.Parameters.AddWithValue("@NUMERO_SUITES", txtSuites.Text);
                comando.Parameters.AddWithValue("@NUMERO_GARAGEM", txtGaragem.Text);
                comando.Parameters.AddWithValue("@CASA", checkCasa.Checked);
                comando.Parameters.AddWithValue("@APARTAMENTO", checkApartamento.Checked);
                comando.Parameters.AddWithValue("@RURAL", checkRural.Checked);
                comando.Parameters.AddWithValue("@COMERCIAL", checkComercial.Checked);
                comando.Parameters.AddWithValue("@INDUSTRIAL", checkIndustrial.Checked);
                comando.Parameters.AddWithValue("@KITNET", checkKitnete.Checked);
                comando.Parameters.AddWithValue("@FLAT", checkFlat.Checked);
                comando.Parameters.AddWithValue("@COBERTURA", checkCobertura.Checked);
                comando.Parameters.AddWithValue("@STUDIO", checkStudio.Checked);
                comando.Parameters.AddWithValue("@SEM_CONDOMINIO", checkSem_Condominio.Checked);
                comando.Parameters.AddWithValue("@DUPLEX", checkDuplex.Checked);
                comando.Parameters.AddWithValue("@TRIPLEX", checkTriplex.Checked);
                comando.Parameters.AddWithValue("@PADRAO", checkPadrao.Checked);
                comando.Parameters.AddWithValue("@ALTO_PADRAO", checkAlto_Padrao.Checked);
                comando.Parameters.AddWithValue("@PENTHOUSE", checkPentHouse.Checked);
                comando.Parameters.AddWithValue("@TERREO", checkTerreo.Checked);

               
                if (radioVenda.Checked == true)
                {
                    comando.Parameters.AddWithValue("@SITUACAO_IMOVEL", radioVenda.Text);
                }
                else if (radioLocacao.Checked == true)
                {
                    comando.Parameters.AddWithValue("@SITUACAO_IMOVEL", radioLocacao.Text);
                }
                else if (radioNegociados.Checked == true)
                {
                    comando.Parameters.AddWithValue("@SITUACAO_IMOVEL", radioNegociados.Text);
                }
                else if (radioSuspensos.Checked == true)
                {
                    comando.Parameters.AddWithValue("@SITUACAO_IMOVEL", radioSuspensos.Text);
                }


                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("INSERIDO COM SUCESSO!");




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

        private void btnCarregar_Click(object sender, EventArgs e)
        {


            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                strSQL = " SELECT * FROM CADASTROIMOVEIS ";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();
                da.Fill(ds);

                dvgdados.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
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

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {



            try
            {

                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");


                strSQL = "SELECT * FROM CADASTROIMOVEIS WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID.Text);


                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtEndereco.Text = (string)dr["endereco"];
                    txtBairro.Text = (string)dr["bairro"];
                    txtCidade.Text = (string)dr["cidade"];
                    txtN_Ed.Text = (string)dr["NOME_DO_EDIFICIO"];
                    txtN_P.Text = (string)dr["NOME_DO_PROPRIETARIO"];
                    txtArea_M.Text = Convert.ToString(dr["AREA_MINIMA"]);
                    txtV_M.Text = Convert.ToString(dr["VALOR_TOTAL"]);
                    txtV_Entrada.Text = Convert.ToString(dr["VALOR_ENTRADA"]);
                    txtV_M_C.Text = Convert.ToString(dr["VALOR_CONDOMINIO"]);
                    txtDormitorio.Text = Convert.ToString(dr["NUMERO_DORMITORIOS"]);
                    txtSuites.Text = Convert.ToString(dr["NUMERO_SUITES"]);
                    txtGaragem.Text = Convert.ToString(dr["NUMERO_GARAGEM"]);

                    MessageBox.Show("BUSCA REALIZADA COM SUCESSO!");

                }

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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                strSQL = "UPDATE CADASTROIMOVEIS SET ENDERECO = @ENDERECO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, NOME_DO_EDIFICIO = @NOME_DO_EDIFICIO, " +
                    "NOME_DO_PROPRIETARIO = @NOME_DO_PROPRIETARIO, AREA_MINIMA = @AREA_MINIMA, " +
                    "VALOR_CONDOMINIO = @VALOR_CONDOMINIO , VALOR_ENTRADA = @VALOR_ENTRADA, VALOR_TOTAL = @VALOR_TOTAL, " +
                    "NUMERO_DORMITORIOS = @NUMERO_DORMITORIOS, NUMERO_SUITES = @NUMERO_SUITES, NUMERO_GARAGEM = @NUMERO_GARAGEM WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@NOME_DO_EDIFICIO", txtN_Ed.Text);
                comando.Parameters.AddWithValue("@NOME_DO_PROPRIETARIO", txtN_P.Text);
                comando.Parameters.AddWithValue("@AREA_MINIMA", txtArea_M.Text);
                comando.Parameters.AddWithValue("@VALOR_CONDOMINIO", txtV_M_C.Text);
                comando.Parameters.AddWithValue("@VALOR_ENTRADA", txtV_Entrada.Text);
                comando.Parameters.AddWithValue("@VALOR_TOTAL", txtV_M.Text);
                comando.Parameters.AddWithValue("@NUMERO_DORMITORIOS", txtDormitorio.Text);
                comando.Parameters.AddWithValue("@LOCACAO", radioLocacao.Text);
                comando.Parameters.AddWithValue("@NEGOCIADOS", radioNegociados.Text);
                comando.Parameters.AddWithValue("@SUSPENSOS", radioSuspensos.Text);
                comando.Parameters.AddWithValue("@NUMERO_SUITES", txtSuites.Text);
                comando.Parameters.AddWithValue("@NUMERO_GARAGEM", txtGaragem.Text);
                comando.Parameters.AddWithValue("@CASA", checkCasa.Checked);
                comando.Parameters.AddWithValue("@APARTAMENTO", checkApartamento.Checked);
                comando.Parameters.AddWithValue("@RURAL", checkRural.Checked);
                comando.Parameters.AddWithValue("@COMERCIAL", checkComercial.Checked);
                comando.Parameters.AddWithValue("@INDUSTRIAL", checkIndustrial.Checked);
                comando.Parameters.AddWithValue("@KITNET", checkKitnete.Checked);
                comando.Parameters.AddWithValue("@FLAT", checkFlat.Checked);
                comando.Parameters.AddWithValue("@COBERTURA", checkCobertura.Checked);
                comando.Parameters.AddWithValue("@STUDIO", checkStudio.Checked);
                comando.Parameters.AddWithValue("@SEM_CONDOMINIO", checkSem_Condominio.Checked);
                comando.Parameters.AddWithValue("@DUPLEX", checkDuplex.Checked);
                comando.Parameters.AddWithValue("@TRIPLEX", checkTriplex.Checked);
                comando.Parameters.AddWithValue("@PADRAO", checkPadrao.Checked);
                comando.Parameters.AddWithValue("@ALTO_PADRAO", checkAlto_Padrao.Checked);
                comando.Parameters.AddWithValue("@PENTHOUSE", checkPentHouse.Checked);
                comando.Parameters.AddWithValue("@TERREO", checkTerreo.Checked);


                conexao.Open();
                comando.ExecuteNonQuery();


                MessageBox.Show("ALTERADO COM SUCESSO!");


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
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
                try
                {
                    //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                    conexao = new SqlConnection(@"Data Source=DESKTOP-JQ2VDHB;Initial Catalog=SistemaAerosmith;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

                    //Excluindo DADOS no banco de dados na tabela CAD_CLIENTE
                    strSQL = "DELETE CADASTROIMOVEIS WHERE ID = @ID";

                    //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPO ID DA TABELA COM O TEXTBOX ID DA INTERFASE

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@ID", txtID.Text);



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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "My Report"; //give your report name
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "footer"; //this is the footer
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dvgdados);
        }

        private void FrmCadastroImoveis_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

    

