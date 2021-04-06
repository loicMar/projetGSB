using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGSB_AppliFrais
{
    public abstract class GestionDate
    {

        /**
        * Fonction qui retourn le mois precedent de la date du jour 
        *
        * @return String mois, le mois precedent
        * 
        */
        public static String getMoisPrecedent() {

            DateTime dateJour = DateTime.Now;
            DateTime dateJourSubstract = dateJour.AddMonths(-1);

            return dateJourSubstract.ToString("MM");
        }

        /**
         * Fonction qui retourn le mois precedent de la date fournbie en parametre 
         * 
         * @param DateTime date, la date fournie en parametre
         *
         * @return String mois, le mois precedent a la date fournie en paramtere
         * 
         */
        public static String getMoisPrecedent(DateTime date)
        {
            DateTime dateJourSubstract = date.AddMonths(-1);

            return dateJourSubstract.ToString("MM");
        }


        /**
        * Fonction qui retourn le mois suivant de la date du jour 
        *
        * @return String mois, le mois suivant
        * 
        */
        public static String getMoisSuivant()
        {

            DateTime dateJour = DateTime.Now;
            DateTime dateJourSubstract = dateJour.AddMonths(1);

            return dateJourSubstract.ToString("MM");
        }

        /**
        * Fonction qui retourne le mois suivant de la date fournie en parametre 
        * 
        * @param DateTime date, la date fournie en parametre
        *
        * @return String mois, le mois suivant a la date fournie en paramtere
        * 
        */
        public static String getMoisSuivant(DateTime date)
        {
            DateTime dateJourSubstract = date.AddMonths(1);

            return dateJourSubstract.ToString("MM");
        }




    }
}
