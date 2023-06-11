using Application_Ludophonie.Modele.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Praticien
{
    public class Controleur_Gestion_Carnet__De_Mission
    {
        public List<string> recupereToutesMissions(int unIdUtilisateur)
        {
            List<string> lstMissions = new List<string>();
            lstMissions = Modele_Gestion_Carnet_de_Missions.recupereToutesMissions(unIdUtilisateur);

            return lstMissions;
        }

        public bool enregistreMissions(string mission, int unIdUtilisateur)
        {
            bool bMissionEnregistree = Modele_Gestion_Carnet_de_Missions.enregistreUneMission(mission, unIdUtilisateur);
            
            return bMissionEnregistree;
        }

        public bool supprimeUneMission(string mission, int idUtilisateur)
        {
            bool bSupprimeUneMission = Modele_Gestion_Carnet_de_Missions.supprimeUneMission(mission, idUtilisateur);

            return bSupprimeUneMission;
        }

        public bool supprimeToutesMissions(int idUtilisateur)
        {
            bool bSupprimeUneMission = Modele_Gestion_Carnet_de_Missions.supprimeToutesMissions(idUtilisateur);

            return bSupprimeUneMission;
        }
    }
}
