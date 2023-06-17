using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Patient
{
    public class controleur_MenuPatient
    {
        public Avatar recupereAvatar(int idUtilisateur)
        {
            Avatar unAvatar = Modele_MenuPrincipal_Patient.recupereAvatar(idUtilisateur);
            return unAvatar;
        }
    }
}
