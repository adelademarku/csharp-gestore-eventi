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


        public int GetPostiDisponibili()
        {
            int postiAncoraDisponibili = this.capienzaMassimaEvento - this.postiPrenotati;
            return postiAncoraDisponibili;
        }


        //SETTERS

        public void SetTitolo(string titolo)
        {
            if (titolo != "")
            {
                this.titolo = titolo;


            }   else
            {
                throw new Exception("il titolo non puo essere omésso!");
            }

        
        }

        //controllo se la data non è passata 
        public void SetData(string data)
        {
            DateTime dataOraAttuale = DateTime.Now;
            DateTime dataInserita = DateTime.Parse(data);
            TimeSpan intervalloDiTempo = dataInserita - dataOraAttuale;

            if (dataInserita < dataOraAttuale)
            {
                Console.WriteLine("La data inserita è nel passato!");
                Console.WriteLine("In particolare la tua data sta " + intervalloDiTempo.Days + " giorni passati!");
            
            } else
            {
                this.data = data;
            }
            

        }

        public void SetPostiPrenotati(int numero)
        {
            postiPrenotati = numero ;
            
        }



        //controllo se la capienza massima di posti sia un numero positivo

        public void SetCapienzaMasssimaEvento(int capienzaMassimaEvento)
        {
            if (capienzaMassimaEvento >= 0)
            {
                this.capienzaMassimaEvento = capienzaMassimaEvento;
            } else
            {
                throw new Exception("la capacita massima non puo essere un numero negativo!");
            }

            
        }

        //Mettodi 

        //PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati.
        //Se l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevar un’eccezione.

        public void PrenotaPosti(int posti)
        {
            if (postiPrenotati == capienzaMassimaEvento)
            {
                Console.WriteLine("Sold out!");

            }
            else if (postiPrenotati + posti < capienzaMassimaEvento)
            {
                Console.WriteLine("Numero dei posti prenotati: " + (this.postiPrenotati + posti) );

                this.postiPrenotati = postiPrenotati +posti;
                int postiAncoraDisponibili = this.capienzaMassimaEvento - (this.postiPrenotati + posti);
                Console.WriteLine("Sono disponibili " + postiAncoraDisponibili + "posti");
                
                
            }
            else if (postiPrenotati + posti > capienzaMassimaEvento)
            {
                throw new Exception("Stai prenotanto posti non disponibili!");
            }
             
        }

        //. DisdiciPosti: riduce del i posti prenotati del numero di posti indicati come parametro.
        //Se l’evento è già passato o non ci sono i posti da disdire sufficienti, deve sollevare un’eccezione.

        public void DisdiciPosti(int posti)
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
                this.postiPrenotati = this.postiPrenotati - posti;
            }
        }



        //stampa


        public override string ToString()
        {
            string EventoStringa = "\n---------- "
                + this.titolo
                + " ----------\n\ndata: "
                + this.data
                + "\ncapienza massima evento: "
                + this.capienzaMassimaEvento
                + "\nnumero posti prenotati: "
                + this.postiPrenotati 
                
                + "mq\n";
            return EventoStringa;
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
