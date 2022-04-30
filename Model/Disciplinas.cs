using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    public class Disciplinas
    {
    
      [Required]
      public string Matematica { get; set; }
      [Required]
      public string Logica { get; set; }
      [Required]
      public string Algoristmo { get; set; }

        public Disciplinas()
        {
            this.Matematica = Matematica;
            this.Logica = Logica;
            this.Algoristmo = Algoristmo;
        }
    
    
    }


}
