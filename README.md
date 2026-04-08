<h1 align="center">Gestione Aule Studio</h1>

<p align="center">
  Applicazione console sviluppata in <b>C#</b> per la prenotazione di aule studio universitarie,
  con controllo automatico delle sovrapposizioni di orario.
</p>

<hr>

<h2>Descrizione del progetto</h2>

<p>
  Questo progetto è un'applicazione console sviluppata in <b>C#</b> che permette agli studenti universitari
  di <b>prenotare un’aula studio</b> indicando il <b>giorno</b> e la <b>fascia oraria</b> desiderata.
</p>

<p>
  Il sistema controlla automaticamente che <b>non ci siano sovrapposizioni di prenotazione</b>
  nella stessa aula, nello stesso giorno e nella stessa fascia oraria.
</p>

<h2>Obiettivo</h2>

<p>
  L'obiettivo del progetto è simulare un semplice sistema di gestione delle aule studio universitarie,
  applicando i principi base della <b>programmazione orientata agli oggetti</b>.
</p>

<h2>Ambiente di sviluppo</h2>

<ul>
  <li><b>Visual Studio Community 2022</b></li>
  <li><b>C#</b></li>
  <li><b>.NET</b></li>
  <li>Applicazione <b>Console</b></li>
</ul>

<h2>Funzionalità principali</h2>

<ul>
  <li>Aggiungere un’aula</li>
  <li>Visualizzare l’elenco delle aule</li>
  <li>Prenotare un’aula studio</li>
  <li>Visualizzare tutte le prenotazioni</li>
  <li>Evitare sovrapposizioni di orario nella stessa aula</li>
</ul>

<h2>Struttura del progetto</h2>

<pre><code>GestioneAule/
├── Program.cs
├── Models/
│   ├── Aula.cs
│   └── Prenotazione.cs
├── Services/
│   └── GestoreAule.cs
├── GestioneAule.csproj
├── GestioneAule.sln
└── README.md
</code></pre>

<h2>Classi principali</h2>

<h3>Aula</h3>
<p>Rappresenta un’aula studio disponibile per la prenotazione.</p>

<p><b>Attributi principali:</b></p>
<ul>
  <li><code>Id</code></li>
  <li><code>Nome</code></li>
  <li><code>Capienza</code></li>
</ul>

<h3>Prenotazione</h3>
<p>Rappresenta una prenotazione effettuata da uno studente.</p>

<p><b>Attributi principali:</b></p>
<ul>
  <li><code>Id</code></li>
  <li><code>NomeStudente</code></li>
  <li><code>AulaId</code></li>
  <li><code>Data</code></li>
  <li><code>OraInizio</code></li>
  <li><code>OraFine</code></li>
</ul>

<h3>GestoreAule</h3>
<p>Gestisce la logica del programma, in particolare:</p>

<ul>
  <li>Aggiunta delle aule</li>
  <li>Visualizzazione delle aule</li>
  <li>Inserimento delle prenotazioni</li>
  <li>Controllo della disponibilità</li>
  <li>Verifica delle sovrapposizioni</li>
  <li>Visualizzazione delle prenotazioni</li>
</ul>

<h2>Logica di funzionamento</h2>

<p>Quando uno studente prova a prenotare un’aula, il sistema verifica che:</p>

<ol>
  <li>L’aula esista</li>
  <li>L’orario inserito sia valido</li>
  <li>Non esista già una prenotazione nella stessa aula, nello stesso giorno, con fascia oraria sovrapposta</li>
</ol>

<p>
  Se una prenotazione entra in conflitto con un’altra già presente, il sistema la rifiuta.
</p>

<h2>Concetti di programmazione utilizzati</h2>

<ul>
  <li>Classi e oggetti</li>
  <li>Incapsulamento</li>
  <li>Separazione tra modello e logica</li>
  <li>Uso di liste di oggetti</li>
  <li>Organizzazione del codice in cartelle (<code>Models</code> e <code>Services</code>)</li>
</ul>

<h2>Requisiti per l’installazione</h2>

<ul>
  <li>Windows</li>
  <li><b>Visual Studio Community 2022</b></li>
  <li>Supporto per lo sviluppo <b>.NET desktop</b> oppure <b>.NET</b></li>
  <li>SDK .NET installato correttamente</li>
</ul>

<h2>Installazione del progetto</h2>

<h3>Metodo 1: clonare da GitHub</h3>

<p>Aprire il terminale o Git Bash e scrivere:</p>

<pre><code>git clone URL_DEL_TUO_REPOSITORY
</code></pre>

