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
    internal class UtenteDal : Idal<Utente>
    {
        private static UtenteDal? istanza;

        public static UtenteDal getIstanza()
        {
            if (istanza == null)
                istanza = new UtenteDal();

            return istanza;
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Utente> findAll()
        {
            throw new NotImplementedException();
        }



        //---------------------------------
        public Utente findById(int id)
        {
            throw new NotImplementedException();
        }


        //----------------------------------------------------
        public bool insert(Utente t)
        {
            bool risultato = false;

            using(SqlConnection con= new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Utente(nome, cognome, email) VALUES (@nome, @cognome, @email)";
                sqlCommand.Parameters.AddWithValue("@nome", t.Nome);
                sqlCommand.Parameters.AddWithValue("@cognome", t.Cognome);
                sqlCommand.Parameters.AddWithValue("@email", t.Email);

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

    

        public bool Update(Utente t)
        {
            throw new NotImplementedException();
        }

        public bool update(Utente t)
        {
            throw new NotImplementedException();
        }
    }
}


  

