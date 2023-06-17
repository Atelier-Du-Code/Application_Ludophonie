using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Praticien.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Praticien.Gestion
{
    public class Controleur_Gestion_JeuDuMot
    {
        /// <summary>
        /// Permet de récupérer tous les mots enregistrés
        /// </summary>
        /// <returns></returns>
        public List<Mot> recupereTousLesMots()
        {
            List<Mot> lstTousLesMots = Modele_Gestion_JeuDuMot.recupereTousLesMots();
            return lstTousLesMots;
        }

        /// <summary>
        /// Permet de récupérer tous les niveaux de liste
        /// </summary>
        /// <returns></returns>
        public List<string> recupereToutesListes()
        {
            List<string> lstToutesListes = Modele_Gestion_JeuDuMot.recupereToutesListes();
            return lstToutesListes;
        }

        /// <summary>
        /// Permet de récupérer tous les mots d'une liste
        /// </summary>
        /// <param name="liste"></param>
        /// <returns></returns>
        public List<Mot> recupereTousLesMotsDelaListe(string liste)
        {
            List<Mot> lstTousLesMotsDeLaListe = Modele_Gestion_JeuDuMot.recupereToutLesMotsDeLaListe(liste);
            return lstTousLesMotsDeLaListe;
        }

        /// <summary>
        /// Permet d'enregistrer un nouveau mot
        /// </summary>
        /// <param name="mot"></param>
        /// <param name="contexte"></param>
        /// <param name="liste"></param>
        /// <returns></returns>
        public bool enregistreUnMot(string mot, string contexte, int liste)
        {
            bool bEnregistre = Modele_Gestion_JeuDuMot.enregistreUnMot(mot, contexte, liste);

            return bEnregistre;
        }

        /// <summary>
        /// Permet de supprimer un mot
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public bool supprimeUnMot(string mot)
        {
            bool bSupprime = Modele_Gestion_JeuDuMot.supprimeUnMot(mot);

            return bSupprime;
        }

        /// <summary>
        /// Permet de récupérer le dernier mot créé
        /// </summary>
        /// <returns></returns>
        public int recupereDernierMotCree()
        {
            int idMot = Modele_Gestion_JeuDuMot.recupereDernierMotCree();
            return idMot;
        }

        /// <summary>
        /// Pemret de récupérer tous les n° identifiant de tous les patients enregistrés
        /// </summary>
        /// <returns></returns>
        public List<int> lstidPatient()
        {
            List<int> lstIdPatients = Modele_Gestion_JeuDuMot.lstidPatient();
            return lstIdPatients;
        }

        /// <summary>
        /// Permet de créer les tuples dans la table acquisition_lemot permettant de stocké le niveau d'acquisition 
        /// de chaque mot pour chaque patient
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idMot"></param>
        /// <param name="idNiveauAcquisition"></param>
        /// <returns></returns>
        public bool creationAcquisition_leMot(int idUtilisateur, int idMot, int idNiveauAcquisition)
        {
            bool bCreation = Modele_Gestion_JeuDuMot.creationAcquisition_leMot(idUtilisateur, idMot, idNiveauAcquisition);
            return bCreation;

        }

        /// <summary>
        /// Permet de récupérer un mot
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public Mot recupereUnmot(string mot)
        {
            Mot leMot = Modele_Gestion_JeuDuMot.recupereUnmot(mot);

            return leMot;
        }

        /// <summary>
        /// Permet de supprimer les tuples d'un mot dans la table acquisition_lemot
        /// </summary>
        /// <param name="idPatient"></param>
        /// <param name="idMot"></param>
        /// <returns></returns>
        public bool supprimeTuplesBDD(int idPatient, int idMot)
        {
            bool bSuppression = Modele_Gestion_JeuDuMot.supprimeTuplesBDD(idPatient, idMot);

            return bSuppression;
        }
    }
}
        
        






