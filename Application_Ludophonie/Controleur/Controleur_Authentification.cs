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
        public Utilisateur recupereUtilisateur(string unIdentifiant)
        {
            Utilisateur utilisateurAControler = new Utilisateur(0, null, null, null, null, null, null, null);

            utilisateurAControler = Modele_Authentification.recupereUtilisateur(unIdentifiant);

            return utilisateurAControler;
        }

        public bool utilisateurExiste(string unIdentifiant)
        {
            bool bExiste = Modele_Authentification.utilisateurExiste(unIdentifiant);
            return bExiste;
        }
    }

}
