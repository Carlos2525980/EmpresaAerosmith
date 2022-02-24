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

namespace View.Telas_de_Calculos
{
    public partial class CalculoImc : Form
    {
        public CalculoImc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtPeso.Text == "" || txtAltura.Text == "")
            {

                MessageBox.Show("Digite o 'PESO' e a 'ALTURA'! ");


            }else{
                float IMC;

                Imc imc = new Imc();

                imc.Peso = float.Parse(txtPeso.Text);
                imc.Altura = float.Parse(txtAltura.Text);



                IMC = (imc.Peso / (imc.Altura * imc.Altura));

                if (IMC <= 18.5)
                {
                    MessageBox.Show("Você está Abaixo do peso! " + " Isso pode causar Fadiga, stress, ansiedade!");
                }
                else if (IMC > 18.5 && IMC < 25)
                {
                    MessageBox.Show("Parabéns! Você esta com o peso normal! " + " Você tem Menor risco de doenças cardíacas e vasculares!");

                }
                else if (IMC >= 25 && IMC < 30)
                {

                    MessageBox.Show("Alerta! Você esta a cima do peso! " + " Isso pode lhe causar Fadiga, má circulação, varizes");

                }
                else if (IMC >= 30 && IMC < 35)
                {
                    MessageBox.Show("Preocupante! Você está em estado  de Obesidade Grau I " + " Isso pode lhe causar Diabetes, angina, infarto, aterosclerose");

                }
                else if ((IMC >= 35) && (IMC < 40))
                {
                    MessageBox.Show("Grave! Grau de Obesidade II " + " Procure um medico o quanto antes!");
                }
                else if (IMC >= 40)
                {
                    MessageBox.Show(" Perigo! Obesidade Grau III " + " Sua vida esta em risco! ");
                }

            }
        }

        private void CalculoImc_FormClosing(object sender, FormClosingEventArgs e)
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
