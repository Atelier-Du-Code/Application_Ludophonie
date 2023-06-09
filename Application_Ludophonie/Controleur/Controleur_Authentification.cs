using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur
{
    class Controleur_Authentification
    {
        public Utilisateur controleIdentite(string unIdentifiant)
        {
            Utilisateur utilisateurAControler = new Utilisateur(0, null, null, null, null, null, null, null);

            utilisateurAControler = Modele_Test.ControleIdentite(unIdentifiant);

            return utilisateurAControler;
        }
    }

}
