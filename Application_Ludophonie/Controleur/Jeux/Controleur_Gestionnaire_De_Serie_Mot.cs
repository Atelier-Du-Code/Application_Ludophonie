using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Jeux;
using Application_Ludophonie.Modele.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Jeux
{
    /// <summary>
    /// Controleur - Classe de transition des données pour la gestion des séries du jeu du mot - Côté patient
    /// </summary>
    public class Controleur_Gestionnaire_De_Serie_Mot
    {
        /// <summary>
        /// Permet de récupere tous les niveaux de listes 
        /// </summary>
        /// <returns></returns>
        public List<string> recupereToutesListes()
        {
            List<string> toutesListes = Modele_Gestionnaire_De_Serie_Mot.recupereToutesLesListes();

            return toutesListes;
        }

        public List<Mission> recupereToutesMissionsPourUnJeu(int unIdUtilisateur, int idJeu)
        {
            List<Mission> lstMissions = Modele_Gestionnaire_De_Serie_Mot.recupereToutesMissionsPourUnJeu(unIdUtilisateur, idJeu);

            return lstMissions;
        }
    }
}
