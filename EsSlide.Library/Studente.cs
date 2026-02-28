using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSlide.Library
{
    public class Studente : Persona
    {
        public List<Voto> Voti { get; private set; }

        public Studente(string nome, string cognome, DateTime dataDiNascita)
        : base(nome, cognome, dataDiNascita)
        {
            Voti = new List<Voto>();
        }

        public void AggiungiVoto(Voto voto)
        {
            Voti.Add(voto);
        }
    }
}
