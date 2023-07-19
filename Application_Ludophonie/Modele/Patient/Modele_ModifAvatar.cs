using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele
{
    /// <summary>
    /// Modele - Classe d'accès à la données pour la page de modification des avatars
    /// </summary>
    public static class Modele_ModifAvatar
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
        /// Permet de récupérer tous les avatars
        /// </summary>
        /// <returns></returns>
        public static List<Avatar> recupereLstAvatar()
        {
            List<Avatar> lstAvatars = new List<Avatar>();

            string req = "SELECT idAvatar, nom, url, libelle_grade FROM avatars " +
                "INNER JOIN grade ON grade.idGrade = avatars.idGrade";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idAvatar = ((int)curs.Field("idAvatar"));
                string nom = ((string)curs.Field("nom"));
                string url = ((string)curs.Field("url"));
                string libelle_grade = ((string)curs.Field("libelle_grade"));

                lstAvatars.Add(new Avatar(idAvatar, nom, url, libelle_grade));
            }

            curs.Close();
            return lstAvatars;
        }

        /// <summary>
        /// Permet de modifier l'avatar d'un patient
        /// </summary>
        /// <param name="idAvatar"></param>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static bool modifAvatar(int idAvatar, int idUtilisateur)
        {
            try
            {
                string req = "UPDATE utilisateurs SET idAvatar=@idAvatar WHERE idUtilisateur = @idUtilisateur; ";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idAvatar", idAvatar},
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

        public static int compteAvatarDuPatient(int idGrade)
        {
            int nbAvatarPatient = 0;

            string req = "SELECT idAvatar, nom, url, idGrade FROM avatars WHERE idGrade < @idGrade;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idGrade", idGrade},
                        };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {            
                nbAvatarPatient++;
            }

            curs.Close();
            return nbAvatarPatient;
            
        }
    }
}
