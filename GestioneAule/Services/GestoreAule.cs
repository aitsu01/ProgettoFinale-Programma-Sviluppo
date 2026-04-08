using GestioneAule.Models;

namespace GestioneAule.Services
{
    public class GestoreAule
    {
        private List<Aula> aule = new List<Aula>();
        private List<Prenotazione> prenotazioni = new List<Prenotazione>();

        public void AggiungiAula(Aula aula)
        {
            aule.Add(aula);
        }

        public void MostraAule()
        {
            if (aule.Count == 0)
            {
                Console.WriteLine("Nessuna aula presente.");
                return;
            }

            foreach (var aula in aule)
            {
                Console.WriteLine(aula);
            }
        }

        public bool AulaEsiste(int aulaId)
        {
            return aule.Any(a => a.Id == aulaId);
        }

        public bool ControllaDisponibilita(Prenotazione nuovaPrenotazione)
        {
            foreach (var prenotazione in prenotazioni)
            {
                if (prenotazione.AulaId == nuovaPrenotazione.AulaId &&
                    prenotazione.Data.Date == nuovaPrenotazione.Data.Date &&
                    nuovaPrenotazione.OraInizio < prenotazione.OraFine &&
                    nuovaPrenotazione.OraFine > prenotazione.OraInizio)
                {
                    return false;
                }
            }

            return true;
        }

        public bool AggiungiPrenotazione(Prenotazione prenotazione)
        {
            if (!AulaEsiste(prenotazione.AulaId))
                return false;

            if (prenotazione.OraInizio >= prenotazione.OraFine)
                return false;

            if (!ControllaDisponibilita(prenotazione))
                return false;

            prenotazioni.Add(prenotazione);
            return true;
        }

        public void MostraPrenotazioni()
        {
            if (prenotazioni.Count == 0)
            {
                Console.WriteLine("Nessuna prenotazione presente.");
                return;
            }

            foreach (var prenotazione in prenotazioni)
            {
                Console.WriteLine(prenotazione);
            }
        }

        public Prenotazione OttieniUltimaPrenotazione()
        {
            if (prenotazioni.Count == 0)
                return null;

            return prenotazioni[prenotazioni.Count - 1];
        }

        public Prenotazione CercaPrenotazionePerId(int id)
        {
            return prenotazioni.FirstOrDefault(p => p.Id == id);
        }

        public List<Prenotazione> CercaPrenotazioniPerStudente(string nomeStudente)
        {
            return prenotazioni
                .Where(p => p.NomeStudente.ToLower().Contains(nomeStudente.ToLower()))
                .ToList();
        }

        public List<Prenotazione> CercaPrenotazioniPerMateria(string materia)
        {
            return prenotazioni
                .Where(p => p.Materia.ToLower().Contains(materia.ToLower()))
                .ToList();
        }
    }
}
