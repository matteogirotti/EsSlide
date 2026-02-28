namespace EsSlide.Library
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }

        public Persona(string nome, string cognome, DateTime dataDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}, nato il {DataDiNascita.ToShortDateString()}";
        }
    }
}
