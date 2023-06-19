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
    /// Classe de test du Modèle pour la fiche de détail d'un patient
    /// </summary>
    [TestClass()]
    public class Modele_Detail_PatientTests
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

        int idUtilisateur = 2;

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie les noms de tous les jeux de la base
        /// </summary>
        [TestMethod()]
        public void recupereTousLesJeuxTest()
        {
            List<string> lstJeux = Modele_Detail_Patient.recupereTousLesJeux();
            Assert.AreNotEqual(0, lstJeux.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie toutes les séries effectuées concernant un utilisateur 
        /// </summary>
        [TestMethod()]
        public void recupereToutesSeriesUtilisateurTest()
        {
            List<Serie> lstSeries = Modele_Detail_Patient.recupereToutesSeriesUtilisateur(idUtilisateur);
            Assert.AreNotEqual(0, lstSeries.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie toutes les séries dd'un utilisateur, pour un jeu précis
        /// </summary>
        [TestMethod()]
        public void recupereToutesSeriesJeuTest()
        {
            string nomJeu = "Jeu du mot";
            List<Serie> lstSeries = Modele_Detail_Patient.recupereToutesSeriesJeu(idUtilisateur, nomJeu);
            Assert.AreNotEqual(0, lstSeries.Count, "Devrait réussir");
        }
    }
}