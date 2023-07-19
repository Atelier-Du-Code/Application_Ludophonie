using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    public class Grade
    {
        public Grade(int idGrade, string grade, int score_pallier)
        {
            this.IdGrade = idGrade;
            this.Libelle_Grade = grade;
            this.Score_Palier = score_pallier;
        }

        public int IdGrade { get; set; }

        public string Libelle_Grade { get; set; }

        public int Score_Palier { get; set; }


    }
}
