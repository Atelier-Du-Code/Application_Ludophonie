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
    /// Controleur - Classe de transition des données pour la gestion du carnet de mission - Côté particien
    /// </summary>
    public class Controleur_Gestion_Carnet__De_Mission
    {
        /// <summary>
        /// Permet de récupérer toutes les missions d'un patient
        /// </summary>
        /// <param name="unIdUtilisateur"></param>
        /// <returns></returns>
        public List<Mission> recupereToutesMissions(int unIdUtilisateur)
        {        
            List<Mission> lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(unIdUtilisateur);

            return lstMissions;
        }
        /// <summary>
        /// Permet de créer une nouvelle mission pour un patient
        /// </summary>
        /// <param name="mission"></param>
        /// <param name="unIdUtilisateur"></param>
        /// <returns></returns>
        public bool enregistreMissions(int idUtilisateur, int idJeu, int nbQuestions)
        {
            bool bMissionEnregistree = Modele_Gestion_Carnet_de_Missions.enregistreUneMission(idUtilisateur, idJeu, nbQuestions);
            
            return bMissionEnregistree;
        }

        public List<string> recupereTousLesJeux()
        {
            List<string> lstTousLesJeux = Modele_Gestion_Carnet_de_Missions.recupereTousLesJeux();
            return lstTousLesJeux;

        }


        /// <summary>
        /// Permet de supprimer une mission pour un patient
        /// </summary>
        /// <param name="mission"></param>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public bool supprimeUneMission(int idMission)
        {
            bool bSupprimeUneMission = Modele_Gestion_Carnet_de_Missions.supprimeUneMission(idMission);

            return bSupprimeUneMission;
        }

        /// <summary>
        /// Permet de supprimer toutes les missions d'un patient
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public bool supprimeToutesMissions(int idUtilisateur)
        {
            bool bSupprimeUneMission = Modele_Gestion_Carnet_de_Missions.supprimeToutesMissions(idUtilisateur);

            return bSupprimeUneMission;
        }
    }
}
