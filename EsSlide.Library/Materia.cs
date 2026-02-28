using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSlide.Library
{
    public class Materia
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Materia(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
    }
}
