namespace GestioneAule.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capienza { get; set; }

        public Aula(int id, string nome, int capienza)
        {
            Id = id;
            Nome = nome;
            Capienza = capienza;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Nome: {Nome} - Capienza: {Capienza}";
        }
    }
}
