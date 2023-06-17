using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Modele.Praticien.Gestion
{
    public static class Modele_Gestion_JeuDuMot
    {
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password = "";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Permet de récupérer tous les mots de la base de données
        /// </summary>
        /// <returns></returns>
        public static List<Mot> recupereTousLesMots()
        {
            List<Mot> lstTousMots = new List<Mot>();

            string req = "SELECT idMot, mot, contexte, niveaudelistes.nom_liste " +
                "FROM lesmots " +
                "INNER JOIN niveaudelistes ON lesmots.idListe = niveaudelistes.idListe; ";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                int idMot = ((int)curs.Field("idMot"));
                string mot = ((string)curs.Field("mot"));
                string contexte = ((string)curs.Field("contexte"));
                string nomListe = ((string)curs.Field("nom_liste"));


                lstTousMots.Add(new Mot(idMot, mot, contexte, nomListe, 0));
            }

            curs.Close();

            return lstTousMots;
        }

        /// <summary>
        /// Permet de récupérer tous les niveaux de liste
        /// </summary>
        /// <returns></returns>
        public static List<string> recupereToutesListes()
        {
            List<string> lstListes = new List<string>();

            string req = "SELECT nom_liste FROM niveaudelistes;";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {               
                string nomListe = ((string)curs.Field("nom_liste"));
                lstListes.Add(nomListe);
            }

            curs.Close();

            return lstListes;
        }

        /// <summary>
        /// Permet de récupérer tous les mots d'une liste
        /// </summary>
        /// <param name="liste"></param>
        /// <returns></returns>
        public static List<Mot> recupereToutLesMotsDeLaListe(string liste)
        {
            List<Mot> lstTousMots = new List<Mot>();

            string req = "SELECT idMot, mot, contexte, niveaudelistes.nom_liste " +
                "FROM lesmots " +
                "INNER JOIN niveaudelistes ON lesmots.idListe = niveaudelistes.idListe " +
                "WHERE nom_liste = @liste; ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
             {
                 {"@liste", liste}
             };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int idMot = ((int)curs.Field("idMot"));
                string mot = ((string)curs.Field("mot"));
                string contexte = ((string)curs.Field("contexte"));
                string nomListe = ((string)curs.Field("nom_liste"));


                lstTousMots.Add(new Mot(idMot, mot, contexte, nomListe, 0));
            }

            curs.Close();

            return lstTousMots;
        }

        /// <summary>
        /// Permet de récupérer un mot
        /// </summary>
        /// <param name="leMot"></param>
        /// <returns></returns>
        public static Mot recupereUnmot(string leMot)
        {
            Mot motARetourner = null;

            string req = "SELECT idMot, mot, contexte, idListe FROM lesmots WHERE lesmots.mot = @mot;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@mot", leMot},

                };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                int idMot = ((int)curs.Field("idMot"));
                string libelleMot = ((string)curs.Field("mot"));
                string contexte = ((string)curs.Field("contexte"));
                string nomListe = ((string)curs.Field("nom_liste"));


                motARetourner = new Mot(idMot, libelleMot, contexte, nomListe, 0);
            }

            curs.Close();
            return motARetourner;
        }

        /// <summary>
        /// Permet d'enregistrer un mot 
        /// </summary>
        /// <param name="mot"></param>
        /// <param name="contexte"></param>
        /// <param name="liste"></param>
        /// <returns></returns>
        public static bool enregistreUnMot(string mot, string contexte, int liste)
        {
            try
            {
                string req = "INSERT INTO `lesmots`(`mot`, `contexte`, `idListe`) VALUES (@mot, @contexte, @liste); ";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@mot", mot},
                    {"@contexte", contexte},
                    {"@liste", liste}
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
        /// Permet de supprimer un mot
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public static bool supprimeUnMot(string mot)
        {
            try
            {
                string req = "DELETE FROM `lesmots` WHERE mot = @mot;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@mot", mot},                    
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
        /// Permet de récuperer le dernier mot créé
        /// </summary>
        /// <returns></returns>
        public static int recupereDernierMotCree()
        {
            int dernierId = 0;
            string req = "SELECT MAX(idMot) AS dernierId FROM lesmots;";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                dernierId = ((int)curs.Field("dernierId"));               
            }

            curs.Close();

            return dernierId;
        }

        /// <summary>
        /// Permet de récupérer la liste de tout les n° identifiant des patients
        /// </summary>
        /// <returns></returns>
        public static List<int> lstidPatient()
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
        /// Permet de créer des tuples dans la table acquisition_lemot afin de stoker le niveau d'acquisition de chaque mot
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
        /// Permet de supprimer tous les tuples correspondant à ce mot dans la table acquisition_leMot
        /// </summary>
        /// <param name="idPatient"></param>
        /// <param name="idMot"></param>
        /// <returns></returns>
        public static bool supprimeTuplesBDD(int idPatient, int idMot)
        {
            try
            {
                string req = "DELETE FROM acquisition_lemot WHERE acquisition_lemot.idUtilisateur = @idPatient AND acquisition_lemot.idMot = @idMot;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                     {"@idPatient", idPatient},
                     {"@idMot", idMot}
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
