using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Ludophonie.Modele.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Ludophonie.Metier;
using AppOrthophonie.BDD;

namespace Application_Ludophonie.Modele.Praticien.Tests
{
    /// <summary>
    ///  Classe de test du Modèle pour le menu principal - Côté praticien
    /// <summary>
    [TestClass()]
    public class Modele_MenuPrincipal_PraticienTests
    {
        //////////////////////////////////////////////////////////////
        ///Utilisateur de test
        /////////////////////////////////////////////////////////////////
        private const int idUtilisateur = 2;
        private const string identifiant = "jade_vidal";
        private const string nom = "Vidal";
        private const string prenom = "Jade";
        private const string classe = "CE2";
        private const string password = "5w&rcRi29F6&*H";
        private const string type_utilisateur = "patient";
        private const string urlAvatar = "https://i.pinimg.com/564x/5d/a4/92/5da49261550d4e682fb1c38c0738d222.jpg";

        private static readonly Utilisateur patient = new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, classe, password, urlAvatar);

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
        /// Permet le ROLLBACK et réactive les clés étrangères
        /// </summary>
        private void FinTransaction()
        {
            access.ReqControle("ROLLBACK");
            access.ReqControle("SET FOREIGN_KEY_CHECKS=1");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie toutes les séries effectuées de la base
        /// </summary>
        [TestMethod()]
        public void recupereToutesLesSeriesTest()
        {
            List<Serie> lstPatients = Modele_MenuPrincipal_Praticien.recupereToutesLesSeries();
            Assert.AreNotEqual(0, lstPatients.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie toutes les séries effectuées aujourd'hui
        /// </summary>
        [TestMethod()]
        public void recupereLesSeriesEffectueesAujourdhuiTest()
        {
            List<Serie> lstPatients = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesAujourdhui();
            Assert.AreNotEqual(0, lstPatients.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie toutes les séries effectuées il y a moins de 7 jours 
        /// </summary>
        [TestMethod()]
        public void recupereLesSeriesEffectueesSemaineTest()
        {
            List<Serie> lstPatients = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesSemaine();
            Assert.AreNotEqual(0, lstPatients.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie toutes les séries effectuées il y a moins de 30 jours 
        /// </summary>
        [TestMethod()]
        public void recupereLesSeriesEffectueesMoisTest()
        {
            List<Serie> lstPatients = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesMois();
            Assert.AreNotEqual(0, lstPatients.Count, "Devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie  un patient grace à son identifiant
        /// </summary>
        [TestMethod()]
        public void recuperePatientTest()
        {
            Utilisateur unPatient = Modele_MenuPrincipal_Praticien.recuperePatient(patient.Identifiant);

            Assert.AreEqual(idUtilisateur, unPatient.IdUtilisateur, "Test doit être réussit");
            Assert.AreEqual(identifiant, unPatient.Identifiant, "Test doit être réussit");
            Assert.AreEqual(nom, unPatient.Nom, "Test doit être réussit");
            Assert.AreEqual(prenom, unPatient.Prenom, "Test doit être réussit");
            Assert.AreEqual(classe, unPatient.Classe, "Test doit être réussit");
            Assert.AreEqual(password, unPatient.Password, "Test doit être réussit");
            Assert.AreEqual(type_utilisateur, unPatient.Type_Utilisateur, "Test doit être réussit");
            Assert.AreEqual(urlAvatar, unPatient.urlAvatar, "Test doit être réussit");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle renvoie tous les patients de la base
        /// </summary>
        [TestMethod()]
        public void recupereTousLesPatientsTest()
        {
            List<Utilisateur> lstPatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            Assert.AreNotEqual(0, lstPatients.Count, "devrait réussir");
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle crée correctement un utilisateur dans la base
        /// </summary>
        [TestMethod()]
        public void creeUtilisateurTest()
        {
            DebutTransaction();

            //Récupération du nombre de patients avant l'insertion 
            List<Utilisateur> lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            int nombreDePatients_Avant = lstpatients.Count;

            //Création des infos du nouveau patient
            int new_idUtilisateur = 2;
            string new_identifiant = "gerard85";
            string new_nom = "Vidal";
            string new_prenom = "Jade";
            string new_classe = "CE2";
            string new_password = "5w&rcRi29F6&*H";
            string new_type_utilisateur = "patient";
            string new_urlAvatar = "https://i.pinimg.com/originals/69/4a/66/694a66860b36a48b6e58112dd16308c7.png";

            Utilisateur newUtilisateur = new Utilisateur(new_idUtilisateur, new_type_utilisateur, new_identifiant, new_nom, new_prenom,
                new_classe, new_password, new_urlAvatar);

            // Création effective du nouveau patient
            Modele_MenuPrincipal_Praticien.creeUtilisateur(newUtilisateur);

            //Récupération du nombre de patients après l'insertion 
            lstpatients.Clear();
            lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            int nombreDePatients_Apres = lstpatients.Count;

            Utilisateur utilisateurAjoute = lstpatients.Find(obj => obj.Identifiant.Equals(new_identifiant));
            Assert.IsNotNull(utilisateurAjoute, "devrait réussir");
            Assert.AreEqual(nombreDePatients_Avant + 1, nombreDePatients_Apres, "Devrait réussir");

            FinTransaction();

        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle modifie efficacement un utilisateur dans la base 
        /// </summary>
        [TestMethod()]
        public void ModifieUtilisateurTest()
        {
            DebutTransaction();

            List<Utilisateur> lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            int nombreDePatients_Avant = lstpatients.Count;

            if (lstpatients.Count > 0)
            {
                Utilisateur patientAModifier = lstpatients[1];

                //Création des infos du nouveau patient                
                string new_identifiant = "gerard85";
                string new_nom = "Vidal";
                string new_prenom = "Jade";
                string new_classe = "CE2";
                string new_password = "5w&rcRi29F6&*H";
                string new_type_utilisateur = "patient";                

                patientAModifier.Identifiant = new_identifiant;
                patientAModifier.Nom = new_nom;
                patientAModifier.Prenom = new_prenom;
                patientAModifier.Classe = new_classe;
                patientAModifier.Password = new_password;
                patientAModifier.Type_Utilisateur = new_type_utilisateur;                

                Modele_MenuPrincipal_Praticien.ModifieUtilisateur(patientAModifier);

                lstpatients.Clear();
                lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
                int nombreDePatients_Apres = lstpatients.Count;

                Utilisateur utilisateurMisAJour = lstpatients[1];

                if (utilisateurMisAJour != null)
                {
                    bool identique = utilisateurMisAJour.Type_Utilisateur.Equals(new_type_utilisateur)
                        && utilisateurMisAJour.Identifiant.Equals(new_identifiant)
                        && utilisateurMisAJour.Nom.Equals(new_nom)
                        && utilisateurMisAJour.Prenom.Equals(new_prenom)
                        && utilisateurMisAJour.Classe.Equals(new_classe)
                        && utilisateurMisAJour.Password.Equals(new_password);                        
                    Assert.AreEqual(true, identique, "Devrait fonctionner : Patient modifié");
                }
                else
                {
                    Assert.Fail("patient perdu suite aux modifications");
                }

                Assert.AreEqual(nombreDePatients_Avant, nombreDePatients_Apres, "devrait réussir : autant de développeurs");

            }

            FinTransaction();
        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle supprime efficacement un patient dans la base
        /// </summary>
        [TestMethod()]
        public void SupprimeUtilisateurTest()
        {
            DebutTransaction();

            List<Utilisateur> lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            int nombreDePatients_Avant = lstpatients.Count;
            
            if (nombreDePatients_Avant > 0)
            {
                Utilisateur utilisateur = lstpatients[0];
                
                Modele_MenuPrincipal_Praticien.SupprimeUtilisateur(utilisateur.IdUtilisateur);

                lstpatients.Clear();
                lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();

                Utilisateur patientAupprimer = lstpatients.Find(obj => obj.IdUtilisateur.Equals(utilisateur.IdUtilisateur));
                Assert.IsNull(patientAupprimer, "Devrait réussir : patient supprimé");

                int nombreDePatients_Apres = lstpatients.Count;
                Assert.AreEqual(nombreDePatients_Avant - 1, nombreDePatients_Apres, "devrait réussir : un profil de moins");

            }

            FinTransaction();

        }

        /// <summary>
        /// Permet de vérifier que la méthode du modèle supprime efficacement toutes les séries d'un utilisateur
        /// </summary>
        [TestMethod()]
        public void SupprimeSesSeriesTest()
        {
            DebutTransaction();

            List<Serie> lstSeries = Modele_MenuPrincipal_Praticien.recupereToutesLesSeries();
            int nombreDeSeries_Avant = lstSeries.Count;

            Utilisateur utilisateur = Modele_MenuPrincipal_Praticien.recuperePatient(identifiant);
            
            int nbSerie_Avant = 0;            

            for(int i=0; i<lstSeries.Count; i++)
            {
                if (lstSeries[i].IdUtilisateur == utilisateur.IdUtilisateur)
                {
                    nbSerie_Avant++;
                }
            }            

            if (nombreDeSeries_Avant > 0)
            {
                Modele_MenuPrincipal_Praticien.SupprimeSesSeries(utilisateur);

                lstSeries.Clear();
                lstSeries = Modele_MenuPrincipal_Praticien.recupereToutesLesSeries();

                int nbSeries_Apres = 0;

                for (int i = 0; i < lstSeries.Count; i++)
                {
                    if (lstSeries[i].IdUtilisateur == utilisateur.IdUtilisateur)
                    {
                        nbSeries_Apres++;
                    }
                }
                
                Assert.AreEqual(0, nbSeries_Apres, "Devrait réussir : série supprimé");
               
            }

            FinTransaction();
        }

        /// <summary>
        /// Permet de vérifier si la méthode du modèle récupère bien le nombre de patients total de la base
        /// </summary>
        [TestMethod()]
        public void compteCombienPatientDansBDDTest()
        {
            List<Utilisateur> lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            int nombreDePatients = lstpatients.Count;

            Assert.AreEqual(nombreDePatients, 3, "Devrait réussir : 3 patients sont rescencés dans la base");
        }

        /// <summary>
        ///  Permet de vérifier si la méthode du modèle récupère bien la liste des numéros d'identifiant de tous les patients
        /// </summary>
        [TestMethod()]
        public void recupererTouslstidPatientTest()
        {
            List<int> lstIdPatients = Modele_MenuPrincipal_Praticien.recupererTouslstidPatient();
            Assert.AreNotEqual(0, lstIdPatients.Count, "devrait réussir");
        }

        /// <summary>
        ///  Permet de vérifier si la méthode du modèle récupère correctement le numero identifiant du patient le plus récent
        /// </summary>
        [TestMethod()]
        public void recuperePlusGrandIdPatientTest()
        {
            int idPatientLePlusGrand = Modele_MenuPrincipal_Praticien.recuperePlusGrandIdPatient();
            Assert.AreEqual(idPatientLePlusGrand, 5, "devrait réussir");
        }

        /// <summary>
        ///  Permet de vérifier si la méthode du modèle récupère correctement la liste de tous les mots 
        /// </summary>
        [TestMethod()]
        public void recupereTousLesMotsTest()
        {
            List<int> lstIdMot = Modele_MenuPrincipal_Praticien.recupereTousLesMots();
            int nbIdMot = lstIdMot.Count;

            Assert.AreEqual(144, nbIdMot, "devrait réussir");
        }


        /// <summary>
        /// Permet de vérifier que la méthode du modèle créé correctement les acquisitions d'un utilisateur
        /// </summary>
        [TestMethod()]
        public void creationAcquisition_leMotTest()
        {
            DebutTransaction();

            //Récupération du nombre de d'acquisition avant l'insertion             
            List<int>lstAcquisition = Modele_MenuPrincipal_Praticien.recupereTousIdAcquisitionLeMot();
            int nbAcquisitions_Avant = lstAcquisition.Count;


            //Création des nouvelles infos de l'acquisition 
            int idUtilisateur = 2;
            int idMot = 101;
            int idNiveauAcquisition = 1;

            //Création de l'acquisition 
            Modele_MenuPrincipal_Praticien.creationAcquisition_leMot(idUtilisateur, idMot, idNiveauAcquisition);


            lstAcquisition.Clear();
            lstAcquisition = Modele_MenuPrincipal_Praticien.recupereTousIdAcquisitionLeMot();
            int nbAcquisitions_Apres = lstAcquisition.Count;

            //Comparaison entre le nombe d'acquisition avant et après insertion
            Assert.AreEqual(nbAcquisitions_Avant +1, nbAcquisitions_Apres, "devrait réussir");

            FinTransaction();
        }


        /// <summary>
        /// Permet de vérifier que la méthode du modèle supprime efficacement toutes les acquisitions d'un utilisateur
        /// </summary>
        [TestMethod()]
        public void supprimeAcquisitionLeMotTest()
        {
            DebutTransaction();

            //Récupération du nombre de d'acquisition avant la suppression             
            List<int> lstAcquisition = Modele_MenuPrincipal_Praticien.recupereTousIdAcquisitionLeMot();
            int nbAcquisitions_Avant = lstAcquisition.Count;

            List<int> lstTousLesMots = Modele_MenuPrincipal_Praticien.recupereTousLesMots();
            int nbMots = lstTousLesMots.Count;


            //Création des nouvelles infos de l'acquisition 
            int idUtilisateur = 2;       
            

            //Création de l'acquisition 
            Modele_MenuPrincipal_Praticien.supprimeAcquisitionLeMot(idUtilisateur);


            lstAcquisition.Clear();
            lstAcquisition = Modele_MenuPrincipal_Praticien.recupereTousIdAcquisitionLeMot();
            int nbAcquisitions_Apres = lstAcquisition.Count;

            //Comparaison entre le nombe d'acquisition avant et après insertion
            Assert.AreEqual(nbAcquisitions_Avant - nbMots, nbAcquisitions_Apres, "devrait réussir");

            FinTransaction();
        }


        /// <summary>
        /// Permet de vérifier que la méthode du modèle supprime efficacement toutes les missions d'un utilisateur
        /// </summary>
        [TestMethod()]
        public void supprimeMissionsCarnetTest()
        {
            DebutTransaction();
            
            int idUtilisateur = 2;

            //Récupération du nombre de missions avant la suppression          
            List<int> lstMissions = Modele_MenuPrincipal_Praticien.recupereTousLesIdMissions(idUtilisateur);
            int nbMission = lstMissions.Count; 

            //Suppression
            Modele_MenuPrincipal_Praticien.supprimeMissionsCarnet(idUtilisateur);

            //Actualisation après suppression
            lstMissions.Clear();
            lstMissions = Modele_MenuPrincipal_Praticien.recupereTousLesIdMissions(idUtilisateur);
            int nbMission_Apres = lstMissions.Count;

            //Comparaison 
            Assert.AreEqual(0, nbMission_Apres, "devrait réussir");

            FinTransaction();
        }
    }
}