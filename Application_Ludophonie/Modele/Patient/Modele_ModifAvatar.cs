using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele
{
    public static class Modele_ModifAvatar
    {
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Permet de récupérer tous les avatars
        /// </summary>
        /// <returns></returns>
        public static List<Avatar> recupereLstAvatar()
        {
            List<Avatar> lstAvatars = new List<Avatar>();

            string req = "SELECT idAvatar, nom, url FROM avatars;";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idAvatar = ((int)curs.Field("idAvatar"));
                string nom = ((string)curs.Field("nom"));
                string url = ((string)curs.Field("url"));

                lstAvatars.Add(new Avatar(idAvatar, nom, url));
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
