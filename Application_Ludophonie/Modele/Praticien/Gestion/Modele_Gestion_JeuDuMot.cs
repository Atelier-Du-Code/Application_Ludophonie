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


                lstTousMots.Add(new Mot(idMot, mot, contexte, nomListe));
            }

            curs.Close();

            return lstTousMots;
        }

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


                lstTousMots.Add(new Mot(idMot, mot, contexte, nomListe));
            }

            curs.Close();

            return lstTousMots;
        }

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
    }
}
