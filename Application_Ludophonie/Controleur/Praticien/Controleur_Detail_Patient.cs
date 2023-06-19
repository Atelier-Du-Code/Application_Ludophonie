using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Praticien
{
    /// <summary>
    /// Controleur - Classe de transition des données pour la fiche d'un patient - Côté praticien
    /// </summary>
    public class Controleur_Detail_Patient
    {
        /// <summary>
        /// Permet de récupérer tous les noms de jeux
        /// </summary>
        /// <returns></returns>
        public List<string> recupereTousLesJeux()
        {            
            List<string> lstJeux = Modele_Detail_Patient.recupereTousLesJeux();

            return lstJeux;
        }

        /// <summary>
        /// Permet de récupérer toutes les séries d'un utilisateur
        /// </summary>
        /// <param name="unIdUtilisateur"></param>
        /// <returns></returns>
        public List<Serie> recupereToutesSeriesUtilisateur(int unIdUtilisateur)
        {          
            List<Serie> lstToutesSeries = Modele_Detail_Patient.recupereToutesSeriesUtilisateur(unIdUtilisateur);

            return lstToutesSeries;
        }

        /// <summary>
        /// Permet de récupérer toutes les séries d'un jeu pour un patient
        /// </summary>
        /// <param name="unIdUtilisateur"></param>
        /// <param name="nomJeu"></param>
        /// <returns></returns>
        public List<Serie> recupereToutesSeriesJeu(int unIdUtilisateur, string nomJeu)
        {
            List<Serie> lstSeriesJeu = Modele_Detail_Patient.recupereToutesSeriesJeu(unIdUtilisateur, nomJeu);

            return lstSeriesJeu;
        }
    }
}
