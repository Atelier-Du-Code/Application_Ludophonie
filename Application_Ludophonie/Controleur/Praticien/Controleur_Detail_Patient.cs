using Application_Ludophonie.Metier;
using Application_Ludophonie.Modele.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Praticien
{
    public class Controleur_Detail_Patient
    {
        public List<string> recupereTousLesJeux()
        {
            List<string> lstJeux = new List<string>();
            lstJeux = Modele_Detail_Patient.recupereTousLesJeux();

            return lstJeux;
        }

        public List<Serie> recupereToutesSeriesUtilisateur(int unIdUtilisateur)
        {
            List<Serie> lstToutesSeries = new List<Serie>();
            lstToutesSeries = Modele_Detail_Patient.recupereToutesSeriesUtilisateur(unIdUtilisateur);

            return lstToutesSeries;
        }

        public List<Serie> recupereToutesSeriesJeu(int unIdUtilisateur, string nomJeu)
        {
            List<Serie> lstSeriesJeu = new List<Serie>();
            lstSeriesJeu = Modele_Detail_Patient.recupereToutesSeriesJeu(unIdUtilisateur, nomJeu);

            return lstSeriesJeu;
        }
    }
}
