using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele
{
    public static class Modele_Authentification   {
        
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database="ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";
        

        public static Utilisateur ControleIdentite(string unIdentifiant)
        {

            Utilisateur UtilisateurAControler = null;

            string req = "SELECT u.idUtilisateur,u.identifiant, u.nom, u.prenom, u.classe, u.password, avatars.url, type_utilisateur.type ";
                req += "FROM utilisateurs AS u ";
                req += "INNER JOIN avatars ON u.idAvatar = avatars.idAvatar ";
                req += "INNER JOIN type_utilisateur ON u.idTypeUtilisateur = type_utilisateur.idTypeUtilisateur ";
                req += "WHERE  u.identifiant = @identifiant ";
               

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@identifiant", unIdentifiant}
                        };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string identifiant = ((string)curs.Field("identifiant"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string classe = ((string)curs.Field("classe"));
                string password = ((string)curs.Field("password"));
                string adresse_Avatar = ((string)curs.Field("url"));
                string type_utilisateur = ((string)curs.Field("type"));
                

                UtilisateurAControler = new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, classe, password, adresse_Avatar);
            }

            curs.Close();
            return UtilisateurAControler;
        }
              
    }
}
