using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos
{
    public class Pessoa : IApresentavel 

    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; } 
        
        public string Apresentacao()
        {
            return "Meu nome é " + Nome + " e tenho" + Idade + " anos.";
        }
    }

}
