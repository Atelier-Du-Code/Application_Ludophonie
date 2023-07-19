using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Application_Ludophonie.Modele.Praticien
{
    /// <summary>
    /// Modele - Classe d'accès aux données pour le menu principal - Côté praticien
    /// </summary>
    public static class Modele_MenuPrincipal_Praticien
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



        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Page d'accueil - tabPage 1
        //////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet de récupérer toutes les séries effectuées pour tous les utilisateurs
        /// </summary>
        /// <returns></returns>
        public static List<Serie> recupereToutesLesSeries()
        {
            List<Serie> lstToutesSeriesEffectuees = new List<Serie>();

            string req = "SELECT idSerieEffectuee, utilisateurs.idUtilisateur, utilisateurs.nom, utilisateurs.prenom, grade.libelle_grade, jeux.nomJeu," +
                "s.nbQuestionsDeLaSerie, s.nbErreur, s.dateDuJour, s.timer, s.serieDemandee, s.score " +
                "FROM series_effectuees AS s " +
                "INNER JOIN utilisateurs ON s.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN grade_utilisateur ON grade_utilisateur.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN grade ON grade.idGrade = grade_utilisateur.idGrade " +
                "INNER JOIN jeux ON s.idJeu = jeux.idJeu ORDER BY s.dateDuJour DESC; ";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idSerieEffectuee = ((int)curs.Field("idSerieEffectuee"));
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string grade = ((string)curs.Field("libelle_grade"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestionsDeLaSerie = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));
                int serieDemandee = ((int)curs.Field("serieDemandee"));
                int score = ((int)curs.Field("score"));

                lstToutesSeriesEffectuees.Add(new Serie(idSerieEffectuee, idUtilisateur, nom, prenom, grade, nomJeu,
                    nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer, serieDemandee, score));
            }

            curs.Close();

            return lstToutesSeriesEffectuees;
        }

        /// <summary>
        /// Permet de récupérer toutes les séries effectuées pour tous les utilisateurs
        /// effectuées aujourd'hui
        /// </summary>
        /// <returns></returns>
        public static List<Serie> recupereLesSeriesEffectueesAujourdhui()
        {
            List<Serie> lstSeriesEffectueesAujourdhui = new List<Serie>();

            string req = "SELECT idSerieEffectuee, utilisateurs.idUtilisateur, utilisateurs.nom, utilisateurs.prenom, grade.libelle_grade, jeux.nomJeu, " +
                "s.nbQuestionsDeLaSerie, s.nbErreur, s.dateDuJour, s.timer, s.serieDemandee, s.score " +
                "FROM series_effectuees AS s " +
                "INNER JOIN utilisateurs ON s.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN grade_utilisateur ON grade_utilisateur.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN grade ON grade.idGrade = grade_utilisateur.idGrade " +
                "INNER JOIN jeux ON s.idJeu = jeux.idJeu " +
                "WHERE s.dateDuJour = CURRENT_DATE() ORDER BY s.dateDuJour DESC";


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idSerieEffectuee = ((int)curs.Field("idSerieEffectuee"));
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string grade = ((string)curs.Field("libelle_grade"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestionsDeLaSerie = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));
                int serieDemandee = ((int)curs.Field("serieDemandee"));
                int score = ((int)curs.Field("score"));

                lstSeriesEffectueesAujourdhui.Add(new Serie(idSerieEffectuee, idUtilisateur, nom, prenom, grade, nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer, serieDemandee, score));
            }

            curs.Close();

            return lstSeriesEffectueesAujourdhui;
        }

        /// <summary>
        /// Permet de récupérer toutes les séries effectuées pour tous les utilisateurs
        /// effectuées il y a jusqu'à une semaine avant aujourd'hui
        /// </summary>
        /// <returns></returns>
        public static List<Serie> recupereLesSeriesEffectueesSemaine()
        {
            List<Serie> lstSeriesEffectueesSemaine = new List<Serie>();

            string req = "SELECT idSerieEffectuee, utilisateurs.idUtilisateur, utilisateurs.nom, utilisateurs.prenom, grade.libelle_grade, jeux.nomJeu, " +
                "s.nbQuestionsDeLaSerie, s.nbErreur, s.dateDuJour, s.timer, s.serieDemandee, score " +
                "FROM series_effectuees AS s " +
                "INNER JOIN utilisateurs ON s.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN grade_utilisateur ON grade_utilisateur.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN grade ON grade.idGrade = grade_utilisateur.idGrade " +
                "INNER JOIN jeux ON s.idJeu = jeux.idJeu " +
                "WHERE s.dateDuJour BETWEEN CURRENT_DATE() - INTERVAL 7 DAY AND CURRENT_DATE() ORDER BY s.dateDuJour DESC;";


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idSerieEffectuee = ((int)curs.Field("idSerieEffectuee"));
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string grade = ((string)curs.Field("libelle_grade"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestionsDeLaSerie = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));
                int serieDemandee = ((int)curs.Field("serieDemandee"));
                int score = ((int)curs.Field("score"));

                lstSeriesEffectueesSemaine.Add(new Serie(idSerieEffectuee, idUtilisateur, nom, prenom, grade, nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer, serieDemandee, score));
            }

            curs.Close();

            return lstSeriesEffectueesSemaine;
        }

        /// <summary>
        /// Permet de récupérer toutes les séries effectuées pour tous les utilisateurs
        /// effectuées jusqu'à 30 jours avant aujourd'hui
        /// </summary>
        /// <returns></returns>
        public static List<Serie> recupereLesSeriesEffectueesMois()
        {
            List<Serie> lstSeriesEffectueesMois = new List<Serie>();

            string req = "SELECT idSerieEffectuee, utilisateurs.idUtilisateur, utilisateurs.nom, utilisateurs.prenom, grade.libelle_grade, jeux.nomJeu, " +
                "s.nbQuestionsDeLaSerie, s.nbErreur, s.dateDuJour, s.timer, s.serieDemandee, score " +
                "FROM series_effectuees AS s " +
                "INNER JOIN utilisateurs ON s.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN grade_utilisateur ON grade_utilisateur.idUtilisateur = utilisateurs.idUtilisateur " +
                "INNER JOIN grade ON grade.idGrade = grade_utilisateur.idGrade " +
                "INNER JOIN jeux ON s.idJeu = jeux.idJeu " +
                "WHERE s.dateDuJour BETWEEN CURRENT_DATE() - INTERVAL 30 DAY AND CURRENT_DATE() ORDER BY s.dateDuJour DESC;";


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idSerieEffectuee = ((int)curs.Field("idSerieEffectuee"));
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string grade = ((string)curs.Field("libelle_grade"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestionsDeLaSerie = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));
                int serieDemandee = ((int)curs.Field("serieDemandee"));
                int score = ((int)curs.Field("score"));

                lstSeriesEffectueesMois.Add(new Serie(idSerieEffectuee, idUtilisateur, nom, prenom, grade, nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer, serieDemandee, score));
            }

            curs.Close();

            return lstSeriesEffectueesMois;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Catalogue des patients - tabPage 2
        //////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet de récupérer toutes les informations d'un patient grâce à son identifiant
        /// </summary>
        /// <param name="unIdentifiant"></param>
        /// <returns></returns>
        public static Utilisateur recuperePatient(string unIdentifiant)
        {

            Utilisateur patientRecupere = null;

            string req = "SELECT u.idUtilisateur,u.identifiant, u.nom, u.prenom, u.classe, u.password, avatars.url, type_utilisateur.type, grade.libelle_grade, grade_utilisateur.scoreUtilisateur ";
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
                string grade = ((string)curs.Field("libelle_grade"));


                patientRecupere = new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, classe, password, adresse_Avatar, score_global, grade);
            }

            curs.Close();
            return patientRecupere;
        }

        /// <summary>
        /// Permet de récupérer tous les patients
        /// </summary>
        /// <returns></returns>
        public static List<Utilisateur> recupereTousLesPatients()
        {

            List<Utilisateur> lstTousLesPatients = new List<Utilisateur>();

            string req = "SELECT u.idUtilisateur,u.identifiant, u.nom, u.prenom, u.classe, u.password, avatars.url, type_utilisateur.type, grade.libelle_grade, grade_utilisateur.scoreUtilisateur ";
            req += "FROM utilisateurs AS u ";
            req += "INNER JOIN avatars ON u.idAvatar = avatars.idAvatar ";
            req += "INNER JOIN type_utilisateur ON u.idTypeUtilisateur = type_utilisateur.idTypeUtilisateur ";
            req += "INNER JOIN grade_utilisateur ON grade_utilisateur.idUtilisateur = u.idUtilisateur ";
            req += "INNER JOIN grade ON grade.idGrade = grade_utilisateur.idGrade ";
            req += "WHERE type_utilisateur.idTypeUtilisateur = 1";


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
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


                lstTousLesPatients.Add(new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, classe, password, adresse_Avatar, score_global, grade));
            }

            curs.Close();
            return lstTousLesPatients;
        }

        /// <summary>
        /// Permet de récupérer tous les patients
        /// </summary>
        /// <param name="nouvelUtilisateur"></param>
        /// <returns></returns>
        public static bool creeUtilisateur(Utilisateur nouvelUtilisateur)
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Verbose()
               .WriteTo.File("logs/logs_Debug.txt",
               rollingInterval: RollingInterval.Day)
               .CreateLogger();
            try
            {
                string req = "INSERT INTO utilisateurs (identifiant, nom, prenom, classe, password, idAvatar, idTypeUtilisateur, date_inscription) VALUES " +
                    "(@identifiant, @nom, @prenom, @classe, @password, 1, 1, CURRENT_DATE()); ";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@identifiant", nouvelUtilisateur.Identifiant},
                            {"@nom", nouvelUtilisateur.Nom},
                            {"@prenom", nouvelUtilisateur.Prenom},
                            {"@classe", nouvelUtilisateur.Classe},
                            {"@password", nouvelUtilisateur.Password},
                        };

                BddMySql curs = BddMySql.GetInstance();
                curs.ReqUpdate(req, parameters);

                curs.Close();

                return true;

            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return false;
            }
        }

        /// <summary>
        /// Permet de modifier un utilisateur
        /// </summary>
        /// <param name="UtilisateurAModifier"></param>
        /// <returns></returns>
        public static bool ModifieUtilisateur(Utilisateur UtilisateurAModifier)
        {
            try
            {
                string req = "UPDATE utilisateurs SET identifiant = @identifiant, nom = @nom, prenom = @prenom, " +
                    "classe = @classe, password = @password WHERE utilisateurs.idUtilisateur = @idUtilisateur;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", UtilisateurAModifier.IdUtilisateur},
                            {"@identifiant", UtilisateurAModifier.Identifiant},
                            {"@nom", UtilisateurAModifier.Nom},
                            {"@prenom", UtilisateurAModifier.Prenom},
                            {"@classe", UtilisateurAModifier.Classe},
                            {"@password", UtilisateurAModifier.Password},
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
        /// Permet de supprimer un utilisateur
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static bool SupprimeUtilisateur(int idUtilisateur)
        {
            try
            {
                string req1 = "DELETE FROM utilisateurs WHERE utilisateurs.idUtilisateur = @idUtilisateur;";

                Dictionary<string, object> parameters1 = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", idUtilisateur},

                        };
                BddMySql curs = BddMySql.GetInstance();
                curs.ReqUpdate(req1, parameters1);

                curs.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de supprimer les séries effectuées d'un patient
        /// </summary>
        /// <param name="utilisateurASupprimer"></param>
        /// <returns></returns>
        public static bool SupprimeSesSeries(Utilisateur utilisateurASupprimer)
        {
            try
            {
                string req = "DELETE " +
                    "FROM series_effectuees " +
                    "WHERE series_effectuees.idUtilisateur = @idUtilisateur";

                Dictionary<string, object> parameters2 = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", utilisateurASupprimer.IdUtilisateur},

                        };

                BddMySql curs = BddMySql.GetInstance();

                curs.ReqUpdate(req, parameters2);

                curs.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool SupprimeSonGrade(Utilisateur utilisateurASupprimer)
        {
            try
            {
                string req = "DELETE FROM grade_utilisateur WHERE idUtilisateur = @idUtilisateur;";

                Dictionary<string, object> parameters2 = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", utilisateurASupprimer.IdUtilisateur},

                        };

                BddMySql curs = BddMySql.GetInstance();

                curs.ReqUpdate(req, parameters2);

                curs.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool SupprimeSonNiveau(Utilisateur utilisateurASupprimer)
        {
            try
            {
                string req = "DELETE FROM niveau_utilisateur_jeu WHERE idUtilisateur = @idUtilisateur";

                Dictionary<string, object> parameters2 = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", utilisateurASupprimer.IdUtilisateur},

                        };

                BddMySql curs = BddMySql.GetInstance();

                curs.ReqUpdate(req, parameters2);

                curs.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }



        /// <summary>
        /// Récupère le nombre de patients enregistrés
        /// </summary>
        /// <returns></returns>
        public static int compteCombienPatientDansBDD()
        {
            int nbPatients = 0;

            string req = "SELECT COUNT(identifiant) AS nbPatients " +
                "FROM utilisateurs " +
                "WHERE utilisateurs.idTypeUtilisateur = 1; ";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            if (curs.Read())
            {
                nbPatients = ((int)curs.Field("nbPatients"));
            }

            curs.Close();

            return nbPatients;
        }

        /// <summary>
        /// Permer de récupérer la liste de tous les n° d'identification des patients
        /// </summary>
        /// <returns></returns>
        public static List<int> recupererTouslstidPatient()
        {
            List<int> lstIdPatient = new List<int>();

            string req = "SELECT utilisateurs.idUtilisateur FROM utilisateurs WHERE utilisateurs.idTypeUtilisateur = 1;";


            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idPatients = ((int)curs.Field("idUtilisateur"));

                lstIdPatient.Add(idPatients);
            }

            curs.Close();

            return lstIdPatient;
        }

        /// <summary>
        /// Permet de récupérer le n° identifiant du dernier patient créé
        /// </summary>
        /// <returns></returns>
        public static int recuperePlusGrandIdPatient()
        {
            int plusGrandIdPatitent = 0;
            string req = "SELECT Max(idUtilisateur) AS idMaxPatient FROM utilisateurs;";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                plusGrandIdPatitent = ((int)curs.Field("idMaxPatient"));
            }

            curs.Close();

            return plusGrandIdPatitent;
        }


        /// <summary>
        /// Permet de récupérer tous les mots enregistrés
        /// </summary>
        /// <returns></returns>
        public static List<int> recupereTousLesMots()
        {
            List<int> lstidMots = new List<int>();

            string req = "SELECT idMot FROM lesmots; ";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idMot = ((int)curs.Field("idMot"));

                lstidMots.Add(idMot);
            }

            curs.Close();

            return lstidMots;
        }

        /// <summary>
        /// Permet de créer des tuples dans la table acquisition_lemot permettant 
        /// de stocker le niveau d'acquisition de chaque mot pour chaque patient 
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idMot"></param>
        /// <param name="idNiveauAcquisition"></param>
        /// <returns></returns>

        public static bool creationAcquisition_leMot(int idUtilisateur, int idMot, int idNiveauAcquisition)
        {
            try
            {
                string req = "INSERT INTO acquisition_lemot(idUtilisateur, idMot, idNiveauAcquisition) VALUES (@idUtilisateur,@idMot,@idNiveauAcquisition);";

                Dictionary<string, object> parameters = new Dictionary<string, object>
             {
                 {"@idUtilisateur", idUtilisateur},
                 {"@idMot", idMot},
                 {"@idNiveauAcquisition", idNiveauAcquisition}

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

        public static bool creationGrade(int idUtilisateur)
        {
            try
            {
                string req = "INSERT INTO grade_utilisateur(idUtilisateur, idGrade, scoreUtilisateur) " +
                    "VALUES(@idUtilisateur,'2','0')";

                Dictionary<string, object> parameters = new Dictionary<string, object>
             {
                 {"@idUtilisateur", idUtilisateur},
                 
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

        public static bool creationNiveau(int idUtilisateur, int idJeu)
        {
            try
            {
                string req = "INSERT INTO niveau_utilisateur_jeu(idUtilisateur, idJeu, idNiveau) VALUES (@idUtilisateur, @idJeu, '1')";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idUtilisateur", idUtilisateur},
                     {"@idJeu", idJeu},

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
        /// Permet de récupérer tous les n°identifiant des acquisitions de mot
        /// </summary>
        public static List<int> recupereTousIdAcquisitionLeMot()
        {
            List<int> lstIdAcquisitionLeMot = new List<int>();

            string req = "SELECT idAcquis FROM acquisition_lemot;";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idAcquisition = ((int)curs.Field("idAcquis"));

                lstIdAcquisitionLeMot.Add(idAcquisition);
            }

            curs.Close();

            return lstIdAcquisitionLeMot;
        }
        /// <summary>
        /// Permet de supprimer les tuples d'un utilisateur de la table acquisition_lemot
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static bool supprimeAcquisitionLeMot(int idUtilisateur)
        {
            try
            {
                string req = "DELETE FROM acquisition_lemot WHERE acquisition_lemot.idUtilisateur = @idUtilisateur;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
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

        /// <summary>
        /// Permet de supprimer toutes les missions d'un utilisateur
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static bool supprimeMissionsCarnet(int idUtilisateur)
        {
            try
            {
                string req = "DELETE FROM carnet_de_mission WHERE carnet_de_mission.idUtilisateur = @idUtilisateur;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
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

        /// <summary>
        /// Permet de récupérer tous les numéros identifiant des missions de la base
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static List<int> recupereTousLesIdMissions(int idUtilisateur)
        {
            List<int> lstIdMissions = new List<int>();

            string req = "SELECT idMission FROM carnet_de_mission WHERE idUtilisateur = @idUtilisateur;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@idUtilisateur", idUtilisateur}
                };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int idMissions = ((int)curs.Field("idMission"));

                lstIdMissions.Add(idMissions);
            }

            curs.Close();

            return lstIdMissions;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Gestion des grades - tabPage 4
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Grade> recupereTousLesGrades()
        {
            List<Grade> lstGrades = new List<Grade>();

            string req = "SELECT idGrade, libelle_grade, score_palier FROM grade WHERE idGrade > 1";

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idGrade = ((int)curs.Field("idGrade"));
                string libelle_grade = ((string)curs.Field("libelle_grade"));

                int score_pallier = ((int)curs.Field("score_palier"));


                lstGrades.Add(new Grade(idGrade, libelle_grade, score_pallier));
            }

            curs.Close();

            return lstGrades;
        }

        public static List<Avatar> recupereTousLesAvatarsDuGrade(string grade)
        {
            List<Avatar> lstAvatarsDuGrade = new List<Avatar>();

            string req = "SELECT idAvatar, nom, url, grade.libelle_grade " +
                "FROM avatars " +
                "INNER JOIN grade ON grade.idGrade = avatars.idGrade " +
                "WHERE grade.libelle_grade = @Grade;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@Grade", grade}
                };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int idAvatar = ((int)curs.Field("idAvatar"));
                string nom = ((string)curs.Field("nom"));
                string url = ((string)curs.Field("url"));

                string libelle_grade = ((string)curs.Field("libelle_grade"));


                lstAvatarsDuGrade.Add(new Avatar(idAvatar, nom, url, libelle_grade));
            }

            curs.Close();

            return lstAvatarsDuGrade;
        }

        public static bool modifieGrade(int idGrade, string libelle_grade, int score_palier)
        {            
             try
            {
                string req = "UPDATE grade SET libelle_grade = @libelle_grade, score_palier = @score_palier WHERE idGrade = @idGrade";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idGrade", idGrade},
                            {"@libelle_grade", libelle_grade},
                            {"@score_palier", score_palier},                            
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

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Gestion des niveaux - tabPage 5
        //////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static List<string> recupereTousLesJeux()
        {
            List<string> lstTousLesJeux = new List<string>();

            string req = "SELECT nomJeu FROM jeux;";

           
            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                string jeu = ((string)curs.Field("nomJeu"));


                lstTousLesJeux.Add(jeu);
            }

            curs.Close();

            return lstTousLesJeux;
        }

        public static List<string> recupereLesNiveauxPourUnJeu(string nomDuJeu)
        {
            List<string> lstTousLesNiveauxDuJeu = new List<string>();

            string req = "SELECT niveau " +
                "FROM niveau " +
                "INNER JOIN jeux ON jeux.idJeu = niveau.idJeu " +
                "WHERE jeux.nomJeu = @nomDuJeu " +
                "ORDER BY niveau.hierarchie;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@nomDuJeu", nomDuJeu},                            
                        };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                string niveauDeJeu = ((string)curs.Field("niveau"));
                lstTousLesNiveauxDuJeu.Add(niveauDeJeu);
            }

            curs.Close();

            return lstTousLesNiveauxDuJeu;
        }       

        public static List<int> recupereLesGainsDUnNiveauPourUnJeu(string nomDuNiveau, string nomDuJeu)
        {
            List<int> lstGainsDUnNiveauPourUnJeu = new List<int>();

            string req = "SELECT score_gagne " +
                "FROM gain_de_score " +
                "INNER JOIN niveau ON niveau.idNiveau = gain_de_score.idNiveau " +
                "INNER JOIN jeux ON jeux.idJeu = niveau.idJeu " +
                "WHERE niveau.niveau = @nomDuNiveau AND jeux.nomJeu = @nomDuJeu";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@nomDuNiveau", nomDuNiveau},
                            {"@nomDuJeu", nomDuJeu},
                        };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int score_gagne = ((int)curs.Field("score_gagne"));
                lstGainsDUnNiveauPourUnJeu.Add(score_gagne);
            }

            curs.Close();

            return lstGainsDUnNiveauPourUnJeu;
        }

        public static int recuperePalierNbAcquisNiveau(string nomDuNiveau, string nomDuJeu)
        {
            int palierNbAcquis = 0;

            string req = "SELECT palier_nbAcquis " +
                "FROM niveau " +
                "INNER JOIN jeux ON jeux.idJeu = niveau.idJeu " +
                "WHERE niveau.niveau = @nomDuNiveau AND jeux.nomJeu = @nomDuJeu";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@nomDuNiveau", nomDuNiveau},
                            {"@nomDuJeu", nomDuJeu},
                        };

            BddMySql curs = BddMySql.GetInstance();
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int palier_nbAcquis = ((int)curs.Field("palier_nbAcquis"));
                palierNbAcquis = palier_nbAcquis;
            }

            curs.Close();

            return palierNbAcquis;
        }
        public static bool modifieNiveau(string libelleNiveau, string nomDuJeu, int palier_nbAcquis, int gainMission, int gainSerie, int hierarchie)
        {
            try
            {
                string req = "UPDATE niveau " +
                    "INNER JOIN jeux ON jeux.idJeu = niveau.idJeu " +
                    "SET niveau = @libelleNiveau, palier_nbAcquis = @palier_nbAcquis, gainMission = @gainMission, gainSerie = @gainSerie " +
                    "WHERE jeux.nomJeu = @nomDuJeu AND niveau.hierarchie = @hierarchie";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@libelleNiveau", libelleNiveau},
                            {"@palier_nbAcquis", palier_nbAcquis},
                            {"@gainMission", gainMission},
                            {"@gainSerie", gainSerie},
                            {"@hierarchie", hierarchie},
                            {"@nomDuJeu", nomDuJeu},
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
    }

}
