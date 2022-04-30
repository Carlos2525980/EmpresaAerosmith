using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teste2
{
    public class Alunos
    {
      [Required]
       public int RA { get; set; }

      [Required]
       public string Nome { get; set; }

       [Required]
       public decimal NotalOficial1 { get; set; }
       [Required]
       public decimal NotalOficial2 { get; set; }

        public string Disciplina { get; set; }

        [Required]
        public decimal Media { get; set; }

        public string Aprovado { get; set; }
        public string Reprovado { get; set; }
        public string Recuperação { get; set; }

    }
}