<p>Poi entrare nella cartella del progetto:</p>

<pre><code>cd GestioneAule
</code></pre>

<p>
  Dopo il clone, puoi aprire il progetto in <b>Visual Studio Community 2022</b>
  facendo doppio clic sul file:
</p>

<pre><code>GestioneAule.sln
</code></pre>

<h3>Metodo 2: download ZIP</h3>

<ol>
  <li>Aprire il repository su GitHub</li>
  <li>Cliccare su <b>Code</b></li>
  <li>Cliccare su <b>Download ZIP</b></li>
  <li>Estrarre la cartella</li>
  <li>Aprire <code>GestioneAule.sln</code> con Visual Studio Community 2022</li>
</ol>

<h2>Guida al clone del repository</h2>

<ol>
  <li>Copiare il link del repository da GitHub</li>
  <li>Aprire Git Bash oppure il terminale</li>
  <li>Eseguire il comando:</li>
</ol>

<pre><code>git clone URL_DEL_TUO_REPOSITORY
</code></pre>

<ol start="4">
  <li>Entrare nella cartella del progetto:</li>
</ol>

<pre><code>cd GestioneAule
</code></pre>

<ol start="5">
  <li>Aprire il file <code>.sln</code> con Visual Studio Community 2022</li>
</ol>

<h2>Come avviare il progetto in Visual Studio Community 2022</h2>

<ol>
  <li>Aprire <b>Visual Studio Community 2022</b></li>
  <li>Selezionare <b>Apri un progetto o una soluzione</b></li>
  <li>Scegliere il file <code>GestioneAule.sln</code></li>
  <li>Attendere il caricamento del progetto</li>
  <li>Premere <b>F5</b> oppure il pulsante <b>Avvia</b></li>
</ol>

<p>Il programma verrà eseguito nella console.</p>

<h2>Come avviare il progetto da terminale</h2>

<p>Se vuoi eseguirlo da terminale, posizionati nella cartella del progetto e usa:</p>

<pre><code>dotnet run
</code></pre>

<h2>Menu del programma</h2>

<ul>
  <li><code>1</code> - Aggiungi aula</li>
  <li><code>2</code> - Mostra aule</li>
  <li><code>3</code> - Prenota aula</li>
  <li><code>4</code> - Mostra prenotazioni</li>
  <li><code>0</code> - Esci</li>
</ul>

<h2>Esempio di utilizzo</h2>

<p>Esempio di flusso del programma:</p>

<ol>
  <li>Inserimento di un’aula</li>
  <li>Visualizzazione delle aule disponibili</li>
  <li>Inserimento di una prenotazione con:
    <ul>
      <li>Nome studente</li>
      <li>ID aula</li>
      <li>Data</li>
      <li>Ora inizio</li>
      <li>Ora fine</li>
    </ul>
  </li>
  <li>Controllo automatico della disponibilità</li>
  <li>Visualizzazione delle prenotazioni registrate</li>
</ol>

<h2>Esempio di caso valido</h2>

<ul>
  <li><b>Aula ID:</b> <code>1</code></li>
  <li><b>Data:</b> <code>2026-04-10</code></li>
  <li><b>Ora inizio:</b> <code>9</code></li>
  <li><b>Ora fine:</b> <code>11</code></li>
</ul>

<p>La prenotazione viene accettata se l’aula è libera.</p>

<h2>Esempio di sovrapposizione</h2>

<p>
  Se esiste già una prenotazione per l’aula <code>1</code> il giorno <code>2026-04-10</code>
  dalle <code>9</code> alle <code>11</code>, una nuova prenotazione dalle <code>10</code> alle <code>12</code>
  viene rifiutata perché si sovrappone.
</p>

<h2>File da non caricare su GitHub</h2>

<p>
  Nel progetto è presente un file <code>.gitignore</code> per evitare di caricare file temporanei
  o generati automaticamente, come:
</p>

<ul>
  <li><code>.vs/</code></li>
  <li><code>bin/</code></li>
  <li><code>obj/</code></li>
</ul>

<h2>Possibili miglioramenti futuri</h2>

<ul>
  <li>Controllo più avanzato degli input</li>
  <li>Eliminazione di una prenotazione</li>
  <li>Ricerca delle aule disponibili per data e orario</li>
  <li>Salvataggio dei dati su file</li>
  <li>Gestione di più studenti con matricola</li>
</ul>

<h2>Autori</h2>

<p>
  Progetto realizzato per scopo didattico nell’ambito dello studio di <b>C#</b>
  e della <b>programmazione orientata agli oggetti</b>.
</p>



