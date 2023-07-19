using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    public class Mission
    {
        public Mission(int idMission, int idUtilisateur, string jeu, int nbQuestions, int missionValidee)
        {
            this.IdMission = idMission;
            this.IdUtilisateur = idUtilisateur;
            this.Jeu = jeu;
            this.NbQuestions = nbQuestions;
            this.MissionValide = missionValidee;
        }

        public int IdMission { get; set; }

        public int IdUtilisateur { get; set; }

        public string Jeu { get; set; }

        public int NbQuestions { get; set; }

        public int MissionValide { get; set; }
    }
}
