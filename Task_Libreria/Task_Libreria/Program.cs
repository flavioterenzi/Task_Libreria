using Task_Libreria.Dal;
using Task_Libreria.Models;

namespace Task_Libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utente utente = new Utente()
            {
                Nome="Mario",
                Cognome="Rossi",
                Email="Mario@Rossi.it"
            };
            Console.WriteLine(UtenteDal.getIstanza().insert(utente) ? "Stappo!" : "Errore");
        }
    }
}
