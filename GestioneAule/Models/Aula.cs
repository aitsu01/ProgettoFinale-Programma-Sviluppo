namespace GestioneAule.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Materia { get; set; }
        public int Capienza { get; set; }

        public Aula()
        {
        }

        public Aula(int id, string nome, string materia, int capienza)
        {
            Id = id;
            Nome = nome;
            Materia = materia;
            Capienza = capienza;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Nome aula: {Nome} - Materia: {Materia} - Capienza: {Capienza}";
        }
    }
}
