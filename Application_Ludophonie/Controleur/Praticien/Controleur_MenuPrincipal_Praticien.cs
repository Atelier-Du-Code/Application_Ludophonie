using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele;
using Application_Ludophonie.Modele.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Praticien
{
    /// <summary>
    /// Controleur - Classe de transition des données le menu principal - Côté particien
    /// </summary>
    public class Controleur_MenuPrincipal_Praticien
    {

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Page d'accueil - tabPage 1
        //////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Permet de récupérer toutes les séries effectuées enregistrées
        /// </summary>
        /// <returns></returns>
        public List<Serie> recupereToutesLesSeries()
        {
            List<Serie> lstToutesLesSeriesEffectuees = Modele_MenuPrincipal_Praticien.recupereToutesLesSeries();

            return lstToutesLesSeriesEffectuees;
        }

        /// <summary>
        /// Permet de récupérer toutes les séries effectuées aujourd'hui
        /// </summary>
        /// <returns></returns>
        public List<Serie> recupereLesSeriesEffectueesAujourdhui()
        {             
            List<Serie> lstSeriesEffectueesAujourdhui = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesAujourdhui();
            return lstSeriesEffectueesAujourdhui;
        }

        /// <summary>
        /// Permet de récupérer toutes les séries effectuées entre aujourd'hui et sept jours avant
        /// </summary>
        /// <returns></returns>
        public List<Serie> recupereLesSeriesEffectueesSemaine()
        {           
            List<Serie> lstSeriesEffectueesSemaine = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesSemaine();
            return lstSeriesEffectueesSemaine;
        }

        /// <summary>
        /// Permet de récupérer toutes les séries effectuées entre aujourd'hui et trente jours avant
        /// </summary>
        /// <returns></returns>
        public List<Serie> recupereLesSeriesEffectueesMois()
        {
            List<Serie> lstSeriesEffectueesMois = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesMois();
            return lstSeriesEffectueesMois;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Catalogue des patients - tabPage 2
        //////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Permet de récupérer toutes les informations des patients
        /// </summary>
        /// <returns></returns>
        public Utilisateur recuperePatient(string unIdentifiant)
        {
            Utilisateur patientRecupere = Modele_MenuPrincipal_Praticien.recuperePatient(unIdentifiant);

            return patientRecupere;
        }

        /// <summary>
        /// Permet de récupérer tous les patients de la liste
        /// </summary>
        /// <returns></returns>
        public List<Utilisateur> recupereTousLesPatients()
        {
            List<Utilisateur> lstTousLesPatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            return lstTousLesPatients;
        }

        /// <summary>
        /// Permet de créé un nouvel patient
        /// </summary>
        /// <param name="nouvelUtilisateur"></param>
        /// <returns></returns>
        public bool creeUtilisateur(Utilisateur nouvelUtilisateur)
        {
            bool bCreation = Modele_MenuPrincipal_Praticien.creeUtilisateur(nouvelUtilisateur);

            return bCreation;
        }

        /// <summary>
        /// Permet de modifier un patient
        /// </summary>
        /// <param name="UtilisateurAModifier"></param>
        /// <returns></returns>
        public bool ModifieUtilisateur(Utilisateur UtilisateurAModifier)
        {
            bool bModification = Modele_MenuPrincipal_Praticien.ModifieUtilisateur(UtilisateurAModifier);
            return bModification;
        }

        /// <summary>
        /// Permet de supprimer un patient
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public bool SupprimeUtilisateur(int idUtilisateur)
        {
            bool bSuppression = Modele_MenuPrincipal_Praticien.SupprimeUtilisateur(idUtilisateur);
            return bSuppression;
        }

        /// <summary>
        /// Permet de supprimer les séries d'un patient 
        /// </summary>
        /// <param name="utilisateurASupprimer"></param>
        /// <returns></returns>
        public bool SupprimeSesSeries(Utilisateur utilisateurASupprimer)
        {
            bool bSuppression = Modele_MenuPrincipal_Praticien.SupprimeSesSeries(utilisateurASupprimer);
            return bSuppression;
        }

        /// <summary>
        ///Permet de récupérer le nombre de patients dans la base de données 
        /// </summary>
        /// <returns></returns>
        public int compteCombienPatientDansBDD()
        {
            int nbPatients = Modele_MenuPrincipal_Praticien.compteCombienPatientDansBDD();
            return nbPatients;
        }      

        /// <summary>
        /// Permet de récupérer tous les n°identifiant des mots
        /// </summary>
        /// <returns></returns>
        public List<int> recupereTousIdLesMots()
        {
            List<int> idLesMots = Modele_MenuPrincipal_Praticien.recupereTousLesMots();
            return idLesMots;
        }

        /// <summary>
        /// Permet de créer la création du tuples dans la table acquisition le mot 
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idMot"></param>
        /// <param name="idNiveauAcquisition"></param>
        /// <returns></returns>
        public bool creationAcquisition_leMot(int idUtilisateur, int idMot, int idNiveauAcquisition)
        {
            bool bcreation = Modele_MenuPrincipal_Praticien.creationAcquisition_leMot(idUtilisateur, idMot, idNiveauAcquisition);

            return bcreation;

        }

        /// <summary>
        /// Permet de récupérer la liste de tous les n°identifiant des mots enregistrés
        /// </summary>
        /// <returns></returns>
        public List<int> recupererTouslstidPatient()
        {
            List<int> idpatients = Modele_MenuPrincipal_Praticien.recupererTouslstidPatient();
            return idpatients;
        }

        /// <summary>
        /// Permet de supprimer tous les tuples d'un mot dans la table acquisition_lemot
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public bool supprimeAcquisitionLeMot(int idUtilisateur)
        {
            bool bSupprime = Modele_MenuPrincipal_Praticien.supprimeAcquisitionLeMot(idUtilisateur);
            return bSupprime;
        }

        /// <summary>
        /// Permet de supprimer une mission du carnet de mission d'un patient
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public bool supprimeMissionsCarnet(int idUtilisateur)
        {
            bool bSupprime = Modele_MenuPrincipal_Praticien.supprimeMissionsCarnet(idUtilisateur);
            return bSupprime;
        }

        /// <summary>
        /// Permet de récupérer le dernier patient enregistré
        /// </summary>
        /// <returns></returns>
        public int recuperePlusGrandIdPatient()
        {
            int plusGrandIdPatient = Modele_MenuPrincipal_Praticien.recuperePlusGrandIdPatient();
            return plusGrandIdPatient;
        }
    }



}
