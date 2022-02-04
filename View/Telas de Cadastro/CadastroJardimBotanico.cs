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
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Contrato";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Nascimento";
            dataGridView1.Columns[3].Name = "CPF";
            dataGridView1.Columns[4].Name = "Curso";
            dataGridView1.Columns[5].Name = "Ano";
            dataGridView1.Columns[6].Name = "Turno";

            dataGridView1.Rows.Add(textNome.Text, textContrato.Text, maskedTextBoxNascimento.Text,
               maskedCPF.Text, textBoxCurso.Text, textBoxAno.Text, textboxTurno.Text);

        }

        private void CadastroJardimBotanico_Load(object sender, EventArgs e)
        {

            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textContrato.Text = row.Cells["Contrato"].Value.ToString();
                textNome.Text = row.Cells["Nome"].Value.ToString();
                maskedTextBoxNascimento.Text = row.Cells["Nascimento"].Value.ToString();
                maskedCPF.Text = row.Cells["CPF"].Value.ToString();
                textBoxCurso.Text = row.Cells["Curso"].Value.ToString();
                textBoxAno.Text = row.Cells["Ano"].Value.ToString();
                textboxTurno.Text = row.Cells["Turno"].Value.ToString();
                
            }
        }
    }
}
