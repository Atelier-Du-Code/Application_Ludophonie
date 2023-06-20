using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Ludophonie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Ludophonie.Modele;
using Application_Ludophonie.Metier;

namespace Application_Ludophonie.Tests
{

    [TestClass()]
    public class AuthentificationTests
    {
        [TestMethod()]
        public void utilisateurExisteTest()
        {
            bool bUtilisateurExiste = Modele_Authentification.utilisateurExiste("jade_vidal");
            Assert.IsTrue(bUtilisateurExiste);
        }

        [TestMethod()]
        public void recupereUtilisateur()
        {
            Utilisateur unUtilisateur = Modele_Authentification.recupereUtilisateur("jade_vidal");
            Assert.IsNotNull(unUtilisateur, "Devrait réussir");
        }
    }
}