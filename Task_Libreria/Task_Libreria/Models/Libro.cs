using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Libreria.Models
{
    internal class Libro
    {
        public int LibroID { get; set; }
        public string? Titolo { get; set;}
        public DateTime AnnoPub { get;}
        public bool StatoDisp { get; set; }


        public Libro () 
        { 

        }

        public Libro(int libroID,string titolo, DateTime annopub, bool statoDisp)
        {
            LibroID = libroID;
            Titolo = titolo;
            AnnoPub = annopub;
            StatoDisp = statoDisp;

        }


    }
}
