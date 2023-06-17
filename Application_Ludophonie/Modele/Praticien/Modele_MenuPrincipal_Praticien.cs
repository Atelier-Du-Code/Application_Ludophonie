using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Praticien
{
    public static class Modele_MenuPrincipal_Praticien
    {
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Page d'accueil - tabPage 1
        //////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Permet de récupérer toutes les séries effectuées pour tous les utilisateurs
        /// </summary>
        /// <returns></returns>
        public static List<Serie> recupereToutesLesSeries()
        {
            List<Serie> lstToutesSeriesEffectuees = new List<Serie>();

            string req = "SELECT utilisateurs.idUtilisateur, utilisateurs.nom, utilisateurs.prenom, jeux.nomJeu, s.nbQuestionsDeLaSerie, s.nbErreur, s.dateDuJour, s.timer ";
            req += "FROM series_effectuees AS s ";
            req += "INNER JOIN utilisateurs ON s.idUtilisateur = utilisateurs.idUtilisateur ";
            req += "INNER JOIN jeux ON s.idJeu = jeux.idJeu ORDER BY s.dateDuJour DESC";


            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestionsDeLaSerie = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));

                lstToutesSeriesEffectuees.Add(new Serie(idUtilisateur, nom, prenom, nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer));
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

            string req = "SELECT utilisateurs.idUtilisateur, utilisateurs.nom, utilisateurs.prenom, jeux.nomJeu, s.nbQuestionsDeLaSerie, s.nbErreur, s.dateDuJour, s.timer ";
            req += "FROM series_effectuees AS s ";
            req += "INNER JOIN utilisateurs ON s.idUtilisateur = utilisateurs.idUtilisateur ";
            req += "INNER JOIN jeux ON s.idJeu = jeux.idJeu ";
            req += "WHERE s.dateDuJour = CURRENT_DATE() ORDER BY s.dateDuJour DESC";


            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestionsDeLaSerie = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));

                lstSeriesEffectueesAujourdhui.Add(new Serie(idUtilisateur, nom, prenom, nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer));
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

            string req = "SELECT utilisateurs.idUtilisateur, utilisateurs.nom, utilisateurs.prenom, jeux.nomJeu, s.nbQuestionsDeLaSerie, s.nbErreur, s.dateDuJour, s.timer ";
            req += "FROM series_effectuees AS s ";
            req += "INNER JOIN utilisateurs ON s.idUtilisateur = utilisateurs.idUtilisateur ";
            req += "INNER JOIN jeux ON s.idJeu = jeux.idJeu ";
            req += "WHERE s.dateDuJour BETWEEN CURRENT_DATE() - INTERVAL 7 DAY AND CURRENT_DATE() ORDER BY s.dateDuJour DESC;";


            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestionsDeLaSerie = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));

                lstSeriesEffectueesSemaine.Add(new Serie(idUtilisateur, nom, prenom, nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer));
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

            string req = "SELECT utilisateurs.idUtilisateur, utilisateurs.nom, utilisateurs.prenom, jeux.nomJeu, s.nbQuestionsDeLaSerie, s.nbErreur, s.dateDuJour, s.timer ";
            req += "FROM series_effectuees AS s ";
            req += "INNER JOIN utilisateurs ON s.idUtilisateur = utilisateurs.idUtilisateur ";
            req += "INNER JOIN jeux ON s.idJeu = jeux.idJeu ";
            req += "WHERE s.dateDuJour BETWEEN CURRENT_DATE() - INTERVAL 30 DAY AND CURRENT_DATE() ORDER BY s.dateDuJour DESC;";


            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idUtilisateur = ((int)curs.Field("idUtilisateur"));
                string nom = ((string)curs.Field("nom"));
                string prenom = ((string)curs.Field("prenom"));
                string nomJeu = ((string)curs.Field("nomJeu"));
                int nbQuestionsDeLaSerie = ((int)curs.Field("nbQuestionsDeLaSerie"));
                int nbErreur = ((int)curs.Field("nbErreur"));
                DateTime dateDuJour = ((DateTime)curs.Field("dateDuJour"));
                DateTime timer = ((DateTime)curs.Field("timer"));

                lstSeriesEffectueesMois.Add(new Serie(idUtilisateur, nom, prenom, nomJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer));
            }

            curs.Close();

            return lstSeriesEffectueesMois;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Catalogue des patients - tabPage 2
        //////////////////////////////////////////////////////////////////////////////////////////////////
               
        /// <summary>
        /// Permet de récupérer toutes les informations d'un patient grâce à son identifiant
        /// </summary>
        /// <param name="unIdentifiant"></param>
        /// <returns></returns>
        public static Utilisateur recuperePatient(string unIdentifiant)
        {

            Utilisateur patientRecupere = null;

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


                patientRecupere = new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, classe, password, adresse_Avatar);
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

            string req = "SELECT u.idUtilisateur,u.identifiant, u.nom, u.prenom, u.classe, u.password, avatars.url, type_utilisateur.type ";
            req += "FROM utilisateurs AS u ";
            req += "INNER JOIN avatars ON u.idAvatar = avatars.idAvatar ";
            req += "INNER JOIN type_utilisateur ON u.idTypeUtilisateur = type_utilisateur.idTypeUtilisateur ";
            req += "WHERE type_utilisateur.idTypeUtilisateur = 1";


            BddMySql curs = BddMySql.GetInstance(connectionString);
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


                lstTousLesPatients.Add(new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, classe, password, adresse_Avatar));
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
            try
            {
                string req = "INSERT INTO `utilisateurs`(`identifiant`, `nom`, `prenom`, `classe`, `password`, `idAvatar`, `idTypeUtilisateur`, `date_inscription`) VALUES ";
                req += "(@identifiant, @nom, @prenom, @classe, @password, 1, 1, CURRENT_DATE())";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@identifiant", nouvelUtilisateur.Identifiant},
                            {"@nom", nouvelUtilisateur.Nom},
                            {"@prenom", nouvelUtilisateur.Prenom},
                            {"@classe", nouvelUtilisateur.Classe},
                            {"@password", nouvelUtilisateur.Password},
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
        /// Permet de modifier un utilisateur
        /// </summary>
        /// <param name="UtilisateurAModifier"></param>
        /// <returns></returns>
        public static bool ModifieUtilisateur(Utilisateur UtilisateurAModifier)
        {
            try
            {
                string req = "UPDATE utilisateurs SET identifiant = @identifiant, nom = @nom, prenom = @prenom, classe = @classe, password = @password WHERE utilisateurs.idUtilisateur = @idUtilisateur;";

                        Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", UtilisateurAModifier.IdUtilisateur},
                            {"@identifiant", UtilisateurAModifier.Identifiant},
                            {"@nom", UtilisateurAModifier.Nom},
                            {"@prenom", UtilisateurAModifier.Prenom},
                            {"@classe", UtilisateurAModifier.Classe},
                            {"@password", UtilisateurAModifier.Password},
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
                BddMySql curs = BddMySql.GetInstance(connectionString);
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
               
                string req2 = "DELETE " +
                    "FROM series_effectuees " +
                    "WHERE series_effectuees.idUtilisateur = @idUtilisateur";

                Dictionary<string, object> parameters2 = new Dictionary<string, object>
                        {
                            {"@idUtilisateur", utilisateurASupprimer.IdUtilisateur},

                        };

                BddMySql curs = BddMySql.GetInstance(connectionString);
                
                curs.ReqUpdate(req2, parameters2);

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

            BddMySql curs = BddMySql.GetInstance(connectionString);
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
        public static List<int>recupererTouslstidPatient()
        {
            List<int> lstIdPatient = new List<int>();

            string req = "SELECT utilisateurs.idUtilisateur FROM utilisateurs WHERE utilisateurs.idTypeUtilisateur = 1;";


            BddMySql curs = BddMySql.GetInstance(connectionString);
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

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                plusGrandIdPatitent = ((int)curs.Field("idMaxPatient"));
            }

            curs.Close();

            return plusGrandIdPatitent;
        }

        /// <summary>
        /// Peremt de récupérer le nombre de mots enregistrés
        /// </summary>
        /// <returns></returns>
        public static int compteCombienMotsDansBDD()
        {
            int nbMots = 0;

            string req = "SELECT COUNT(mot) AS nbMots FROM lesmots;";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                nbMots = ((int)curs.Field("nbMots"));
            }

            curs.Close();

            return nbMots;
        }

        /// <summary>
        /// Permet de récupérer tous les mots enregistrés
        /// </summary>
        /// <returns></returns>
        public static List<int> recupereTousLesMots()
        {
            List<int> lstidMots = new List<int>();

            string req = "SELECT idMot FROM lesmots; ";

            BddMySql curs = BddMySql.GetInstance(connectionString);
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
