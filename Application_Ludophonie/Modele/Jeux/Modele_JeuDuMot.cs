using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Application_Ludophonie.Modele.Jeux
{
    /// <summary>
    /// Modèle - Classe d'accès aux données pour le jeu du mot - Coté patient
    /// </summary>
    public static class Modele_JeuDuMot
    {
        /*
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";

        
        private static string server = "154.49.245.52";
        private static string userid = "u607780247_testLudo";
        private static string password = "gTyHI2QZez";
        private static string database = "u607780247_testLudo";
        */


        //private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Permet de récupérer toutes les images d'interface
        /// </summary>
        /// <returns></returns>
        public static List<Image> recupereImagesInterface()
        {
            List<Image> lstToutesImagesInterfaces = new List<Image>();

            string req = "SELECT nom, url FROM images_interface";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {

                string nom = ((string)curs.Field("nom"));
                string url = ((string)curs.Field("url"));


                lstToutesImagesInterfaces.Add(new Image(nom, url));
            }

            curs.Close();

            return lstToutesImagesInterfaces;
        }

        /// <summary>
        /// Permet de récupérer les mots suivant les critères de leur liste d'appartenance et de leur niveau d'acquisition pour le patient en cours
        /// </summary>
        /// <param name="liste"></param>
        /// <param name="acquisitionDuMot"></param>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static List<Mot> recupereMotsParListeNiveauAcquisitionIdUtilisateur(string liste, int acquisitionDuMot, int idUtilisateur)
        {
            List<Mot> lstMots = new List<Mot>();

            string req = "SELECT lesmots.idMot, lesmots.mot, lesmots.contexte, niveaudelistes.nom_liste, acquisition_lemot.idNiveauAcquisition " +
                "FROM lesmots " +
                "INNER JOIN niveaudelistes ON lesmots.idListe = niveaudelistes.idListe " +
                "INNER JOIN acquisition_lemot ON lesmots.idMot = acquisition_lemot.idMot " +
                "INNER JOIN utilisateurs ON acquisition_lemot.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN niveau_aquisition ON acquisition_lemot.idNiveauAcquisition = niveau_aquisition.idNiveauAquisition " +
                "WHERE utilisateurs.idUtilisateur = @idUtilisateur AND acquisition_lemot.idNiveauAcquisition = @acquisition AND niveaudelistes.nom_liste = @liste;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                 {"@liste", liste},
                 {"@acquisition", acquisitionDuMot},
                 {"@idUtilisateur", idUtilisateur}
            };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int idMot = ((int)curs.Field("idMot"));
                string mot = ((string)curs.Field("mot"));
                string contexte = ((string)curs.Field("contexte"));
                string nomListe = ((string)curs.Field("nom_liste"));
                int acquisition = ((int)curs.Field("idNiveauAcquisition"));

                lstMots.Add(new Mot(idMot, mot, contexte, nomListe, acquisition));
            }

            curs.Close();

            return lstMots;
        }

        /// <summary>
        /// Permet de changer le niveau d'acquisition de mots en fin de série du "Jeu du Mot"
        /// </summary>
        /// <param name="IdUtilisateur"></param>
        /// <param name="idMot"></param>
        /// <param name="acquisition"></param>
        /// <returns></returns>
        public static bool updateDeLaBaseAvecMotsDeLaSerie(int IdUtilisateur, int idMot, int acquisition)
        {
            try
            {
                string req = "UPDATE acquisition_lemot " +
               "SET idNiveauAcquisition = @idNiveauAcquisition " +
               "WHERE acquisition_lemot.idUtilisateur = @idUtilisateur AND acquisition_lemot.idMot = @idMot; ";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idMot", idMot},
                    {"@idNiveauAcquisition", acquisition},
                    {"@idUtilisateur", IdUtilisateur}
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
        /// Permet de récupérer le niveau d'acquisition d'un mot pour un patient donné
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idMot"></param>
        /// <returns></returns>
        public static int recuperelstNiveauxAcquisitionUtilisateur(int idUtilisateur, int idMot)
        {
            int idAcquisition = 0;

            string req = "SELECT idNiveauAcquisition FROM acquisition_lemot WHERE idutilisateur = @idUtilisateur AND idMot = @idMot;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idMot", idMot},
                    {"@idUtilisateur", idUtilisateur}
                };


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                int idNiveauAcquisition = ((int)curs.Field("idNiveauAcquisition"));

                idAcquisition = idNiveauAcquisition;
            }

            curs.Close();

            return idAcquisition;

        }

        /// <summary>
        /// Permet la création d'une série du "Jeu du mot"
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idjeu"></param>
        /// <param name="nbQuestionDeLaSerie"></param>
        /// <param name="nbErreur"></param>
        /// <param name="dateDuJour"></param>
        /// <param name="timer"></param>
        /// <returns></returns>
        public static bool creationSerieEffectuees(int idUtilisateur, int idjeu, int nbQuestionDeLaSerie, int nbErreur, DateTime dateDuJour, DateTime timer, int serieDemandee, int score)
        {
            try
            {
                string req = "INSERT INTO series_effectuees(idUtilisateur, idJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer, serieDemandee, score) VALUES (@idUtilisateur, @idjeu, @nbQuestionDeLaSerie, @nbErreur, @dateDuJour, @timer, @serieDemandee, @score)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idUtilisateur", idUtilisateur},
                    {"@idjeu", idjeu},
                    {"@nbQuestionDeLaSerie", nbQuestionDeLaSerie},
                    {"@nbErreur", nbErreur},
                    {"@dateDuJour", dateDuJour},
                    {"@timer", timer},
                    {"@serieDemandee", serieDemandee},
                    {"@score", score}

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

        public static bool verifieSiCEstUneMission(int nbQuestion, int idJeu, int idUtilisateur)
        {
            bool bCestUneMission = true;

            string req = "SELECT idMission " +
                "FROM carnet_de_mission " +
                "WHERE idUtilisateur = @idUtilisateur AND nbQuestions = @nbQuestion AND valide = 0 AND idJeu = @idJeu; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@nbQuestion", nbQuestion},
                    {"@idJeu", idJeu},
                    {"@idUtilisateur", idUtilisateur}
                };


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                bCestUneMission = true;
            }
            else
            {
                bCestUneMission = false;
            }

            curs.Close();

            return bCestUneMission;
        }

        public static int recupereNiveauDuJeuDuPatient(int idUtilisateur, int idJeu)
        {
            int niveau = 0;
            string req = "SELECT niveau.idNiveau FROM niveau " +
                "INNER JOIN niveau_utilisateur_jeu ON niveau_utilisateur_jeu.idNiveau = niveau.idNiveau " +
                "WHERE niveau_utilisateur_jeu.idUtilisateur = 2 AND niveau_utilisateur_jeu.idJeu = 1; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {                    
                    {"@idJeu", idJeu},
                    {"@idUtilisateur", idUtilisateur}
                };


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                int idNiveau = ((int)curs.Field("idNiveau"));

                niveau = idNiveau;

            }           

            curs.Close();

            return niveau;
        }

        public static int recupereGainMission(int idNiveau, int idJeu)
        {
            int gain = 0;

            string req = "SELECT niveau.gainMission " +
                "FROM niveau " +
                "WHERE idJeu = @idJeu AND idNiveau = @idNiveau; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idJeu", idJeu},
                    {"@idNiveau", idNiveau}
                };


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                int gainMission = ((int)curs.Field("gainMission"));

                gain = gainMission;
            }

            curs.Close();

            return gain;
        }

        public static int recupereGainSerie(int idNiveau, int idJeu)
        {
            int gain = 0;

            string req = "SELECT niveau.gainSerie " +
                "FROM niveau " +
                "WHERE idJeu = @idJeu AND idNiveau = @idNiveau; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idJeu", idJeu},
                    {"@idNiveau", idNiveau}
                };

            
            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                int gainMission = ((int)curs.Field("gainSerie"));

                gain = gainMission;
            }

            curs.Close();

            return gain;
        }

        public static bool updateScoreGlobal(int idUtilisateur, int scoreGlobal)
        {
            try
            {
                bool bUpdate = true;

                string req = "UPDATE grade_utilisateur SET scoreUtilisateur= @scoreGlobal WHERE idUtilisateur = @idUtilisateur";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {                   
                    {"@scoreGlobal", scoreGlobal},
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

        public static int recupereScoreGlobalPatient(int idUtilisateur)
        {
            int scoreGlobalPatient = 0;

            string req = "SELECT scoreUtilisateur FROM grade_utilisateur WHERE idUtilisateur = @idUtilisateur;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idUtilisateur", idUtilisateur},
                };


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                int scoreUtilisateur = ((int)curs.Field("scoreUtilisateur"));

                scoreGlobalPatient = scoreUtilisateur;
            }

            curs.Close();

            return scoreGlobalPatient;
        }

        public static Mission recupereUneMission(int nbQuestion, int idDuJeu, int idDeUtilisateur)
        {
            Mission mission = null;

            string req = "SELECT idMission, idUtilisateur, jeux.nomJeu, nbQuestions, valide " +
                "FROM carnet_de_mission " +
                "INNER JOIN jeux ON jeux.idJeu = carnet_de_mission.idJeu " +
                "WHERE idUtilisateur = @idUtilisateur AND nbQuestions = @nbQuestion AND valide = 0 AND carnet_de_mission.idJeu = @idJeu; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@nbQuestion", nbQuestion},
                    {"@idJeu", idDuJeu},
                    {"@idUtilisateur", idDeUtilisateur}
                };


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                int idMission = ((int)curs.Field("idMission"));
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestions = ((int)curs.Field("nbQuestions"));
                int valide = ((int)curs.Field("valide"));

                mission = new Mission(idMission, idUtilisateur, nomJeu, nbQuestions, valide);
            }

            curs.Close();

            return mission;
        }

        public static bool updateCarnetDeMission(int idMission)
        {
            try
            {
                string req = "UPDATE carnet_de_mission SET valide = 1 WHERE idMission = @idMission;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idMission", idMission},                    
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

        public static int recupereNbMotsAcquisPatient(int idUtilisateur)
        {
            int nbMotsAcquis = 0;

            string req = "SELECT idAcquis " +
                "FROM acquisition_lemot " +
                "WHERE acquisition_lemot.idNiveauAcquisition = 5 AND acquisition_lemot.idUtilisateur = @idUtilisateur; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {                    
                    {"@idUtilisateur", idUtilisateur}
                };


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                nbMotsAcquis++;
            }

            curs.Close();

            return nbMotsAcquis;
        }

        public static int recupereNbMotsTotal()
        {
            int nbDesMots = 0;

            string req = "SELECT idMot FROM lesmots;";
            

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                nbDesMots++;
            }

            curs.Close();

            return nbDesMots;
        }




    }
}
