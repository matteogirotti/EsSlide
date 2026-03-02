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

        public double CalcolaMedia(Studente studente)
        {
            if (studente == null || studente.Voti == null || studente.Voti.Count == 0)
                return 0;

            double somma = 0;

            foreach(Voto voto in studente.Voti)
            {
                somma += voto.Valore;
            }

            return somma / studente.Voti.Count;
        }

        public double[] CalcolaMediaMensile(Studente studente, int anno)
        {
            double[] medie = new double[12];

            // ciclo per ogni mese
            for (int mese = 1; mese <= 12; mese++)
            {
                double somma = 0;
                int count = 0;

                // controllo tutti i voti dello studente
                for (int i = 0; i < studente.Voti.Count; i++)
                {
                    if (studente.Voti[i].Data.Year == anno &&
                        studente.Voti[i].Data.Month == mese)
                    {
                        somma += studente.Voti[i].Valore;
                        count++;
                    }
                }

                // calcolo la media
                if (count > 0)
                {
                    medie[mese - 1] = somma / count;
                }
                else
                {
                    medie[mese - 1] = 0;
                }
            }

            return medie;
        }
    }
}
