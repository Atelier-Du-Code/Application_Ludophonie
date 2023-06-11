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

    }
}
        
        






