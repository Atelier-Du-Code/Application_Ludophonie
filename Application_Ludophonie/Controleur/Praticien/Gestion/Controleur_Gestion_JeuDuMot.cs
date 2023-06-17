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
        public List<Mot> recupereTousLesMots()
        {
            List<Mot> lstTousLesMots = new List<Mot>();

            lstTousLesMots = Modele_Gestion_JeuDuMot.recupereTousLesMots();
            return lstTousLesMots;
        }

        public List<string> recupereToutesListes()
        {
            List<string> lstToutesListes = new List<string>();

            lstToutesListes = Modele_Gestion_JeuDuMot.recupereToutesListes();
            return lstToutesListes;
        }

        public List<Mot> recupereTousLesMotsDelaListe(string liste)
        {
            List<Mot> lstTousLesMotsDeLaListe = new List<Mot>();

            lstTousLesMotsDeLaListe = Modele_Gestion_JeuDuMot.recupereToutLesMotsDeLaListe(liste);
            return lstTousLesMotsDeLaListe;
        }

        public bool enregistreUnMot(string mot, string contexte, int liste)
        {
            bool bEnregistre = Modele_Gestion_JeuDuMot.enregistreUnMot(mot, contexte, liste);

            return bEnregistre;
        }

        public bool supprimeUnMot(string mot)
        {
            bool bSupprime = Modele_Gestion_JeuDuMot.supprimeUnMot(mot);

            return bSupprime;
        }

        public int recupereDernierMotCree()
        {
            int idMot = Modele_Gestion_JeuDuMot.recupereDernierMotCree();
            return idMot;
        }

        public List<int> lstidPatient()
        {
            List<int> lstIdPatients = new List<int>();
            lstIdPatients = Modele_Gestion_JeuDuMot.lstidPatient();
            return lstIdPatients;
        }

        public bool creationAcquisition_leMot(int idUtilisateur, int idMot, int idNiveauAcquisition)
        {
            bool bCreation = Modele_Gestion_JeuDuMot.creationAcquisition_leMot(idUtilisateur, idMot, idNiveauAcquisition);
            return bCreation;

        }

        public Mot recupereUnmot(string mot)
        {
            Mot leMot = Modele_Gestion_JeuDuMot.recupereUnmot(mot);

            return leMot;
        }

        public bool supprimeTuplesBDD(int idPatient, int idMot)
        {
            bool bSuppression = Modele_Gestion_JeuDuMot.supprimeTuplesBDD(idPatient, idMot);

            return bSuppression;
        }
    }
}
        
        






