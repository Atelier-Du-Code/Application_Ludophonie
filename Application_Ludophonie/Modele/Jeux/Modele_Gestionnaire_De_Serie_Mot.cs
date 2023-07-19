using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Jeux
{
    /// <summary>
    /// Modèle - Classe d'accès aux données pour le gestionnaire de série - Côté patient
    /// </summary>
    public static class Modele_Gestionnaire_De_Serie_Mot
    {
        /*
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";
        
        
        private static string server = "154.49.245.52";
        private static string userid = "u607780247_testLudo";
        private static string password = "gTyHI2QZez";
        private static string database = "u607780247_testLudo";
        */
        //private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Permet de récupérer toutes les niveaux de liste
        /// </summary>
        /// <returns></returns>
        public static List<string> recupereToutesLesListes()
        {
            List<string> lstToutesLists = new List<string>();

            string req = "SELECT nom_liste FROM niveaudelistes;";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {                
                string nomListe = ((string)curs.Field("nom_liste"));

                lstToutesLists.Add(nomListe);
            }

            curs.Close();

            return lstToutesLists;
        }

        public static List<Mission> recupereToutesMissionsPourUnJeu(int unIdUtilisateur, int idJeu)
        {
            List<Mission> lstToutesMissions = new List<Mission>();

            string req = "SELECT idMission, nbQuestions, valide, jeux.nomJeu " +
                "FROM carnet_de_mission " +
                "INNER JOIN jeux ON jeux.idJeu = carnet_de_mission.idJeu " +
                "WHERE idUtilisateur = @idUtilisateur AND jeux.idJeu = @idJeu AND valide = 0;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                 {"@idUtilisateur", unIdUtilisateur},
                 {"@idJeu", idJeu}
            };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int idMission = ((int)curs.Field("idMission"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestions = ((int)curs.Field("nbQuestions"));
                int missionValidee = ((int)curs.Field("valide"));

                lstToutesMissions.Add(new Mission(idMission, 0, nomJeu, nbQuestions, missionValidee));
            }

            curs.Close();

            return lstToutesMissions;
        }
    }
}
