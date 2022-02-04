using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace LoginTest
{
    public partial class TelaLogin : MetroFramework.Forms.MetroForm
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*Se o campo estiver em branco*/
            if (txtEmail.Text == string.Empty && txtSenha.Text == string.Empty )
            {




                MessageBox.Show("Campo em branco! Digite seu Email e Senha!");





            }/*Se a senha estiver correta*/
            else if(txtEmail.Text == "carlos" && txtSenha.Text == "123")
            {
                Hide();
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                MessageBox.Show(" SEJA BEM VINDO XANDÃO AEROSMITH!");
            }
            else
            {/*Se a senha estiver errada*/
                MessageBox.Show("Senha inválida!");
            }
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {


            this.FocusMe();
            this.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          

          

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {



            /*Se o checkbox estiver clicado ele vai bloquear os campos*/
            if (checkBox1.Checked == true)
            {


                txtEmail.Enabled = false;
                txtSenha.Enabled = false;

            }
            else/*Se desmarcar ele libera os campos bloqueados*/
            {
              
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //seleciona a imgaem e vincula a mesma ao pictureBox chamado "exibirImagem"
                Carregar.ImageLocation = openFileDialog1.FileName;
                //carrega a imagem selecionada no Picture box "exibirImagem"
                Carregar.Load();
                //salva o caminho da imagem selecionada em um Label
                //label5.Text = "Caminho" + openFileDialog1.FileName;




            }

        }
    }
}
