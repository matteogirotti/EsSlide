using EsSlide.Library;

namespace EsSlide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scuola scuola = new Scuola("IIS Primo Levi");
            Materia matematica = new Materia("Matematica", "MAT");
            Materia informatica = new Materia("Informatica", "INF");
            Insegnante profRossi = new Insegnante("Mario", "Rossi", new DateTime(1980, 5, 12));

            profRossi.AggiungiMateria(matematica);
            profRossi.AggiungiMateria(informatica);
            scuola.AggiungiInsegnante(profRossi);

            Studente studente1 = new Studente("Luca", "Bianchi", new DateTime(2005, 3, 20));
            Studente studente2 = new Studente("Marco", "Verdi", new DateTime(2006, 7, 2));

            studente1.AggiungiVoto(new Voto(DateTime.Now, matematica, 8));
            studente1.AggiungiVoto(new Voto(DateTime.Now, informatica, 9));
            scuola.AggiungiStudente(studente1);

            studente2.AggiungiVoto(new Voto(DateTime.Now, matematica, 4.5));
            studente2.AggiungiVoto(new Voto(DateTime.Now, informatica, 6));
            scuola.AggiungiStudente(studente2);

            Console.WriteLine($"Scuola: {scuola.Nome}");
            Console.WriteLine();
            Console.WriteLine("--- Insegnanti ---");

            foreach (var insegnante in scuola.Insegnanti)
            {
                Console.WriteLine($"{insegnante.Nome} {insegnante.Cognome}");
                Console.WriteLine("Materie insegnate:");
                foreach (var materia in insegnante.MaterieInsegnate)
                {
                    Console.WriteLine($"- {materia.Nome} ({materia.Sigla})");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--- Studenti ---");
            foreach (var studente in scuola.Studenti)
            {
                Console.WriteLine($"{studente.Nome} {studente.Cognome}");
                Console.WriteLine("Voti:");
                foreach (var voto in studente.Voti)
                {
                    Console.WriteLine($"- {voto.Materia.Nome} | Data: {voto.Data.ToShortDateString()} | Voto: {voto.Valore}");
                }
                Console.WriteLine();
            }

            double a = scuola.CalcolaMedia(studente1);
            Console.WriteLine($"Media {studente1.Nome} {studente1.Cognome} nel 2026: {a}");

            double[] b = scuola.CalcolaMediaMensile(studente1, 2026);
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"\nMese {i + 1}: {b[i]}");
            }
        }
    }
}
