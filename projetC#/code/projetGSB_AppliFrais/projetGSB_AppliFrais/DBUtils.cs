using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projetGSB_AppliFrais
{

    class DBUtils
    {

        public static MySqlConnection  GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "gsb_frais";
            string username = "root";
            string password = "";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }


        /**
        * Fonction statique qui execute une requete insert, update ou delete
        *
        * @param String slq le sql a executer 
        */
        public static void addUpdateDeleteQuery(string sql)
        {


            try
            {
                MySqlConnection conn = DBUtils.GetDBConnection(); ;
                conn.Open();

                // Creation d'un objet Command.
                MySqlCommand cmd = new MySqlCommand();

                // connexion de la commande.
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Execution de la commande
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Nombre de rows affectées = " + rowCount);
              

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }


 

        }


        /**
       * Fonction statique qui execute une requete select
       *
       * @param String slq le sql a executer 
       * @param String[] listeCOlonne , la liste des colonnes à recuperer 
       * 
       */
        public static void selectQuery(string sql, string[] listeColonne)
        {
            try
            {

                MySqlConnection conn = DBUtils.GetDBConnection(); ;
                conn.Open();

                // Creation d'un objet Command.
                MySqlCommand cmd = new MySqlCommand();

                // connexion de la commande.
                cmd.Connection = conn;
                cmd.CommandText = sql;

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            foreach (string colonne in listeColonne)
                            {

                                // Récupération de la colonne
                                int indexColonne = reader.GetOrdinal(colonne);

                                // Si une colonne est nullable
                                if (!reader.IsDBNull(indexColonne)) { 
                                    Console.WriteLine(reader.GetValue(indexColonne));
                                    Console.WriteLine("-----------------------------");
                                }
                            }

                        }
                      
                    }
                    
                }
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }

        }

    }
}
