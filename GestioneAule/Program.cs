using GestioneAule.Models;


Aula aula1 = new Aula(1, "Aula Informatica", 25);
Prenotazione pren1 = new Prenotazione(1, "Informatica", "Prof. Rossi", 1, new DateTime(2026, 4, 10), 9, 11);

Console.WriteLine(aula1);
Console.WriteLine(pren1);