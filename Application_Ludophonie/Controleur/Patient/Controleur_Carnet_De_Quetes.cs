using Application_Ludophonie.Modele.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Patient
{
    /// <summary>
    /// Controleur - Classe de transition des données pour le carnet de mission - Côté patient
    /// </summary>
    public class Controleur_Carnet_De_Quetes
    {
        /// <summary>
        /// Permet de récupérer toutes les missions d'un patient
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public List<string>recupereLstMissions(int idUtilisateur)
        {
            
            List<string> lstMissions = Modele_Carnet_de_quetes.recupereLstMissions(idUtilisateur);

            return lstMissions;
        }
    }
}
