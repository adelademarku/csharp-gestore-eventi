using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        //ATTRIBUTI 
        private string titolo;
        private string data;
        private int capienzaMassimaEvento;
        private int postiPrenotati;

        //Costruttore
        public Evento(string titolo, string data, int capienzaMassimaEvento, int postiPrenotati)
        {
            if (titolo == " ")
            { 
                throw new Exception("il titolo non puo essere omésso!");
            }

            this.titolo = titolo;
            this.data = data;
            this.capienzaMassimaEvento = capienzaMassimaEvento;
            this.postiPrenotati = postiPrenotati;
            
        }

        //GETTERS

        public string GetTitolo()
        {
            return titolo;
        }
        public string GetData()
        {
            return data;
        }
        public int GetCapienzaMassimaEvento()
        {
            return capienzaMassimaEvento;
        }
        public int GetPostiPrenotati()
        {
            return postiPrenotati;
        }

        //SETTERS

        public string SetTitolo()
        {
            if (titolo != "")
            {
                return titolo;

            }   else
            {
                throw new Exception("il titolo non puo essere omésso!");
            } 
        }

        //controllo se la data non è passata 
        public void SetData()
        {
            DateTime dataOraAttuale = DateTime.Now;
            DateTime dataInserita = DateTime.Parse(data);
            TimeSpan intervalloDiTempo = dataInserita - dataOraAttuale;

            if (dataInserita < dataOraAttuale)
            {
                Console.WriteLine("La data inserita è nel passato!");
                Console.WriteLine("In particolare la tua data sta " + intervalloDiTempo.Days + " giorni passati!");
            
            }

        }

        public int SetPostiPrenotati()
        { 
                return postiPrenotati = 0;
            
        }



        //controllo se la capienza massima di posti sia un numero positivo

        public int SetCapienzaMasssimaEvento()
        {
            if (capienzaMassimaEvento >= 0)
            {
                return capienzaMassimaEvento;
            } else
            {
                throw new Exception("la capacita massima non puo essere un numero negativo!");
            }
        }

        //Mettodi 

        //PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati.
        //Se l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevar un’eccezione.

        public int PrenotaPosti(int posti)
        {
            if (postiPrenotati == capienzaMassimaEvento)
            {
                Console.WriteLine("Sold out!");
                return capienzaMassimaEvento;

            }
            else if (postiPrenotati + posti < capienzaMassimaEvento)
            {
                Console.WriteLine("Numero dei posti prenotati: " + (this.postiPrenotati + posti) );
                int postiAncoraDisponibili = this.capienzaMassimaEvento - (this.postiPrenotati + posti);
                Console.WriteLine("Sono disponibili " + postiAncoraDisponibili + "posti");
                return postiAncoraDisponibili;
                
            }
            else if (postiPrenotati + posti > capienzaMassimaEvento)
            {
                throw new Exception("Stai prenotanto posti non disponibili!");
            }
            else return this.postiPrenotati;
        }

        //. DisdiciPosti: riduce del i posti prenotati del numero di posti indicati come parametro.
        //Se l’evento è già passato o non ci sono i posti da disdire sufficienti, deve sollevare un’eccezione.

        public int DisdiciPosti(int posti)
        {
            if (postiPrenotati - posti < capienzaMassimaEvento)
            {

                throw new Exception("non puoi disdire posti non prenotati!");
            }
            else
            {
                Console.WriteLine("Numero dei posti prenotati: " + (this.postiPrenotati - posti));
                int postiAncoraDisponibili = this.capienzaMassimaEvento - (this.postiPrenotati - posti);
                Console.WriteLine("Sono disponibili " + postiAncoraDisponibili + "posti");
                return this.postiPrenotati - posti;
            }
        }



        //stampa

        public override string ToString()
        {
            return "titolo" + this.titolo+ "\tdata: " + data+ "\t capienza massima evento: "+ this.capienzaMassimaEvento + "\tnumero dei posti prenotati:  "+ this.postiPrenotati;
        }




        public void StampaEvento()
        {
            Console.WriteLine(" ----------" + titolo+ " ----------");
            Console.WriteLine("Data: \t" + data);
            Console.WriteLine("Capacita Massima: \t" + capienzaMassimaEvento);
            Console.WriteLine("Posti prenotati: \t" + this.postiPrenotati);
         

        }




    }
}
