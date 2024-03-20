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
    internal class LibroDal : Idal<Libro>
    {
        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Libro> findAll()
        {
            throw new NotImplementedException();
        }

        public Libro findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Libro t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Utente(titolo, AnnoPub, statoDisp) VALUES (@titolo, @AnnoPub, @statoDisp)";
                sqlCommand.Parameters.AddWithValue("@nome", t.Titolo);
                sqlCommand.Parameters.AddWithValue("@cognome", t.AnnoPub);
                sqlCommand.Parameters.AddWithValue("@email", t.StatoDisp);

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

        public bool update(Libro t)
        {
            throw new NotImplementedException();
        }
    }
}
