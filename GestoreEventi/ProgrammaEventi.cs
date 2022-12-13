using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi : Evento
    {
        //Attributi
        private string titolo;
        private List<Evento> evento;
        //Costruttore
        public ProgrammaEventi(string titolo,List<Evento>evento, string data, int capienzaMassimaEvento, int postiPrenotati) :base(titolo, data, capienzaMassimaEvento, postiPrenotati)
        {
            this.titolo = titolo;
            this.evento = evento;
        }

        //Getter

        public string GetTitoloProgrammaEventi()
        {
            return titolo;
        }
        public List<Evento> GetEventoList()
        {
            return evento;
        }

        //Metodi 

        //aggiunge alla lista del programma eventi un Evento, passato come  parametro al metodo

        public void AggiungiEvento(Evento eventoAggiunto)
        {
            evento.Add(eventoAggiunto);
        }

        // restituisce una lista di eventi con tutti gli eventi presenti in una certa data

        public void StampaEeventiDiDataComune(DateTime data)
        {
            List<Evento> ListaPerData = new List<Evento>();
            foreach (Evento EventoinData in evento)
            {
                if (EventoinData.GetData()== data.ToShortDateString())
                {
                    ListaPerData.Add(EventoinData);
                }
            }
             
        }

        //un metodo che svuota la lista di eventi.

        public void EliminaLista()
        {
            evento.Clear();
        }


        //quanti eventi sono presenti nel programma eventi attualmente.

        public void NumeroEventi()
        {
            evento.Count();
        } 



        //metodo statico che stampa in console
        public static void StampainConsole(IEnumerable evento)
        {
            foreach (object o in evento)
            {
                Console.WriteLine(o);
            }
        }


        //stampamostra il titolo del programma e tutti gli eventi aggiunti alla lista.

        public override string ToString()
        {
            string Evento = "\n---------- "
                + this.titolo
                + " ----------\n\ndata: "
                + this.GetData

                + "mq\n";
            return Evento;
        }


    }
}
