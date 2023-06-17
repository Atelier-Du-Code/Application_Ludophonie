using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Patient
{
    public static class Modele_MenuPrincipal_Patient
    {
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Permet de modifier l'avatar du patient en cours
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idAvatar"></param>
        /// <returns></returns>
        public static bool updateAvatar(int idUtilisateur, int idAvatar)
        {
            try
            {
                string req = "UPDATE utilisateurs SET idAvatar=@idAvatar WHERE utilisateurs.idUtilisateur=@idUtilisateur;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@idUtilisateur", idUtilisateur},
                     {"@idAvatar", idAvatar}
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
        /// permet de récupérer l'avatar actuel d'un patient
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static Avatar recupereAvatar(int idUtilisateur)
        {
            Avatar unAvatar = null;
            string req = "SELECT avatars.idAvatar, avatars.nom, avatars.url " +
                "FROM avatars " +
                "INNER JOIN utilisateurs ON avatars.idAvatar = utilisateurs.idAvatar " +
                "WHERE utilisateurs.IdUtilisateur = @idUtilisateur; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@idUtilisateur", idUtilisateur}                   
                };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            if(curs.Read())
            {
                int idAvatar = ((int)curs.Field("idAvatar"));
                string nom = ((string)curs.Field("nom"));
                string url = ((string)curs.Field("url"));

                unAvatar = new Avatar(idAvatar, nom, url);
            }

            curs.Close();

            return unAvatar;
        }
    }
}
