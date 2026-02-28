using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSlide.Library
{
    public class Scuola
    {
        public string Nome { get; set; }
        public List<Studente> Studenti { get; private set; }
        public List<Insegnante> Insegnanti { get; private set; }

        public Scuola(string nome)
        {
            Nome = nome;
            Studenti = new List<Studente>();
            Insegnanti = new List<Insegnante>();
        }

        public void AggiungiStudente(Studente studente)
        {
            Studenti.Add(studente);
        }

        public void AggiungiInsegnante(Insegnante insegnante)
        {
            Insegnanti.Add(insegnante);
        }
    }
}
