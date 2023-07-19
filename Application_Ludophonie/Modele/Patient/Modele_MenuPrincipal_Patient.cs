using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Patient
{
    /// <summary>
    /// Modele - Classe d'accès aux données pour le menu principal - Côté patient 
    /// </summary>
    public static class Modele_MenuPrincipal_Patient
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
        /// permet de récupérer l'avatar actuel d'un patient
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static Avatar recupereAvatar(int idUtilisateur)
        {
            Avatar unAvatar = null;
            string req = "SELECT avatars.idAvatar, avatars.nom, avatars.url, grade.libelle_grade " +
                "FROM avatars " +
                "INNER JOIN grade ON grade.idGrade = avatars.idGrade " +
                "INNER JOIN utilisateurs ON avatars.idAvatar = utilisateurs.idAvatar " +
                "WHERE utilisateurs.IdUtilisateur = @idUtilisateur; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@idUtilisateur", idUtilisateur}                   
                };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if(curs.Read())
            {
                int idAvatar = ((int)curs.Field("idAvatar"));
                string nom = ((string)curs.Field("nom"));
                string url = ((string)curs.Field("url"));
                string libelle_grade = ((string)curs.Field("libelle_grade"));

                unAvatar = new Avatar(idAvatar, nom, url, libelle_grade);
            }

            curs.Close();

            return unAvatar;
        }

        public static string recupereLeGradeString(int idUtilisateur)
        {
            string grade = "";

            string req = "SELECT libelle_grade FROM grade INNER JOIN grade_utilisateur ON grade_utilisateur.idGrade = grade.idGrade " +
                "WHERE grade_utilisateur.idUtilisateur = @idUtilisateur";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@idUtilisateur", idUtilisateur}
                };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {   
                string libelle_grade = ((string)curs.Field("libelle_grade"));

                grade = libelle_grade;
            }

            curs.Close();

            return grade;
        }

        public static int recupereLeGradeInt(int idUtilisateur)
        {
            int grade = 0;

            string req = "SELECT idGrade FROM grade_utilisateur WHERE grade_utilisateur.idUtilisateur = @idUtilisateur;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@idUtilisateur", idUtilisateur}
                };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                int idGrade = ((int)curs.Field("idGrade"));

                grade = idGrade;
            }

            curs.Close();

            return grade;
        }

        public static string recupereNiveauPatient(int idUtilisateur)
        {
            string niveauPatient = "";

            string req = "SELECT niveau FROM niveau " +
                "INNER JOIN niveau_utilisateur_jeu ON niveau_utilisateur_jeu.idNiveau = niveau.idNiveau " +
                "WHERE niveau_utilisateur_jeu.idUtilisateur = 2 AND niveau_utilisateur_jeu.idJeu = 1; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@idUtilisateur", idUtilisateur}
                };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                string niveau = ((string)curs.Field("niveau"));

                niveauPatient = niveau;
            }

            curs.Close();

            return niveauPatient;
        }
    }
}
