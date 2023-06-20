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
    /// Modele - Classe d'accès aux données pour l'authentification 
    /// </summary>
    public static class Modele_Authentification   
    {
        
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database="ludophonie";
        
        /*
        private static string server = "154.49.245.52";
        private static string userid = "u607780247_testLudo";
        private static string password = "gTyHI2QZez";
        private static string database = "u607780247_testLudo";
        */

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";
        
        /// <summary>
        /// Permet de vérifier si un utilisateur existe
        /// </summary>
        /// <param name="unIdentifiant"></param>
        /// <returns></returns>
        public static bool utilisateurExiste(string unIdentifiant)
        {
            string nom = "";

            string req = "SELECT nom FROM utilisateurs WHERE utilisateurs.identifiant = @identifiant;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@identifiant", unIdentifiant}
                        };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                nom = ((string)curs.Field("nom"));
            }

            curs.Close();

            if (nom == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Permet de récupérer toutes les informations d'un patient
        /// </summary>
        /// <param name="unIdentifiant"></param>
        /// <returns></returns>
        public static Utilisateur recupereUtilisateur(string unIdentifiant)
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
