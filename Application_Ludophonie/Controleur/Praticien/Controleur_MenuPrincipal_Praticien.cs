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
    class Controleur_MenuPrincipal_Praticien
    {

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Page d'accueil - tabPage 1
        //////////////////////////////////////////////////////////////////////////////////////////////////
        
        public List<Serie> recupereToutesLesSeries()
        {
            List<Serie> lstToutesLesSeriesEffectuees = new List<Serie>();

            lstToutesLesSeriesEffectuees = Modele_MenuPrincipal_Praticien.recupereToutesLesSeries();

            return lstToutesLesSeriesEffectuees;
        }

        public List<Serie> recupereLesSeriesEffectueesAujourdhui()
        {
            List<Serie> lstSeriesEffectueesAujourdhui = new List<Serie>();

            lstSeriesEffectueesAujourdhui = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesAujourdhui();
            return lstSeriesEffectueesAujourdhui;
        }

        public List<Serie> recupereLesSeriesEffectueesSemaine()
        {
            List<Serie> lstSeriesEffectueesSemaine = new List<Serie>();

            lstSeriesEffectueesSemaine = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesSemaine();
            return lstSeriesEffectueesSemaine;
        }

        public List<Serie> recupereLesSeriesEffectueesMois()
        {
            List<Serie> lstSeriesEffectueesMois = new List<Serie>();

            lstSeriesEffectueesMois = Modele_MenuPrincipal_Praticien.recupereLesSeriesEffectueesMois();
            return lstSeriesEffectueesMois;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Catalogue des patients - tabPage 2
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public Utilisateur recuperePatient(string unIdentifiant)
        {
            Utilisateur patientRecupere = new Utilisateur(0, null, null, null, null, null, null, null);

            patientRecupere = Modele_MenuPrincipal_Praticien.recuperePatient(unIdentifiant);

            return patientRecupere;
        }

        public List<Utilisateur> recupereTousLesPatients()
        {
            List<Utilisateur> lstTousLesPatients = new List<Utilisateur>();

            lstTousLesPatients = Modele_MenuPrincipal_Praticien.recupereTousLesPatients();
            return lstTousLesPatients;
        }

        public bool creeUtilisateur(Utilisateur nouvelUtilisateur)
        {
            bool bCreation = Modele_MenuPrincipal_Praticien.creeUtilisateur(nouvelUtilisateur);

            return bCreation;

        }

        public bool ModifieUtilisateur(Utilisateur UtilisateurAModifier)
        {
            bool bModification = Modele_MenuPrincipal_Praticien.ModifieUtilisateur(UtilisateurAModifier);
            return bModification;
        }

        public bool SupprimeUtilisateur(int idUtilisateur)
        {
            bool bSuppression = Modele_MenuPrincipal_Praticien.SupprimeUtilisateur(idUtilisateur);
            return bSuppression;
        }

        public bool SupprimeSesSeries(Utilisateur utilisateurASupprimer)
        {
            bool bSuppression = Modele_MenuPrincipal_Praticien.SupprimeSesSeries(utilisateurASupprimer);
            return bSuppression;
        }

        public int compteCombienPatientDansBDD()
        {
            int nbPatients = Modele_MenuPrincipal_Praticien.compteCombienPatientDansBDD();
            return nbPatients;
        }

        public int compteCombienMotsDansBDD()
        {
            int nbMots = Modele_MenuPrincipal_Praticien.compteCombienMotsDansBDD();
            return nbMots;
        }

        public List<int> recupereTousIdLesMots()
        {
            List<int> idLesMots = new List<int>();
            idLesMots = Modele_MenuPrincipal_Praticien.recupereTousLesMots();
            return idLesMots;
        }

        public bool creationAcquisition_leMot(int idUtilisateur, int idMot, int idNiveauAcquisition)
        {
            bool bcreation = Modele_MenuPrincipal_Praticien.creationAcquisition_leMot(idUtilisateur, idMot, idNiveauAcquisition);

            return bcreation;

        }

        public List<int> recupererTouslstidPatient()
        {
            List<int> idpatients = new List<int>();

            idpatients = Modele_MenuPrincipal_Praticien.recupererTouslstidPatient();
            return idpatients;
        }

        public bool supprimeAcquisitionLeMot(int idUtilisateur)
        {
            bool bSupprime = Modele_MenuPrincipal_Praticien.supprimeAcquisitionLeMot(idUtilisateur);
            return bSupprime;
        }

        public bool supprimeMissionsCarnet(int idUtilisateur)
        {
            bool bSupprime = Modele_MenuPrincipal_Praticien.supprimeMissionsCarnet(idUtilisateur);
            return bSupprime;
        }

        public int recuperePlusGrandIdPatient()
        {
            int plusGrandIdPatient = Modele_MenuPrincipal_Praticien.recuperePlusGrandIdPatient();
            return plusGrandIdPatient;
        }
    }



}
