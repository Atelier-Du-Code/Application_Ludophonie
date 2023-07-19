using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Patient
{
    /// <summary>
    /// Modele - Classe d'accès aux données pour le carnet de missions - Côté patient 
    /// </summary>
    public static class Modele_Carnet_de_quetes
    {
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";

        /*
        private static string server = "154.49.245.52";
        private static string userid = "u607780247_testLudo";
        private static string password = "gTyHI2QZez";
        private static string database = "u607780247_testLudo";
        */

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";


        /// <summary>
        /// Permet de récupérer toutes les missions pour un utilisateur
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static List<string>recupereLstMissionsAvant(int idUtilisateur)
        {
            List<string> lstmissions = new List<string>();

            string req = "SELECT idUtilisateur, texte_de_mission FROM carnet_de_mission WHERE carnet_de_mission.idUtilisateur = @idUtilisateur;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", idUtilisateur}
                        };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {                
                string texteDeMission = ((string)curs.Field("texte_de_mission"));

                lstmissions.Add(texteDeMission);
            }

            curs.Close();
            return lstmissions;
        }

        public static List<Mission> recupereToutesMissions(int unIdUtilisateur)
        {
            List<Mission> lstToutesMissions = new List<Mission>();

            string req = "SELECT idMission, nbQuestions, valide, jeux.nomJeu " +
                "FROM carnet_de_mission " +
                "INNER JOIN jeux ON jeux.idJeu = carnet_de_mission.idJeu " +
                "WHERE idUtilisateur = @idUtilisateur";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                 {"@idUtilisateur", unIdUtilisateur}
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
