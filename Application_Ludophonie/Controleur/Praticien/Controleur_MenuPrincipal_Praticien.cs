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

        public bool SupprimeUtilisateur(Utilisateur utilisateurASupprimer)
        {
            bool bSuppression = Modele_MenuPrincipal_Praticien.SupprimeUtilisateur(utilisateurASupprimer);
            return bSuppression;
        }

        public bool SupprimeSesSeries(Utilisateur utilisateurASupprimer)
        {
            bool bSuppression = Modele_MenuPrincipal_Praticien.SupprimeSesSeries(utilisateurASupprimer);
            return bSuppression;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Gestion des jeux - tabPage 
        //////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
