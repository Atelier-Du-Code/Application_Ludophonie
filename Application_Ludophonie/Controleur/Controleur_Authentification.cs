using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur
{
    /// <summary>
    /// Controleur - Classe de transition des données pour l'authentification
    /// </summary>
    public class Controleur_Authentification
    {
        /// <summary>
        /// Permet de récupérer les informations d'un patient
        /// </summary>
        /// <param name="unIdentifiant"></param>
        /// <returns></returns>
        public Utilisateur recupereUtilisateur(string unIdentifiant)
        {
            Utilisateur utilisateurAControler = Modele_Authentification.recupereUtilisateur(unIdentifiant);

            return utilisateurAControler;
        }

        /// <summary>
        /// Permet de vérifier si un utilisateur existe
        /// </summary>
        /// <param name="unIdentifiant"></param>
        /// <returns></returns>
        public bool utilisateurExiste(string unIdentifiant)
        {
            bool bExiste = Modele_Authentification.utilisateurExiste(unIdentifiant);
            return bExiste;
        }
    }

}
