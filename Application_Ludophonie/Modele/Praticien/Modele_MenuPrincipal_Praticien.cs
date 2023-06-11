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

        public static bool ModifieUtilisateur(Utilisateur UtilisateurAModifier)
        {
            try
            {
                string req = "INSERT INTO `utilisateurs`(`identifiant`, `nom`, `prenom`, `classe`, `password`, `idAvatar`, `idTypeUtilisateur`, `date_inscription`) VALUES ";
                req += "(@identifiant, @nom, @prenom, @classe, @password, 1, 1, CURRENT_DATE())";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
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

        public static bool SupprimeUtilisateur(Utilisateur utilisateurASupprimer)
        {
            try
            {
                string req1 = "DELETE utilisateurs FROM `utilisateurs` WHERE utilisateurs.identifiant = @identifiant;";

                Dictionary<string, object> parameters1 = new Dictionary<string, object>
                        {
                            {"@identifiant", utilisateurASupprimer.Identifiant},
                            
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

        public static bool SupprimeSesSeries(Utilisateur utilisateurASupprimer)
        {
            try
            {
               
                string req2 = "DELETE series_effectuees FROM `series_effectuees INNER JOIN utilisateurs ON series_effectuees.idUtilisateur = utilisateurs.idUtilisateur WHERE utilisateurs.idUtilisateur = idUtilisateur";

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
    }
}
