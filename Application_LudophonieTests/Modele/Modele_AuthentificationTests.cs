using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Ludophonie.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Ludophonie.Metier;

namespace Application_Ludophonie.Modele.Tests
{
    /// <summary>
    /// Classe de test du Modèle pour l'authentification
    /// </summary>
    [TestClass()]
    public class Modele_AuthentificationTests
    {
        private const int idUtilisateur = 2;
        private const string identifiant = "jade_vidal";
        private const string nom = "Vidal";
        private const string prenom = "Jade";
        private const string classe = "CE2";
        private const string password = "5w&rcRi29F6&*H";
        private const string type_utilisateur = "patient";
        private const string urlAvatar = "https://i.pinimg.com/originals/69/4a/66/694a66860b36a48b6e58112dd16308c7.png";


        private static readonly Utilisateur patient = new Utilisateur(idUtilisateur, type_utilisateur, identifiant, nom, prenom, classe, password, urlAvatar);


        /// <summary>
        /// Permet de vérifier que la méthode du modèle retrouve efficacement un patient si il est enregistré dans la base
        /// </summary>
        [TestMethod()]
        public void utilisateurExisteTest()
        {          
              
            Assert.IsTrue(Modele_Authentification.utilisateurExiste(patient.Identifiant),"devrait réussir : l'identifiant est correcte");

            string identifiantErreur = "nfrjkfn";
            Assert.IsFalse(Modele_Authentification.utilisateurExiste(identifiantErreur), "devrait rater : l'identifiant est incorrecte");
        }
    }
}