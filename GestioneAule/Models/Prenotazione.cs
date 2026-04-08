namespace GestioneAule.Models
{
    public class Prenotazione
    {
        public int Id { get; set; }
        public string NomeStudente { get; set; }
        public int AulaId { get; set; }
        public DateTime Data { get; set; }
        public int OraInizio { get; set; }
        public int OraFine { get; set; }

        public Prenotazione(int id, string nomeStudente, int aulaId, DateTime data, int oraInizio, int oraFine)
        {
            Id = id;
            NomeStudente = nomeStudente;
            AulaId = aulaId;
            Data = data;
            OraInizio = oraInizio;
            OraFine = oraFine;
        }

        public override string ToString()
        {
            return $"Prenotazione {Id} - Studente: {NomeStudente} - Aula ID: {AulaId} - Data: {Data:dd/MM/yyyy} - {OraInizio}:00-{OraFine}:00";
        }
    }
}
