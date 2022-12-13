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

evento.GetPostiPrenotati();
evento.GetCapienzaMassimaEvento();

Console.WriteLine("Vuoi disdire dei posti (si/no) ? ");
if (Console.ReadLine()== "si")
{
    Console.WriteLine("Indica il numero dei posti da disdire: ");
    int numeriPostiDisdetti = Int16.Parse(Console.ReadLine());
    evento.DisdiciPosti(numeriPostiDisdetti);
    Console.WriteLine("Numero posti prenotati:" + postiPrenotati);
    Console.WriteLine("Numero dei posti disdetti " +numeriPostiDisdetti);
    Console.WriteLine("Numero dei posti disponibili " + (capacitaMassimaEvento - (postiPrenotati-numeriPostiDisdetti)));


} else if (Console.ReadLine() == "no")
{
    Console.WriteLine("Ok. va bene");
}





