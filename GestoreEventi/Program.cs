// See https://aka.ms/new-console-template for more information
using GestoreEventi;

Console.WriteLine("Hello, World!");

Console.WriteLine("Inserisci il nome del evento: ");
string nomeEvento = Console.ReadLine();
Console.WriteLine("Inserisci la data del evento (gg/mm/yyyy): ");
string dataEvento = Console.ReadLine();
Console.WriteLine("Inserisci il numero dei posti totali: ");
int capacitaMassimaEvento = Int16.Parse(Console.ReadLine());
Console.WriteLine("Quanti posti desideri prenotare?: ");
int postiPrenotati = Int16.Parse(Console.ReadLine());

Evento evento = new Evento(nomeEvento, dataEvento, capacitaMassimaEvento, postiPrenotati);

evento.StampaEvento();



bool continueAsking = true;

Console.WriteLine("Vuoi disdire dei posti (si/no) ? ");
continueAsking = Console.ReadLine() == "si";


while (continueAsking)
{
    Console.WriteLine("Indica il numero dei posti da disdire: ");
    int numeriPostiDisdetti = Int16.Parse(Console.ReadLine());
    evento.DisdiciPosti(numeriPostiDisdetti);
    evento.StampaEvento();
    /*Console.WriteLine("Numero posti prenotati = " + postiPrenotati);
    Console.WriteLine("Numero dei posti disdetti =  " + numeriPostiDisdetti);
    Console.WriteLine("Numero dei posti disponibili =  " + (capacitaMassimaEvento - (postiPrenotati - numeriPostiDisdetti))); */

    Console.WriteLine("Vuoi disdire dei posti (si/no) ? ");
    continueAsking = Console.ReadLine() == "si";
}
if (Console.ReadLine() == "no"){
    Console.WriteLine("Ok. va bene");
}



List<Evento> eventiLista = new List<Evento>() ;

eventiLista.Add(evento);

Console.WriteLine("Inserisci il nome del tuo programma Eventi: ");
string nomeProgrammaEvento = Console.ReadLine();
Console.WriteLine("Indica il numero degli eventi da inserire: ");
int numeroEventiDaAggiungere = Int16.Parse(Console.ReadLine());

ProgrammaEventi evento0 = new ProgrammaEventi(nomeProgrammaEvento,eventiLista, dataEvento, capacitaMassimaEvento, postiPrenotati);


evento0.StampaEvento();




