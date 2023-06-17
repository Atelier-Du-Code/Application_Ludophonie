using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Patient
{
    public static class Modele_Carnet_de_quetes
    {

        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";


        /// <summary>
        /// Permet de récupérer toutes les missions pour un utilisateur
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static List<string>recupereLstMissions(int idUtilisateur)
        {
            List<string> lstmissions = new List<string>();

            string req = "SELECT idUtilisateur, texte_de_mission FROM carnet_de_mission WHERE carnet_de_mission.idUtilisateur = @idUtilisateur;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", idUtilisateur}
                        };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {                
                string texteDeMission = ((string)curs.Field("texte_de_mission"));

                lstmissions.Add(texteDeMission);
            }

            curs.Close();
            return lstmissions;
        }

    }
}
