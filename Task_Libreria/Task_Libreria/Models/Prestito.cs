using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Libreria.Models
{
    internal class Prestito
    {
        public int PrestitoId { get; set; }
        public DateTime DataInizio { get; set; }
         
        public DateTime DataFine { get; set; }

        public int LibroRif {  get; set; }

        public int UtenteRif { get; set; }


        public Prestito()
        {
        
        }

        public Prestito (int prestitoID, DateTime dataIn, DateTime dataFin, int libroRif, int utenteRif) 
        {
            PrestitoId = prestitoID;
            DataInizio = dataIn;
            DataFine = dataFin;
            LibroRif = libroRif;
            UtenteRif= utenteRif;
        }

    }
}
