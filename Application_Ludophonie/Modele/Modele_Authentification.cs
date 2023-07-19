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

            BddMySql curs = BddMySql.GetInstance();
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

            string req = "SELECT u.idUtilisateur,u.identifiant, u.nom, u.prenom, u.classe, u.password, avatars.url, type_utilisateur.type, ";
                req += "grade.libelle_grade,grade_utilisateur.scoreUtilisateur ";
                req += "FROM utilisateurs AS u ";
                req += "INNER JOIN avatars ON u.idAvatar = avatars.idAvatar ";
                req += "INNER JOIN type_utilisateur ON u.idTypeUtilisateur = type_utilisateur.idTypeUtilisateur ";
                req += "INNER JOIN grade_utilisateur ON grade_utilisateur.idUtilisateur = u.idUtilisateur ";
                req += "INNER JOIN grade ON grade.idGrade = grade_utilisateur.idGrade ";
                req += "WHERE u.identifiant = @identifiant ";
               

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@identifiant", unIdentifiant}
                        };

            BddMySql curs = BddMySql.GetInstance();
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
                int score_global = ((int)curs.Field("scoreUtilisateur"));
                string grade = ((string)curs.Field("grade"));


                UtilisateurAControler = new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, 
                    classe, password, adresse_Avatar, score_global, grade);
            }

            curs.Close();
            return UtilisateurAControler;
        }

        

    }
}
