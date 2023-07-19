using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Patient
{
    /// <summary>
    /// Controleur - Classe de transition des données la modification de l'avatar - Côté patient
    /// </summary>
    public class Controleur_ModifAvatar
    {
        /// <summary>
        /// Permet de récupérer la liste de tous les avatars 
        /// </summary>
        /// <returns></returns>
        public List<Avatar> recuperelstAvatar()
        {
            List<Avatar> lstAvatar = Modele_ModifAvatar.recupereLstAvatar();

            return lstAvatar;
        }

        /// <summary>
        /// Permet de modifier l'avatar d'un patient dans la base
        /// </summary>
        /// <param name="idAvatar"></param>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public bool modifAvatar(int idAvatar, int idUtilisateur)
        {
            bool bModif = Modele_ModifAvatar.modifAvatar(idAvatar, idUtilisateur);
            return bModif;
        }

        public int compteAvatarDuPatient(int idGrade)
        {
            int nbAvatar = Modele_ModifAvatar.compteAvatarDuPatient(idGrade);
            return nbAvatar;
        }

    }
}
