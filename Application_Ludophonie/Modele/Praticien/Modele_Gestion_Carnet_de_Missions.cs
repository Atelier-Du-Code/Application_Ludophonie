using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Praticien
{
    /// <summary>
    /// Modele - Classe d'accès aux données pour la gestion du carnet de mission - Coté patient
    /// </summary>
    public static class Modele_Gestion_Carnet_de_Missions
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
        /// Récupère toutes les missions d'un utilisateur
        /// </summary>
        /// <param name="unIdUtilisateur"></param>
        /// <returns></returns>
        public static List<Mission> recupereToutesMissions(int unIdUtilisateur)
        {
            List<Mission> lstToutesMissions = new List<Mission>();

            string req = "SELECT idMission, nbQuestions, valide, jeux.nomJeu " +
                "FROM carnet_de_mission " +
                "INNER JOIN jeux ON jeux.idJeu = carnet_de_mission.idJeu " +
                "WHERE idUtilisateur = @idUtilisateur;";

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

         public static List<string> recupereTousLesJeux()
         {
            List<string> lstTousjeux = new List<string>();

            string req = "SELECT nomJeu FROM jeux";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {

                string nomJeu = ((string)curs.Field("nomJeu"));


                lstTousjeux.Add(nomJeu);
            }

            curs.Close();

            return lstTousjeux;
         }


        /// <summary>
        /// Permet d'enregistrer une nouvelle mission
        /// </summary>
        /// <param name="mission"></param>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static bool enregistreUneMission(int idUtilisateur, int idJeu, int nbQuestions)
        {
            try
            {
                string req = "INSERT INTO `carnet_de_mission`(idUtilisateur, idJeu, nbQuestions, valide) " +
                    "VALUES (@idUtilisateur, @idJeu, @nbQuestions, '0')";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idUtilisateur", idUtilisateur},
                    {"@idJeu", idJeu},
                    {"@nbQuestions", nbQuestions}

                };

                BddMySql curs = BddMySql.GetInstance();
                curs.ReqUpdate(req, parameters);

                curs.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de supprimer une mission du patient en cours 
        /// </summary>
        /// <param name="mission"></param>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static bool supprimeUneMission(int idMission)
        {
            try
            {
                string req = "DELETE FROM carnet_de_mission WHERE carnet_de_mission.idMission = @idMission; ";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idMission", idMission},                    
                };

                BddMySql curs = BddMySql.GetInstance();
                curs.ReqUpdate(req, parameters);

                curs.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de supprimer toutes les missions d'un utilisateur en cours
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static bool supprimeToutesMissions(int idUtilisateur)
        {
            try
            {
                string req = "DELETE carnet_de_mission FROM carnet_de_mission WHERE idUtilisateur = @idUtilisateur";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {                    
                    {"@idUtilisateur", idUtilisateur}
                };

                BddMySql curs = BddMySql.GetInstance();
                curs.ReqUpdate(req, parameters);

                curs.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
