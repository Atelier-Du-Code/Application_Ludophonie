using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Jeux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Jeux
{
    /// <summary>
    /// Controleur - Classe de transition des données pour le jeu du mot - Côté patient
    /// </summary>
    public class Controleur_JeuDuMot
    {
        /// <summary>
        /// Permet de récupérer toutes les images de l'interface
        /// </summary>
        /// <returns></returns>
        public List<Image> recupereToutesImagesInterface()
        {
            List<Image> lstImages = Modele_JeuDuMot.recupereImagesInterface();

            return lstImages;
        }

        /// <summary>
        /// Permet de récupérer les mots en fonction de leur liste d'appartenance et de leur niveau d'acquisition pour un patient
        /// </summary>
        /// <param name="liste"></param>
        /// <param name="acquisition"></param>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public List<Mot> recupereMotsParListeNiveauAcquisitionIdUtilisateur(string liste, int acquisition, int idUtilisateur)
        {
            List<Mot> lstMots = Modele_JeuDuMot.recupereMotsParListeNiveauAcquisitionIdUtilisateur(liste, acquisition, idUtilisateur);

            return lstMots;
        }

        /// <summary>
        /// Permet de mettre à jour le niveau d'acquisition des mots d'une série pour un patient 
        /// </summary>
        /// <param name="IdUtilisateur"></param>
        /// <param name="idMot"></param>
        /// <param name="acquisition"></param>
        /// <returns></returns>
        public bool updateDeLaBaseAvecMotsDeLaSerie(int IdUtilisateur, int idMot, int acquisition)
        {
            bool bUpdate = Modele_JeuDuMot.updateDeLaBaseAvecMotsDeLaSerie(IdUtilisateur, idMot, acquisition);
            return bUpdate;
        }

        /// <summary>
        /// Permet de créer une série effectuées
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idjeu"></param>
        /// <param name="nbQuestionDeLaSerie"></param>
        /// <param name="nbErreur"></param>
        /// <param name="dateDuJour"></param>
        /// <param name="timer"></param>
        /// <returns></returns>
        public bool creationSerieEffectuees(int idUtilisateur, int idjeu, int nbQuestionDeLaSerie, int nbErreur, DateTime dateDuJour, DateTime timer)
        {
            bool bSerieCree = Modele_JeuDuMot.creationSerieEffectuees(idUtilisateur, idjeu, nbQuestionDeLaSerie, nbErreur, dateDuJour, timer);
            return bSerieCree;
        }
    }
}
