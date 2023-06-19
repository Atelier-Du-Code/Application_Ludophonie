using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Ludophonie.Modele.Jeux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppOrthophonie.BDD;
using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Praticien;

namespace Application_Ludophonie.Modele.Jeux.Tests
{
    /// <summary>
    /// Classe de test du Modèle pour le jeu du mot
    /// </summary>
    [TestClass()]
    public class Modele_JeuDuMotTests
    {
        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password_BDD = "";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password_BDD
            + ";database=" + database + ";SslMode=none";

        private static readonly BddMySql access = BddMySql.GetInstance(connectionString);

        /// <summary>
        /// Permet de désactiver l'autocommit, commencer la transaction et de désactiver le contrôle des clés étrangères
        /// </summary>
        private void DebutTransaction()
        {
            access.ReqControle("SET AUTOCOMMIT = 0");
            access.ReqControle("START TRANSACTION");
            access.ReqControle("SET FOREIGN_KEY_CHECKS=0");
        }

        /// <summary>
        /// Permet d'annuler les tansactions initiées sur la base de données et de réactiver le contrôle des clés étrangères
        /// </summary>
        private void FinTransaction()
        {
            access.ReqControle("ROLLBACK");
            access.ReqControle("SET FOREIGN_KEY_CHECKS=1");
        }
        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie toutes les images necessaires à l'interface
        /// </summary>
        [TestMethod()]
        public void recupereImagesInterfaceTest()
        {
            List<Image> lstImages = Modele_JeuDuMot.recupereImagesInterface();
            Assert.AreNotEqual(0, lstImages.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie bien une liste de mots filtrés 
        /// sur leur numero d'identifiant utilisateur ainsi que sur le niveau acquisition du mot par le patient 
        /// </summary>
        [TestMethod()]
        public void recupereMotsParListeNiveauAcquisitionIdUtilisateurTest()
        {
            string liste = "Liste 0";
            int acquisition = 3;
            int idUtilisateur = 2;

            List<Mot> lstMots = Modele_JeuDuMot.recupereMotsParListeNiveauAcquisitionIdUtilisateur(liste, acquisition, idUtilisateur);
            Assert.AreNotEqual(0, lstMots.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle met correctement à jour les niveaux d'acquisition 
        /// des mots suivant leur utilisateur après une série du jeu du mot 
        /// </summary>
        [TestMethod()]
        public void updateDeLaBaseAvecMotsDeLaSerieTest()
        {
            DebutTransaction();

            //Infos acquisition
            int idMot = 89;
            int acquisition = 5;
            int idUtilisateur = 2;

            int idAcquisition_leMot_Avant = Modele_JeuDuMot.recuperelstNiveauxAcquisitionUtilisateur(idUtilisateur, idMot);


            Modele_JeuDuMot.updateDeLaBaseAvecMotsDeLaSerie(idUtilisateur, idMot, acquisition);

            int idAcquisition_leMot_Apres = Modele_JeuDuMot.recuperelstNiveauxAcquisitionUtilisateur(idUtilisateur, idMot);

           

            bool identique = idAcquisition_leMot_Apres.Equals(acquisition);

            Assert.AreEqual(true, identique, "Devrait fonctionner : Patient acquisition");            

            FinTransaction();
        }
        /// <summary>
        /// Permet de vérifier que la méthode du modèle permet bien de créer une série effectuée pour un utilisateur 
        /// après une série du jeu du mot
        /// </summary>
        [TestMethod()]
        public void creationSerieEffectueesTest()
        {
            DebutTransaction();

            //Récupération du nombre de serie avant l'insertion             
            List<Serie> lstSeries = Modele_MenuPrincipal_Praticien.recupereToutesLesSeries();
            int nbSeries_Avant = lstSeries.Count;


            //Création des nouvelles infos de la série 
            int idUtilisateur = 2;
            int idJeu = 1;
            int nbQuestionDeLaSerie = 25;
            int nbErreur = 1;
            DateTime dateDuJour = DateTime.Today;
            DateTime timer = new DateTime(2023, 12, 1, 0, 0, 20);

            //Création de la série
            Modele_JeuDuMot.creationSerieEffectuees(idUtilisateur, idJeu, nbQuestionDeLaSerie, nbErreur, dateDuJour, timer);

            lstSeries.Clear();
            lstSeries = Modele_MenuPrincipal_Praticien.recupereToutesLesSeries();
            int nbSeries_Apres = lstSeries.Count;           

            //Comparaison entre le nombe de séries avant et après insertion
            Assert.AreEqual(nbSeries_Avant + 1, nbSeries_Apres, "devrait réussir");

            FinTransaction();
        }
    }
}