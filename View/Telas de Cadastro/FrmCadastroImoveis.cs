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

        private void button5_Click(object sender, EventArgs e)
        {


            try
            {
                conexao = new SqlConnection(@"Data Source=XANDAOAEROSMITH\SQLEXPRESS;Initial Catalog=Cadastro_Imoveis;User ID=sa;Password=123456");

                strSQL = "INSERT INTO IMOVEIS(ENDERECO, BAIRRO, CIDADE, NOME_EDIFICIO, NOME_PROPRIETARIO, AREA_MINIMA, " +
                    "VALOR_CONDOMINIO, VALOR_ENTRADA, VALOR_MAXIMO, " +
                    "DORMITORIO, SUITES, GARAGEM, VENDAS, LOCALIZACAO, " +
                    "NEGOCIADOS, SUSPENSOS, CASA, APARTAMENTO, TERREO, RURAL, " +
                    "COMERCIAL, INDUSTRIAL, KITNETE, COBERTURA, FLAT, STUDIO, " +
                    "SEM_CONDOMINIO, UM_POR_ANDAR, DUPLEX, TRIPLEX, PADRAO, ALTO_PADRAO, PENTHOUSE) " +
                    "VALUES(@ENDERECO, @BAIRRO, " +
                    "@CIDADE, @NOME_EDIFICIO, @NOME_PROPRIETARIO, @AREA_MINIMA, @VALOR_CONDOMINIO, " +
                    "@VALOR_ENTRADA, @VALOR_MAXIMO, @DORMITORIO, @SUITES, @GARAGEM, @VENDAS, @LOCALIZACAO, " +
                    "@NEGOCIADOS, @SUSPENSOS, @CASA, @APARTAMENTO, @TERREO, @RURAL, @COMERCIAL, @INDUSTRIAL, " +
                    "@KITNETE, @COBERTURA, @FLAT, @STUDIO, @SEM_CONDOMINIO, @UM_POR_ANDAR, @DUPLEX, @TRIPLEX, @PADRAO, @ALTO_PADRAO, @PENTHOUSE)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@NOME_EDIFICIO", txtN_Ed.Text);
                comando.Parameters.AddWithValue("@NOME_PROPRIETARIO", txtN_P.Text);
                comando.Parameters.AddWithValue("@AREA_MINIMA", txtArea_M.Text);
                comando.Parameters.AddWithValue("@VALOR_CONDOMINIO", txtV_M_C.Text);
                comando.Parameters.AddWithValue("@VALOR_ENTRADA", txtV_Entrada.Text);
                comando.Parameters.AddWithValue("@VALOR_MAXIMO", txtV_M.Text);
                comando.Parameters.AddWithValue("@DORMITORIO", txtDormitorio.Text);
                comando.Parameters.AddWithValue("@SUITES", txtSuites.Text);
                comando.Parameters.AddWithValue("@GARAGEM", txtGaragem.Text);
                comando.Parameters.AddWithValue("@VENDAS" , radioVenda.Checked);
                comando.Parameters.AddWithValue("@LOCALIZACAO", radioLocalizacao.Checked);
                comando.Parameters.AddWithValue("@NEGOCIADOS", radioNegociados.Checked);
                comando.Parameters.AddWithValue("@SUSPENSOS", radioSuspensos.Checked);
                comando.Parameters.AddWithValue("@CASA", checkCasa.Checked);
                comando.Parameters.AddWithValue("@APARTAMENTO", checkApartamento.Checked);
                comando.Parameters.AddWithValue("@TERREO", checkTerreo.Checked);
                comando.Parameters.AddWithValue("@RURAL", checkRural.Checked);
                comando.Parameters.AddWithValue("@COMERCIAL", checkComercial.Checked);
                comando.Parameters.AddWithValue("@INDUSTRIAL", checkIndustrial.Checked);
                comando.Parameters.AddWithValue("@KITNETE", checkKitnete.Checked);
                comando.Parameters.AddWithValue("@FLAT", checkFlat.Checked);
                comando.Parameters.AddWithValue("@COBERTURA", checkCobertura.Checked);
                comando.Parameters.AddWithValue("@STUDIO", checkStudio.Checked);
                comando.Parameters.AddWithValue("@SEM_CONDOMINIO", checkSem_Condominio.Checked);
                comando.Parameters.AddWithValue("@UM_POR_ANDAR", checkUm_por_andar.Checked);
                comando.Parameters.AddWithValue("@DUPLEX", checkDuplex.Checked);
                comando.Parameters.AddWithValue("@TRIPLEX", checkTriplex.Checked);
                comando.Parameters.AddWithValue("@PADRAO", checkPadrao.Checked);
                comando.Parameters.AddWithValue("@ALTO_PADRAO", checkAlto_Padrao.Checked);
                comando.Parameters.AddWithValue("@PENTHOUSE", checkPentHouse.Checked);
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

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                conexao = new SqlConnection(@"Data Source=XANDAOAEROSMITH\SQLEXPRESS;Initial Catalog=Cadastro_Imoveis;User ID=sa;Password=123456");

                strSQL = " SELECT * FROM IMOVEIS ";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();
                da.Fill(ds);

                dvgdados.DataSource = ds.Tables[0];
            
            
            
            
            
            
            }catch (Exception ex)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {



            try
            {

                conexao = new SqlConnection(@"Data Source=XANDAOAEROSMITH\SQLEXPRESS;Initial Catalog=Cadastro_Imoveis;User ID=sa;Password=123456");


                strSQL = "SELECT * FROM IMOVEIS WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID.Text);


                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtEndereco.Text = (string)dr["endereco"];
                    txtBairro.Text = (string)dr["bairro"];
                    txtCidade.Text = (string)dr["cidade"];
                    txtN_Ed.Text = (string)dr["NOME_EDIFICIO"];
                    txtN_P.Text = (string)dr["NOME_PROPRIETARIO"];
                    txtArea_M.Text = Convert.ToString(dr["AREA_MINIMA"]);
                    txtV_M.Text = Convert.ToString(dr["VALOR_MAXIMO"]);
                    txtV_Entrada.Text = Convert.ToString(dr["VALOR_ENTRADA"]);
                    txtV_M_C.Text = Convert.ToString(dr["VALOR_CONDOMINIO"]);
                    txtDormitorio.Text = Convert.ToString(dr["DORMITORIO"]);
                    txtSuites.Text = Convert.ToString(dr["SUITES"]);
                    txtGaragem.Text = Convert.ToString(dr["GARAGEM"]);
                    radioVenda.Checked = ((bool)dr["VENDAS"]);
                    radioLocalizacao.Checked = ((bool)dr["LOCALIZACAO"]);
                    radioNegociados.Checked = ((bool)dr["NEGOCIADOS"]);
                    radioSuspensos.Checked = ((bool)dr["SUSPENSOS"]);
                    checkCasa.Checked = ((bool)dr["CASA"]);
                    checkApartamento.Checked = ((bool)dr["APARTAMENTO"]);
                    checkTerreo.Checked = ((bool)dr["TERREO"]);
                    checkRural.Checked = ((bool)dr["RURAL"]);
                    checkComercial.Checked = ((bool)dr["COMERCIAL"]);
                    checkIndustrial.Checked = ((bool)dr["INDUSTRIAL"]);
                    checkKitnete.Checked = ((bool)dr["KITNETE"]);
                    checkFlat.Checked = ((bool)dr["FLAT"]);
                    checkCobertura.Checked = ((bool)dr["COBERTURA"]);
                    checkStudio.Checked = ((bool)dr["STUDIO"]);
                    checkSem_Condominio.Checked = ((bool)dr["SEM_CONDOMINIO"]);
                    checkUm_por_andar.Checked = ((bool)dr["UM_POR_ANDAR"]);
                    checkDuplex.Checked = ((bool)dr["DUPLEX"]);
                    checkTriplex.Checked = ((bool)dr["TRIPLEX"]);
                    checkPadrao.Checked = ((bool)dr["PADRAO"]);
                    checkAlto_Padrao.Checked = ((bool)dr["ALTO_PADRAO"]);
                    checkPentHouse.Checked = ((bool)dr["PENTHOUSE"]);

                    
                }




            } catch (Exception ex)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                conexao = new SqlConnection(@"Data Source=XANDAOAEROSMITH\SQLEXPRESS;Initial Catalog=Cadastro_Imoveis;User ID=sa;Password=123456");

                strSQL = "UPDATE IMOVEIS SET ENDERECO = @ENDERECO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, NOME_EDIFICIO = @NOME_EDIFICIO, " +
                    "NOME_PROPRIETARIO = @NOME_PROPRIETARIO, AREA_MINIMA = @AREA_MINIMA, " +
                    "VALOR_CONDOMINIO = @VALOR_CONDOMINIO , VALOR_ENTRADA = @VALOR_ENTRADA, VALOR_MAXIMO = @VALOR_MAXIMO, " +
                    "DORMITORIO = @DORMITORIO, SUITES = @SUITES, GARAGEM = @GARAGEM, VENDAS = @VENDAS, LOCALIZACAO = @LOCALIZACAO, " +
                    "NEGOCIADOS = @NEGOCIADOS, SUSPENSOS = @SUSPENSOS, CASA = @CASA, APARTAMENTO = @APARTAMENTO, TERREO = @TERREO, RURAL = @RURAL, " +
                    "COMERCIAL = @COMERCIAL, INDUSTRIAL = @INDUSTRIAL, KITNETE = @KITNETE, COBERTURA = @COBERTURA, FLAT = @FLAT, STUDIO = @STUDIO, " +
                    "SEM_CONDOMINIO = @SEM_CONDOMINIO, UM_POR_ANDAR = @UM_POR_ANDAR, DUPLEX = @DUPLEX, TRIPLEX = @TRIPLEX, PADRAO = @PADRAO, " +
                    "ALTO_PADRAO = @ALTO_PADRAO, PENTHOUSE = @PENTHOUSE, WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);


                comando.Parameters.AddWithValue("@ID", txtID);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@NOME_EDIFICIO", txtN_Ed.Text);
                comando.Parameters.AddWithValue("@NOME_PROPRIETARIO", txtN_P.Text);
                comando.Parameters.AddWithValue("@AREA_MINIMA", txtArea_M.Text);
                comando.Parameters.AddWithValue("@VALOR_CONDOMINIO", txtV_M_C.Text);
                comando.Parameters.AddWithValue("@VALOR_ENTRADA", txtV_Entrada.Text);
                comando.Parameters.AddWithValue("@VALOR_MAXIMO", txtV_M.Text);
                comando.Parameters.AddWithValue("@DORMITORIO", txtDormitorio.Text);
                comando.Parameters.AddWithValue("@SUITES", txtSuites.Text);
                comando.Parameters.AddWithValue("@GARAGEM", txtGaragem.Text);
                comando.Parameters.AddWithValue("@VENDAS", radioVenda.Checked);
                comando.Parameters.AddWithValue("@LOCALIZACAO", radioLocalizacao.Checked);
                comando.Parameters.AddWithValue("@NEGOCIADOS", radioNegociados.Checked);
                comando.Parameters.AddWithValue("@SUSPENSOS", radioSuspensos.Checked);
                comando.Parameters.AddWithValue("@CASA", checkCasa.Checked);
                comando.Parameters.AddWithValue("@APARTAMENTO", checkApartamento.Checked);
                comando.Parameters.AddWithValue("@TERREO", checkTerreo.Checked);
                comando.Parameters.AddWithValue("@RURAL", checkRural.Checked);
                comando.Parameters.AddWithValue("@COMERCIAL", checkComercial.Checked);
                comando.Parameters.AddWithValue("@INDUSTRIAL", checkIndustrial.Checked);
                comando.Parameters.AddWithValue("@KITNETE", checkKitnete.Checked);
                comando.Parameters.AddWithValue("@FLAT", checkFlat.Checked);
                comando.Parameters.AddWithValue("@COBERTURA", checkCobertura.Checked);
                comando.Parameters.AddWithValue("@STUDIO", checkStudio.Checked);
                comando.Parameters.AddWithValue("@SEM_CONDOMINIO", checkSem_Condominio.Checked);
                comando.Parameters.AddWithValue("@UM_POR_ANDAR", checkUm_por_andar.Checked);
                comando.Parameters.AddWithValue("@DUPLEX", checkDuplex.Checked);
                comando.Parameters.AddWithValue("@TRIPLEX", checkTriplex.Checked);
                comando.Parameters.AddWithValue("@PADRAO", checkPadrao.Checked);
                comando.Parameters.AddWithValue("@ALTO_PADRAO", checkAlto_Padrao.Checked);
                comando.Parameters.AddWithValue("@PENTHOUSE", checkPentHouse.Checked);
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
            */
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source=XANDAOAEROSMITH\SQLEXPRESS;Initial Catalog=Cadastro_Imoveis;User ID=sa;Password=123456");

                //Excluindo DADOS no banco de dados na tabela CAD_CLIENTE
                strSQL = "DELETE IMOVEIS WHERE ID = @ID";

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
    }
}
