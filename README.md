# Gestione Aule Studio

## Descrizione del progetto
Questo progetto è un'applicazione console sviluppata in **C#** che permette agli studenti universitari di **prenotare un’aula studio** indicando il **giorno** e la **fascia oraria** desiderata.

Il sistema controlla automaticamente che **non ci siano sovrapposizioni di prenotazione** nella stessa aula, nello stesso giorno e nella stessa fascia oraria.

## Obiettivo
L'obiettivo del progetto è simulare un semplice sistema di gestione delle aule studio universitarie, applicando i principi base della **programmazione orientata agli oggetti**.

## Ambiente di sviluppo
Il progetto è stato sviluppato usando:

- **Visual Studio Community 2022**
- **C#**
- **.NET**
- Applicazione **Console**

## Funzionalità principali
Il programma permette di:

- aggiungere un’aula
- visualizzare l’elenco delle aule
- prenotare un’aula studio
- visualizzare tutte le prenotazioni
- evitare sovrapposizioni di orario nella stessa aula

## Struttura del progetto
Il progetto è organizzato in modo semplice e chiaro:

```text
GestioneAule/
├── Program.cs
├── Models/
│   ├── Aula.cs
│   └── Prenotazione.cs
├── Services/
│   └── GestoreAule.cs
├── GestioneAule.csproj
├── GestioneAule.sln
└── README.md


Classi principali
Aula

Rappresenta un’aula studio disponibile per la prenotazione.

Attributi principali:

Id
Nome
Capienza
Prenotazione

Rappresenta una prenotazione effettuata da uno studente.

Attributi principali:

Id
NomeStudente
AulaId
Data
OraInizio
OraFine
GestoreAule

Gestisce la logica del programma, in particolare:

aggiunta delle aule
visualizzazione delle aule
inserimento delle prenotazioni
controllo della disponibilità
verifica delle sovrapposizioni
visualizzazione delle prenotazioni
Logica di funzionamento

Quando uno studente prova a prenotare un’aula, il sistema verifica che:

l’aula esista
l’orario inserito sia valido
non esista già una prenotazione nella stessa aula, nello stesso giorno, con fascia oraria sovrapposta

Se una prenotazione entra in conflitto con un’altra già presente, il sistema la rifiuta.

Concetti di programmazione utilizzati

Nel progetto sono stati applicati alcuni concetti fondamentali della programmazione orientata agli oggetti:

classi e oggetti
incapsulamento
separazione tra modello e logica
uso di liste di oggetti
organizzazione del codice in cartelle (Models e Services)
Requisiti per l'installazione

Per eseguire il progetto è consigliato avere:

Windows
Visual Studio Community 2022
supporto per lo sviluppo .NET desktop oppure .NET
SDK .NET installato correttamente
Installazione del progetto
Metodo 1: clonare da GitHub

Aprire il terminale o Git Bash e scrivere:

git clone URL_DEL_TUO_REPOSITORY

Poi entrare nella cartella del progetto:

cd GestioneAule

Dopo il clone, puoi aprire il progetto in Visual Studio Community 2022 facendo doppio clic sul file:

GestioneAule.sln
Metodo 2: download ZIP

In alternativa:

aprire il repository su GitHub
cliccare su Code
cliccare su Download ZIP
estrarre la cartella
aprire GestioneAule.sln con Visual Studio Community 2022
Guida al clone del repository

Per scaricare il progetto dal repository remoto:

copiare il link del repository da GitHub
aprire Git Bash oppure il terminale
eseguire il comando:
git clone URL_DEL_TUO_REPOSITORY
entrare nella cartella del progetto:
cd GestioneAule
aprire il file .sln con Visual Studio Community 2022
Come avviare il progetto in Visual Studio Community 2022
aprire Visual Studio Community 2022
selezionare Apri un progetto o una soluzione
scegliere il file GestioneAule.sln
attendere il caricamento del progetto
premere F5 oppure il pulsante Avvia

Il programma verrà eseguito nella console.

Come avviare il progetto da terminale

Se vuoi eseguirlo da terminale, posizionati nella cartella del progetto e usa:

bash:
dotnet run


Menu del programma

Il menu principale offre le seguenti opzioni:

1 Aggiungi aula
2 Mostra aule
3 Prenota aula
4 Mostra prenotazioni
0 Esci
Esempio di utilizzo

Esempio di flusso del programma:

inserimento di un’aula
visualizzazione delle aule disponibili
inserimento di una prenotazione con:
nome studente
id aula
data
ora inizio
ora fine
controllo automatico della disponibilità
visualizzazione delle prenotazioni registrate
Esempio di caso valido
Aula ID: 1
Data: 2026-04-10
Ora inizio: 9
Ora fine: 11

La prenotazione viene accettata se l’aula è libera.

Esempio di sovrapposizione

Se esiste già una prenotazione per l’aula 1 il giorno 2026-04-10 dalle 9 alle 11, una nuova prenotazione dalle 10 alle 12 viene rifiutata perché si sovrappone.

File da non caricare su GitHub

Nel progetto è presente un file .gitignore per evitare di caricare file temporanei o generati automaticamente, come:

.vs/
bin/
obj/
Possibili miglioramenti futuri

Il progetto può essere esteso con funzionalità aggiuntive, ad esempio:

controllo più avanzato degli input
eliminazione di una prenotazione
ricerca delle aule disponibili per data e orario
salvataggio dei dati su file
gestione di più studenti con matricola
Autori

Progetto realizzato per scopo didattico nell’ambito dello studio di C# e della programmazione orientata agli oggetti.



