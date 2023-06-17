using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Jeux
{
    public static class Modele_Gestionnaire_De_Serie_Mot
    {

        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Permet de récupérer toutes les niveaux de liste
        /// </summary>
        /// <returns></returns>
        public static List<string> recupereToutesLesListes()
        {
            List<string> lstToutesLists = new List<string>();

            string req = "SELECT nom_liste FROM niveaudelistes;";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {                
                string nomListe = ((string)curs.Field("nom_liste"));

                lstToutesLists.Add(nomListe);
            }

            curs.Close();

            return lstToutesLists;
        }
    }
}
