using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele
{
    public static class Modele_Test
    {
        private static readonly string server = "154.49.245.52";
        private static readonly string userid = "u607780247_AdminLudophon";
        private static readonly string password = "SEFdk2n@!";
        private static readonly string database = "u607780247_ludophonie";
        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        public static Utilisateur ControleIdentite(string unIdentifiant)
        {

            Utilisateur UtilisateurAControler = null;

            string req = "SELECT * FROM utilisateurs " +
                "INNER JOIN avatars ON utilisateurs.idAvatar = avatars.idAvatar " +
                "INNER JOIN type_utilisateur ON utilisateurs.idTypeUtilisateur = type_utilisateur.idTypeUtilisateur " +
                "WHERE utilisateurs.identifiant = @identifiant";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@identifiant", unIdentifiant}
                        };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            if (curs.Read())
            {
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string identifiant = ((string)curs.Field("identifiant"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string classe = ((string)curs.Field("classe"));
                string password = ((string)curs.Field("nom"));
                string adresse_Avatar = ((string)curs.Field("url"));
                string type_utilisateur = ((string)curs.Field("libelleType"));                

                UtilisateurAControler = new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, classe, password, adresse_Avatar);
            }

            curs.Close();
            return UtilisateurAControler;
        }
    }
}
