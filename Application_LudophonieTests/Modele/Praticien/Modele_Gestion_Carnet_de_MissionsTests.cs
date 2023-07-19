using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Ludophonie.Modele.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppOrthophonie.BDD;
using Application_Ludophonie.Metier;

namespace Application_Ludophonie.Modele.Praticien.Tests
{
    /// <summary>
    /// Classe de test du Modèle pour la gestion du carnet de missions
    /// </summary>
    [TestClass()]
    public class Modele_Gestion_Carnet_de_MissionsTests
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

        private static readonly BddMySql access = BddMySql.GetInstance();

        readonly int idUtilisateur = 2;

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
        /// Permet de vérifier que la méthode du modèle renvoie toutes les missions de la base
        /// </summary>
        [TestMethod()]
        public void recupereToutesMissionsTest()
        {            
            List<Mission> lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(idUtilisateur);
            Assert.AreNotEqual(0, lstMissions.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle enregistre correctement les missions demandées
        /// </summary>
        [TestMethod()]
        public void enregistreUneMissionTest()
        {
            DebutTransaction();
            List<Mission> lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(idUtilisateur);
            int nbMission_Avant = lstMissions.Count;

            int idJeu = 1;
            int idNbQuestions = 5;
            Modele_Gestion_Carnet_de_Missions.enregistreUneMission(idUtilisateur, idJeu, idNbQuestions);

            lstMissions.Clear();
            lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(idUtilisateur);
            int nbMission_Apres = lstMissions.Count;

            Assert.AreEqual(nbMission_Avant + 1, nbMission_Apres, "Devrait réussir");

            FinTransaction();
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle supprimer efficacement une mission donnée
        /// </summary>
        [TestMethod()]
        public void supprimeUneMissionTest()
        {
            DebutTransaction();
            List<Mission> lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(idUtilisateur);
            int nbMission_Avant = lstMissions.Count;
            
            int idMissionASupprimer = lstMissions[0].IdMission;
            Modele_Gestion_Carnet_de_Missions.supprimeUneMission(idMissionASupprimer);

            lstMissions.Clear();
            lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(idUtilisateur);
            int nbMission_Apres = lstMissions.Count;

            Assert.AreEqual(nbMission_Avant -1, nbMission_Apres, "Devrait réussir");

            FinTransaction();
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle supprime efficacement toutes les missions d'un patient donné
        /// </summary>
        [TestMethod()]
        public void supprimeToutesMissionsTest()
        {
            DebutTransaction();
            List<Mission> lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(idUtilisateur);
            int nbMission_Avant = lstMissions.Count;
           
            Modele_Gestion_Carnet_de_Missions.supprimeToutesMissions(idUtilisateur);
            lstMissions.Clear();
            lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(idUtilisateur);
            int nbMission_Apres = lstMissions.Count;

            Assert.AreEqual(nbMission_Avant - nbMission_Avant, nbMission_Apres, "Devrait réussir");

            FinTransaction();
        }
    }
}