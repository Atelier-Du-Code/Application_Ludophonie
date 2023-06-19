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

        private static string server = "127.0.0.1";
        private static string userid = "admin";
        private static string password = "****";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Permet de récupérer toutes les images d'interface
        /// </summary>
        /// <returns></returns>
        public static List<Image> recupereImagesInterface()
        {
            List<Image> lstToutesImagesInterfaces = new List<Image>();

            string req = "SELECT nom, url FROM images_interface";

            BddMySql curs = BddMySql.GetInstance(connectionString);
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

            BddMySql curs = BddMySql.GetInstance(connectionString);
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


            BddMySql curs = BddMySql.GetInstance(connectionString);
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
        public static bool creationSerieEffectuees(int idUtilisateur, int idjeu, int nbQuestionDeLaSerie, int nbErreur, DateTime dateDuJour, DateTime timer)
        {
            try
            {
                string req = "INSERT INTO series_effectuees(idUtilisateur, idJeu, nbQuestionsDeLaSerie, nbErreur, dateDuJour, timer) " +
                "VALUES(@idUtilisateur, @idjeu, @nbQuestionDeLaSerie, @nbErreur, @dateDuJour, @timer );";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idUtilisateur", idUtilisateur},
                    {"@idjeu", idjeu},
                    {"@nbQuestionDeLaSerie", nbQuestionDeLaSerie},
                    {"@nbErreur", nbErreur},
                    {"@dateDuJour", dateDuJour},
                    {"@timer", timer},

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
