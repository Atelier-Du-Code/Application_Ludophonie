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

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Récupère toutes les missions d'un utilisateur
        /// </summary>
        /// <param name="unIdUtilisateur"></param>
        /// <returns></returns>
        public static List<string> recupereToutesMissions(int unIdUtilisateur)
        {
            List<string> lstToutesMissions = new List<string>();

            string req = "SELECT idUtilisateur, texte_de_mission FROM carnet_de_mission WHERE idUtilisateur = @idUtilisateur;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
             {
                 {"@idUtilisateur", unIdUtilisateur}
             };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {

                string texte_mission = ((string)curs.Field("texte_de_mission"));


                lstToutesMissions.Add(texte_mission);
            }

            curs.Close();

            return lstToutesMissions;
        }
        /// <summary>
        /// Permet d'enregistrer une nouvelle mission
        /// </summary>
        /// <param name="mission"></param>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static bool enregistreUneMission(string mission, int idUtilisateur)
        {
            try
            {
                string req = "INSERT INTO carnet_de_mission(idUtilisateur, texte_de_mission) VALUES (@idUtilisateur,@mission);";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@mission", mission},
                    {"@idUtilisateur", idUtilisateur}
                };

                BddMySql curs = BddMySql.GetInstance(connectionString);
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
        public static bool supprimeUneMission(string mission, int idUtilisateur)
        {
            try
            {
                string req = "DELETE carnet_de_mission FROM carnet_de_mission WHERE idUtilisateur = @idUtilisateur AND texte_de_mission = @mission;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@mission", mission},
                    {"@idUtilisateur", idUtilisateur}
                };

                BddMySql curs = BddMySql.GetInstance(connectionString);
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

                BddMySql curs = BddMySql.GetInstance(connectionString);
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
