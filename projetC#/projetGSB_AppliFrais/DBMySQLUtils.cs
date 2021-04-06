using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projetGSB_AppliFrais
{
    class DBMySQLUtils
    {
        /**
        * Fonction de connexion a la base de donnee
        *
        * @param String host
        * @param String port
        * @param String database
        * @param String username
        * @param String password
        * 
        * @return MySqlConnection la connexion sql
        * 
        */
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

    }
}
