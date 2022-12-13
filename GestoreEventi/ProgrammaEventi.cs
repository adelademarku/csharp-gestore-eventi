using System;
using System.Collections.Generic;
using System.Linq;
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






    }
}
