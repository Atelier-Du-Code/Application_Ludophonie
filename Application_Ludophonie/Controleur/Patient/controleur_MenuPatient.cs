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

        public string recupereLeGradeString(int idUtilisateur)
        {
            string grade = Modele_MenuPrincipal_Patient.recupereLeGradeString(idUtilisateur);
            return grade;
        }

        public int recupereLeGradeInt(int idUtilisateur)
        {
            int grade = Modele_MenuPrincipal_Patient.recupereLeGradeInt(idUtilisateur);
            return grade;
        }

        public string recupereNiveauPatient(int idUtilisateur)
        {
            string niveau = Modele_MenuPrincipal_Patient.recupereNiveauPatient(idUtilisateur);
            return niveau;
        }
    }

    
}
