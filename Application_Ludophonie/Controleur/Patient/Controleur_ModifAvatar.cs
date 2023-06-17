using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Patient
{
    public class Controleur_ModifAvatar
    {
        public List<Avatar> recuperelstAvatar()
        {
            List<Avatar> lstAvatar = new List<Avatar>();
            lstAvatar = Modele_ModifAvatar.recupereLstAvatar();

            return lstAvatar;
        }

        public bool modifAvatar(int idAvatar, int idUtilisateur)
        {
            bool bModif = Modele_ModifAvatar.modifAvatar(idAvatar, idUtilisateur);
            return bModif;
        }

    }
}
