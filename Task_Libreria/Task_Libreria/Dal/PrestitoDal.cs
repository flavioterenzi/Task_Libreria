using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Libreria.Models;
using Task_Libreria.Utilities;

namespace Task_Libreria.Dal
{
    internal class PrestitoDal : Idal<Prestito>
    {
        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prestito> findAll()
        {
            throw new NotImplementedException();
        }

        public Prestito findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Prestito t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Utente(dataInizio, dataFine, libroRif,utenteRif) VALUES (@dataInizio, @dataFine, @libroRif, @utenteRif)";
                sqlCommand.Parameters.AddWithValue("@nome", t.DataInizio);
                sqlCommand.Parameters.AddWithValue("@cognome", t.DataFine);
                sqlCommand.Parameters.AddWithValue("@email", t.LibroRif);
                sqlCommand.Parameters.AddWithValue("@email", t.UtenteRif);


                try
                {
                    con.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0)
                        risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return risultato;
        }

        public bool update(Prestito t)
        {
            throw new NotImplementedException();
        }
    }
}
