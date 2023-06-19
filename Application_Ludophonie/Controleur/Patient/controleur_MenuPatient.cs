using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Patient
{
    /// <summary>
    /// Controleur - Classe de transition des données pour le menu principal - Côté patient
    /// </summary>
    public class controleur_MenuPatient
    {
        /// <summary>
        /// Permet de récupérer un avatar
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public Avatar recupereAvatar(int idUtilisateur)
        {
            Avatar unAvatar = Modele_MenuPrincipal_Patient.recupereAvatar(idUtilisateur);
            return unAvatar;
        }
    }
}
