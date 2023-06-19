using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Ludophonie.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppOrthophonie.BDD;
using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Praticien;

namespace Application_Ludophonie.Modele.Tests
{
    /// <summary>
    /// Classe de test du Modèle pour la page de modification de l'avatar d'un patient
    /// </summary>
    [TestClass()]
    public class Modele_ModifAvatarTests
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
        /// Permet de vérifier que la méthode du modèle renvoie la liste de tous les avatars
        /// </summary>
        [TestMethod()]
        public void recupereLstAvatarTest()
        {
            List<Avatar> lstAvatars = Modele_ModifAvatar.recupereLstAvatar();
            Assert.AreNotEqual(0, lstAvatars.Count, "Devrait réussir");
        }

        /// <summary>
        ///  Permet de vérifier que la méthode du modèle met correctement à jour l'avatar d'un patient après son changement
        /// </summary>
        [TestMethod()]
        public void modifAvatarTest()
        {
            DebutTransaction();

            List<Utilisateur> lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            Utilisateur utilisateur = lstpatients[0];

            List<Avatar> lstAvatars = Modele_ModifAvatar.recupereLstAvatar();

            int IdAvatar_Avant = 0;
            string urlAvatar_Apres = "";

            for (int i = 0; i<lstAvatars.Count; i++)
            {
                if(lstAvatars[i].Url == utilisateur.urlAvatar)
                {
                    IdAvatar_Avant = lstAvatars[i].IdAvatar;
                }

                if (lstAvatars[i].IdAvatar == 2)
                {
                    urlAvatar_Apres = lstAvatars[i].Url;
                }
            }           
          
            int idAvatar_Apres = 2;
            

            Modele_ModifAvatar.modifAvatar(idAvatar_Apres, utilisateur.IdUtilisateur);

            lstpatients.Clear();
            lstpatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            Utilisateur utilisateurModifie = lstpatients[0];

            bool identique = utilisateurModifie.urlAvatar.Equals(urlAvatar_Apres);

            Assert.AreEqual(true, identique, "Devrait fonctionner : Patient modifié");

            FinTransaction();
        }

    }
    
}