using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace projetGSB_AppliFrais

{
    class Program
    {


        static void Main(string[] args)
        {

            string sql = "SELECT idVisiteur as idVisiteur, mois as mois FROM fichefrais WHERE idVisiteur = 'b13'";
            String[] listeColonne = { "idVisiteur", "mois" };
            DBUtils.selectQuery(sql, listeColonne);

            sql = "INSERT INTO etat VALUES ('TE', 'TEST')";
            DBUtils.addUpdateDeleteQuery(sql);

        }


      


    }
}
