using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Application_Ludophonie.Metier
{
    /// <summary>
    /// Classe de définition d'une série
    /// </summary>
    public class Serie
    {
        /// <summary>
        /// Constructeur de la classe série
        /// </summary>
        /// <param name="idSerie"></param>
        /// <param name="idUtilisateur"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="jeu"></param>
        /// <param name="nbQuestionSerie"></param>
        /// <param name="nbErreurs"></param>
        /// <param name="dateDuJour"></param>
        /// <param name="timer"></param>
        public Serie(int idSerie, int idUtilisateur, string nom, string prenom, string grade, string jeu, int nbQuestionSerie, int nbErreurs, DateTime dateDuJour, DateTime timer, int serieDemandee, int score)
        {
            this.IdSerie = idSerie;
            this.IdUtilisateur = idUtilisateur;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Grade = grade;
            this.Jeu = jeu;
            this.NbQuestionSerie = nbQuestionSerie;
            this.NbErreurs = nbErreurs;
            this.DateDuJour = dateDuJour;
            this.Timer = timer;
            this.SerieDemandee = serieDemandee;
            this.Score = score;
            
        }

        /// <summary>
        /// Porte l'identifiant de la série
        /// </summary>
        public int IdSerie { get; set; }

        /// <summary>
        /// Porte le numéro d'identifiant d'une série
        /// </summary>
        public int IdUtilisateur { get; set; }

        /// <summary>
        /// Porte le nom du patient qui a effectuée la série 
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Porte le prénom du patient qui a effectuée la série
        /// </summary>
        public string Prenom { get; set; }

        public string Grade { get; set; }
        /// <summary>
        /// Porte le nom du jeu de la série 
        /// </summary>
        public string Jeu { get; set; }

        /// <summary>
        /// Porte le nombre de questions de la série 
        /// </summary>
        public int NbQuestionSerie { get; set; }

        /// <summary>
        /// Porte le nombre d'erreur de la série 
        /// </summary>
        public int NbErreurs { get; set; }

        /// <summary>
        /// Porte la date du jour de la série
        /// </summary>
        public DateTime DateDuJour { get; set; }

        /// <summary>
        /// Porte le temps que le patient a mis pour résoudre la série
        /// </summary>
        public DateTime Timer;

        public int SerieDemandee { get; set; }

        public int Score { get; set; }
    }
}
