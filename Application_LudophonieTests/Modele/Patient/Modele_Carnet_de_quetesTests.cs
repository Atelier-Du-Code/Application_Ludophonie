using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Ludophonie.Modele.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppOrthophonie.BDD;
using Application_Ludophonie.Metier;

namespace Application_Ludophonie.Modele.Patient.Tests
{
    /// <summary>
    /// Classe de test du Modèle pour le carnet de missions
    /// </summary>
    [TestClass()]
    public class Modele_Carnet_de_quetesTests
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

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie toutes les missions de la base
        /// </summary>
        [TestMethod()]
        public void recupereLstMissionsTest()
        {
            int idUtilisateur = 2;
            List<Mission> lstMissions = Modele_Carnet_de_quetes.recupereToutesMissions(idUtilisateur);
            Assert.AreNotEqual(0, lstMissions.Count, "Devrait réussir");
        }
    }
}