using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Jeux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Jeux
{
    public class Controleur_JeuDuMot
    {
        public List<Image> recupereToutesImagesInterface()
        {
             List<Image> lstImages = new List<Image>();

            lstImages = Modele_JeuDuMot.recupereImagesInterface();

            return lstImages;
        }

        public List<Mot> recupereMotsParListeNiveauAcquisitionIdUtilisateur(string liste, int acquisition, int idUtilisateur)
        {
            List<Mot> lstMots = new List<Mot>();

            lstMots = Modele_JeuDuMot.recupereMotsParListeNiveauAcquisitionIdUtilisateur(liste, acquisition, idUtilisateur);

            return lstMots;
        }

        public bool updateDeLaBaseAvecMotsDeLaSerie(int IdUtilisateur, int idMot, int acquisition)
        {
            bool bUpdate = Modele_JeuDuMot.updateDeLaBaseAvecMotsDeLaSerie(IdUtilisateur, idMot, acquisition);
            return bUpdate;
        }

        public bool creationSerieEffectuees(int idUtilisateur, int idjeu, int nbQuestionDeLaSerie, int nbErreur, DateTime dateDuJour, DateTime timer)
        {
            bool bSerieCree = Modele_JeuDuMot.creationSerieEffectuees(idUtilisateur, idjeu, nbQuestionDeLaSerie, nbErreur, dateDuJour, timer);
            return bSerieCree;
        }
    }
}
