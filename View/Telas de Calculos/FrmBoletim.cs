using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teste2
{
    public partial class FrmBoletim : Form
    {
        public FrmBoletim()
        {
            InitializeComponent();

            txtRA.Enabled = true;
            txtAluno.Enabled = false;
            CBDisciplina.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;

        }
        List<Alunos> lista = new List<Alunos>();
        Alunos aluno = new Alunos();
        Disciplinas disciplinas = new Disciplinas();
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (txtNota1.Text == "" && txtNota2.Text == "")
                {
                    MessageBox.Show("Digite as notas do aluno");
                }
                if (txtRA.Text == "" && txtAluno.Text == "")
                {
                MessageBox.Show("Por favor, Cadastre o Aluno!");
                }
                else
                {
                    aluno.RA = (int)Convert.ToInt64(txtRA.Text);
                    aluno.Nome = Convert.ToString(txtAluno.Text);
                    aluno.NotalOficial1 = Convert.ToInt64(txtNota1.Text);
                    aluno.NotalOficial2 = Convert.ToInt64(txtNota2.Text);

                     if (CBDisciplina.Text == disciplinas.Matematica)
                     {
                       aluno.Disciplina = Convert.ToString(CBDisciplina.Text);
                     }
                      else if(CBDisciplina.Text == disciplinas.Logica){
                        aluno.Disciplina = Convert.ToString(CBDisciplina.Text);
                       }
                       else
                       {
                          aluno.Disciplina = Convert.ToString(CBDisciplina.Text);
                       }

                    Calcular();

                    if (lbStatus.Text == "APROVADO")
                    {
                        aluno.Aprovado = "APROVADO";
                    }
                    else if (lbStatus.Text == "RECUPERAÇÃO")
                    {
                        aluno.Recuperação = "RECUPERAÇÃO";
                    }
                    else
                    {
                        aluno.Reprovado = "REPROVADO";
                    }
                    lista.Add(aluno);
                    
                
                    gridBoletim.DataSource = lista;
                   
                }
        }
        public void Calcular()
        {
            aluno.Media = aluno.NotalOficial1 + aluno.NotalOficial2 / 2;

            if (aluno.Media >= 6.0m)
            {
                lbStatus.Text = "APROVADO";
               
            }
            else if (aluno.Media < 6.0m && aluno.Media > 4.0m)
            {
                lbStatus.Text = "RECUPERAÇÃO";
            }
            else
            {
                lbStatus.Text = "REPROVADO";
            }
        }

        private void txtRA_TextChanged(object sender, EventArgs e)
        {


            if (txtRA.Text == null)
            {

                txtAluno.Enabled = false;

            }
            else
            {
                txtAluno.Enabled = true;
            }




        }

        private void txtAluno_TextChanged(object sender, EventArgs e)
        {


            if (txtAluno.Text == null)
            {
                CBDisciplina.Enabled = false;
            }
            else
            {
                CBDisciplina.Enabled = true;
            }


        }

        private void CBDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBDisciplina == null)
            {
                txtNota1.Enabled = false;
            }
            else
            {
                txtNota1.Enabled = true;
            }
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            if (txtNota1 == null)
            {
                txtNota2.Enabled = false;
            }
            else
            {
                txtNota2.Enabled = true;
            }
        }
    }
}
