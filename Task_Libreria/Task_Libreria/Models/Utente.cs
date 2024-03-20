using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Libreria.Models
{
    internal class Utente
    {
        public int UtenteId {  get; set; }
        public string? Nome { get; set;}
        public string? Cognome { get; set;}
        public string? Email { get; set;}



        public Utente () 
        { 

        }
        public Utente(int utenteID, string? nome, string cognome, string? email) { 

            UtenteId = utenteID;
            Nome = nome;
            Cognome = cognome;
            Email = email;
        }


    }
}
