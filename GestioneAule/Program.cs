using GestioneAule.Models;
using GestioneAule.Services;

GestoreAule gestore = new GestoreAule();
int scelta;

do
{
    Console.WriteLine("\n--- GESTIONE AULE STUDIO ---");

    Prenotazione ultima = gestore.OttieniUltimaPrenotazione();
    if (ultima != null)
    {
        Console.WriteLine("Ultima prenotazione inserita:");
        Console.WriteLine(ultima);
    }
    else
    {
        Console.WriteLine("Nessuna prenotazione presente.");
    }

    Console.WriteLine("\n1. Aggiungi aula");
    Console.WriteLine("2. Mostra aule");
    Console.WriteLine("3. Prenota aula");
    Console.WriteLine("4. Mostra prenotazioni");
    Console.WriteLine("5. Ricerca prenotazione");
    Console.WriteLine("0. Esci");
    Console.Write("Scelta: ");

    if (!int.TryParse(Console.ReadLine(), out scelta))
    {
        Console.WriteLine("Inserisci un numero valido.");
        continue;
    }

    switch (scelta)
    {
        case 1:
            Console.Write("ID aula: ");
            int idAula = int.Parse(Console.ReadLine());

            Console.Write("Nome aula: ");
            string nomeAula = Console.ReadLine();

            Console.Write("Capienza: ");
            int capienza = int.Parse(Console.ReadLine());

            gestore.AggiungiAula(new Aula(idAula, nomeAula, capienza));
            Console.WriteLine("Aula aggiunta con successo.");
            break;

        case 2:
            Console.WriteLine("\n--- ELENCO AULE ---");
            gestore.MostraAule();
            break;

        case 3:
            Console.Write("ID prenotazione: ");
            int idPrenotazione = int.Parse(Console.ReadLine());

            Console.Write("Nome studente: ");
            string nomeStudente = Console.ReadLine();

            Console.Write("Materia: ");
            string materia = Console.ReadLine();

            Console.Write("ID aula da prenotare: ");
            int aulaId = int.Parse(Console.ReadLine());

            Console.Write("Data (yyyy-mm-dd): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.Write("Ora inizio (es. 9): ");
            int oraInizio = int.Parse(Console.ReadLine());

            Console.Write("Ora fine (es. 11): ");
            int oraFine = int.Parse(Console.ReadLine());

            Prenotazione prenotazione = new Prenotazione(
                idPrenotazione,
                nomeStudente,
                materia,
                aulaId,
                data,
                oraInizio,
                oraFine
            );

            if (gestore.AggiungiPrenotazione(prenotazione))
                Console.WriteLine("Prenotazione aggiunta con successo.");
            else
                Console.WriteLine("Errore: aula inesistente, orario non valido o aula già occupata.");
            break;

        case 4:
            Console.WriteLine("\n--- ELENCO PRENOTAZIONI ---");
            gestore.MostraPrenotazioni();
            break;

        case 5:
            Console.WriteLine("\n--- RICERCA PRENOTAZIONE ---");
            Console.WriteLine("1. Cerca per ID");
            Console.WriteLine("2. Cerca per nome studente");
            Console.WriteLine("3. Cerca per materia");
            Console.Write("Scelta: ");

            int sceltaRicerca = int.Parse(Console.ReadLine());

            switch (sceltaRicerca)
            {
                case 1:
                    Console.Write("Inserisci ID prenotazione: ");
                    int idRicerca = int.Parse(Console.ReadLine());

                    Prenotazione trovata = gestore.CercaPrenotazionePerId(idRicerca);
                    if (trovata != null)
                        Console.WriteLine(trovata);
                    else
                        Console.WriteLine("Nessuna prenotazione trovata.");
                    break;

                case 2:
                    Console.Write("Inserisci nome studente: ");
                    string studenteRicerca = Console.ReadLine();

                    List<Prenotazione> risultatiStudente = gestore.CercaPrenotazioniPerStudente(studenteRicerca);

                    if (risultatiStudente.Count > 0)
                    {
                        foreach (var p in risultatiStudente)
                            Console.WriteLine(p);
                    }
                    else
                    {
                        Console.WriteLine("Nessuna prenotazione trovata.");
                    }
                    break;

                case 3:
                    Console.Write("Inserisci materia: ");
                    string materiaRicerca = Console.ReadLine();

                    List<Prenotazione> risultatiMateria = gestore.CercaPrenotazioniPerMateria(materiaRicerca);

                    if (risultatiMateria.Count > 0)
                    {
                        foreach (var p in risultatiMateria)
                            Console.WriteLine(p);
                    }
                    else
                    {
                        Console.WriteLine("Nessuna prenotazione trovata.");
                    }
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
            break;

        case 0:
            Console.WriteLine("Uscita dal programma.");
            break;

        default:
            Console.WriteLine("Scelta non valida.");
            break;
    }

} while (scelta != 0);