using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace projetGSB_AppliFrais

{
    public abstract class Program
    {


        public static void Main()
        {

            DateTime dateJour = DateTime.Now;

            // Verification qu'on se trouve au debut du mois
            if (Int32.Parse(dateJour.ToString("dd")) <= 10)
            {
                // On enlve 1 an si on recupere le mois de l'annee precedente
                String mois = GestionDate.getMoisPrecedent(dateJour);
                String annee = "";

                // On recupere l'annee
                if (mois == "12")
                {
                    annee = DateTime.Now.AddYears(-1).ToString("yyyy");

                } else {
                    annee = DateTime.Now.ToString("yyyy");
                }

                // on met à jour la base de données
                string sql = "UPDATE fichefrais SET idEtat = 'CL', datemodif ='"+ dateJour.ToString("yyyy-MM-dd")+"' WHERE mois='" + annee + mois+ "' AND idetat='CR'";
                DBUtils.addUpdateDeleteQuery(sql);
            }

            // Verification qu'on se trouve apres le 20 du moins
            if (Int32.Parse(DateTime.Now.ToString("dd")) >= 20)
            {
                String mois = GestionDate.getMoisPrecedent(dateJour);
                String annee = "";

                // On recupere l'annee
                if (mois == "12")
                {
                    annee = DateTime.Now.AddYears(-1).ToString("yyyy");
                } else {
                    annee = DateTime.Now.ToString("yyyy");

                }

                // on met à jour la base de données
                string sql = "UPDATE fichefrais SET idEtat = 'RB', datemodif ='" + dateJour.ToString("yyyy-MM-dd") + "' WHERE mois='" + annee + mois + "' AND idetat='VA'";

                DBUtils.addUpdateDeleteQuery(sql);
            }


        }

    }
}
