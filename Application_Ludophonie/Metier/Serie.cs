using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Application_Ludophonie.Metier
{
    public class Serie
    {
        public Serie(int idUtilisateur, string nom, string prenom, string jeu, int nbQuestionSerie, int nbErreurs, DateTime dateDuJour, DateTime timer)
        {
            this.IdUtilisateur = idUtilisateur;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Jeu = jeu;
            this.NbQuestionSerie = nbQuestionSerie;
            this.NbErreurs = nbErreurs;
            this.DateDuJour = dateDuJour;
            this.Timer = timer;
        }

        public int IdUtilisateur { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Jeu { get; set; }

        public int NbQuestionSerie { get; set; }

        public int NbErreurs { get; set; }

        public DateTime DateDuJour { get; set; }

        public DateTime Timer;
    }
}
