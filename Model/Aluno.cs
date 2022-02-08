using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aluno
    {
        public string ContratoN { get; set; }

        public string Nome { get; set; }

        public DateTime Data_Nascimento { get; set; }

        public string RG { get; set; }

        public int CPF { get; set; }

        public string Curso { get; set; }

        public DateTime Ano { get; set; }

        public string Turno { get; set; }

        public DateTime DTMatricula { get; set; }

        public DateTime DTValidade { get; set; }
    }
}
