using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Ludophonie.Modele.Praticien.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppOrthophonie.BDD;
using Application_Ludophonie.Metier;

namespace Application_Ludophonie.Modele.Praticien.Gestion.Tests
{
    /// <summary>
    /// Classe de test du Modèle pour l'espace de gestion des mots de la base
    /// </summary>
    [TestClass()]
    public class Modele_Gestion_JeuDuMotTests
    {

        //////////////////////////////////////////////////////////////
        ///Connexion à la base de données
        /////////////////////////////////////////////////////////////////

        private static string server = "127.0.0.1";
        private static string userid = "root";
        private static string password_BDD = "";
        private static string database = "ludophonie";

        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password_BDD
            + ";database=" + database + ";SslMode=none";

        private static readonly BddMySql access = BddMySql.GetInstance(connectionString);


        /// <summary>
        /// Permet de désactiver l'auto-commit, de commencer une transaction et de déactiver les relation de clés étrangères
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
        /// Permet de vérifier que la méthode du modèle renvoie tous les mots de la base
        /// </summary>
        [TestMethod()]
        public void recupereTousLesMotsTest()
        {
            List<Mot> lstMots = Modele_Gestion_JeuDuMot.recupereTousLesMots();
            Assert.AreNotEqual(0, lstMots.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie tous les niveaux de liste de la base
        /// </summary>
        [TestMethod()]
        public void recupereToutesListesTest()
        {
            List<string> lstListes = Modele_Gestion_JeuDuMot.recupereToutesListes();
            Assert.AreNotEqual(0, lstListes.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie tous les mots d'une même liste
        /// </summary>
        [TestMethod()]
        public void recupereToutLesMotsDeLaListeTest()
        {
            string liste = "Liste 0";
            List<Mot> lstListes = Modele_Gestion_JeuDuMot.recupereToutLesMotsDeLaListe(liste);
            Assert.AreNotEqual(0, lstListes.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie bien un mot demandé de la base
        /// </summary>
        [TestMethod()]
        public void recupereUnmotTest()
        {
            string mot = "le";
            Mot leMot = Modele_Gestion_JeuDuMot.recupereUnmot(mot);
            Assert.AreNotEqual(0, leMot, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie de ldernier mot créé
        /// </summary>
        [TestMethod()]
        public void recupereDernierMotCreeTest()
        {
            int leMot = Modele_Gestion_JeuDuMot.recupereDernierMotCree();
            Assert.AreNotEqual(0, leMot, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie tous les numéros d'identifiant des patients de la base
        /// </summary>
        [TestMethod()]
        public void lstidPatientTest()
        {
            List<int> lstIdPatients = Modele_Gestion_JeuDuMot.lstidPatient();
            Assert.AreNotEqual(0, lstIdPatients, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle enregistre correctement les mots 
        /// </summary>
        [TestMethod()]
        public void enregistreUnMotTest()
        {
            DebutTransaction();
            List<Mot> lstMots = Modele_Gestion_JeuDuMot.recupereTousLesMots();
            int nbMots_Avant = lstMots.Count;

            //Création des infos du mot
            string mot = "le";
            string contexte = "Le chien est gentil";
            int liste = 1;

            Modele_Gestion_JeuDuMot.enregistreUnMot(mot, contexte, liste);

            lstMots.Clear();

            lstMots = Modele_Gestion_JeuDuMot.recupereTousLesMots();
            int nbMots_Apres = lstMots.Count;

            Assert.AreEqual(nbMots_Avant +1, nbMots_Apres, "Devrait réussir");

            FinTransaction();
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle ajoute correctement les acquisitions de mots 
        /// </summary>
        [TestMethod()]
        public void creationAcquisition_leMotTest()
        {
            DebutTransaction();

            List<int> lstIdAcquisitions = Modele_Gestion_JeuDuMot.recupereLstIdAcquisitions();
            int nbAcquis_Avant = lstIdAcquisitions.Count;

            //Création des infos du mot
            int idUtilisateur = 2;
            int idMot = 101;
            int idNiveauAcquisition = 1;

            Modele_Gestion_JeuDuMot.creationAcquisition_leMot(idUtilisateur, idMot, idNiveauAcquisition);

            lstIdAcquisitions.Clear();
            lstIdAcquisitions = Modele_Gestion_JeuDuMot.recupereLstIdAcquisitions();
            int nbAcquis_Apres = lstIdAcquisitions.Count;

            Assert.AreEqual(nbAcquis_Avant + 1, nbAcquis_Apres, "Devrait réussir");

            FinTransaction();
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle supprime correctement un mot doné
        /// </summary>
        [TestMethod()]
        public void supprimeUnMotTest()
        {
            DebutTransaction();

            List<Mot> lstMots = Modele_Gestion_JeuDuMot.recupereTousLesMots();
            int nbMots_Avant = lstMots.Count;

            //Création des infos du mot
            string mot = "le";

            Modele_Gestion_JeuDuMot.supprimeUnMot(mot);

            lstMots.Clear();

            lstMots = Modele_Gestion_JeuDuMot.recupereTousLesMots();
            int nbMots_Apres = lstMots.Count;

            Assert.AreEqual(nbMots_Avant - 1, nbMots_Apres, "Devrait réussir");

            FinTransaction();
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle supprime efficacement les tuples concernant un utilisateur 
        /// et un mot dans la base de données 
        /// </summary>
        [TestMethod()]
        public void supprimeTuplesBDDTest()
        {
            DebutTransaction();

            List<int> lstIdAcquisitions = Modele_Gestion_JeuDuMot.recupereLstIdAcquisitions();
            int nbAcquis_Avant = lstIdAcquisitions.Count;

            //Création des infos
            int idPatient = 2;
            int idMot = 101;

            Modele_Gestion_JeuDuMot.supprimeTuplesBDD(idPatient, idMot);

            lstIdAcquisitions.Clear();
            lstIdAcquisitions = Modele_Gestion_JeuDuMot.recupereLstIdAcquisitions();
            int nbAcquis_Apres = lstIdAcquisitions.Count;

            Assert.AreEqual(nbAcquis_Avant - 1, nbAcquis_Apres, "Devrait réussir");

            FinTransaction();
        }
    }
}