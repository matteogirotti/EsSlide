using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSlide.Library
{
    public class Insegnante : Persona
    {
        public List<Materia> MaterieInsegnate { get; private set; }

        public Insegnante(string nome, string cognome, DateTime dataDiNascita)
        : base(nome, cognome, dataDiNascita)
        {
            MaterieInsegnate = new List<Materia>();
        }

        public void AggiungiMateria(Materia materia)
        {
            MaterieInsegnate.Add(materia);
        }
    }
}
