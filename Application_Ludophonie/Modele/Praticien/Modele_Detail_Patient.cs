using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Praticien
{
    /// <summary>
    /// Modèle - Classe d'accès aux données pour la fiche patient - Côté praticien
    /// </summary>
    public static class Modele_Detail_Patient
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
        /// Permet de récupérer tous les noms de jeux
        /// </summary>
        /// <returns></returns>
        public static List<string> recupereTousLesJeux()
        {
            List<string> lstJeux = new List<string>();

            string req = "SELECT nomJeu FROM jeux;";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                string nomDuJeu = ((string)curs.Field("nomJeu"));

                lstJeux.Add(nomDuJeu);
            }

            curs.Close();

            return lstJeux;
        }
        
        /// <summary>
        /// Permet de récupérer toutes les séries effectuées par un utilisateur
        /// </summary>
        /// <param name="unIdUtilisateur"></param>
        /// <returns></returns>
        public static List<Serie> recupereToutesSeriesUtilisateur(int unIdUtilisateur)
        {
            List<Serie> lstToutesSeriesUtilisateur = new List<Serie>();

            string req = "SELECT idSerieEffectuee, idUtilisateur, jeux.nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer, serieDemandee, score " +
                "FROM series_effectuees " +
                "INNER JOIN jeux ON series_effectuees.idJeu = jeux.idJeu " +
                "WHERE idUtilisateur=@idUtilisateur;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", unIdUtilisateur}
                        };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int idSerieEffectuee = ((int)curs.Field("idSerieEffectuee"));
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string jeu = ((string)curs.Field("nomJeu"));
                int nbQuestions = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));
                int serieDemandee = ((int)curs.Field("serieDemandee"));
                int score = ((int)curs.Field("score"));


                lstToutesSeriesUtilisateur.Add(new Serie(idSerieEffectuee, idUtilisateur, null, null, null, jeu, nbQuestions, nbErreur, dateDuJour, timer, serieDemandee, score));

            }

            curs.Close();

            return lstToutesSeriesUtilisateur;

        }

        /// <summary>
        /// Permet de récupérer toutes les séries d'un utilisateur sur un jeu spécifique
        /// </summary>
        /// <param name="unIdUtilisateur"></param>
        /// <param name="nomJeu"></param>
        /// <returns></returns>
        public static List<Serie> recupereToutesSeriesJeu(int unIdUtilisateur, string nomJeu)
        {
            List<Serie> lstToutesSeriesJeu = new List<Serie>();

            string req = "SELECT idSerieEffectuee, idUtilisateur, jeux.nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer, serieDemandee, score " +
                "FROM series_effectuees " +
                "INNER JOIN jeux ON series_effectuees.idJeu = jeux.idJeu " +
                "WHERE idUtilisateur=@idUtilisateur AND jeux.nomJeu = @nomJeu;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", unIdUtilisateur},
                            {"@nomJeu", nomJeu}
                        };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int idSerieEffectuee = ((int)curs.Field("idSerieEffectuee"));
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string jeu = ((string)curs.Field("nomJeu"));
                int nbQuestions = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));
                int serieDemandee = ((int)curs.Field("serieDemandee"));
                int score = ((int)curs.Field("score"));

                lstToutesSeriesJeu.Add(new Serie(idSerieEffectuee, idUtilisateur, null, null, null, jeu, nbQuestions, nbErreur, dateDuJour, timer, serieDemandee, score));

            }

            curs.Close();

            return lstToutesSeriesJeu;
        }

        public static string recupereNiveauDeJeuPourUnPatient(int unIdUtilisateur, string nomJeu)
        {
            string leNiveau = "";
            string req = "SELECT niveau.niveau " +
                "FROM niveau " +
                "INNER JOIN niveau_utilisateur_jeu ON niveau_utilisateur_jeu.idNiveau = niveau.idNiveau " +
                "INNER JOIN jeux ON jeux.idJeu = niveau_utilisateur_jeu.idJeu " +
                "WHERE niveau_utilisateur_jeu.idUtilisateur = @idUtilisateur AND jeux.nomJeu = @nomJeu;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", unIdUtilisateur},
                            {"@nomJeu", nomJeu}
                        };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                string niveau = ((string)curs.Field("niveau"));

                leNiveau = niveau;
            }

            curs.Close();

            return leNiveau;
        }
    }
}
