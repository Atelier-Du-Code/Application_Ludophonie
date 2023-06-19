using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    /// <summary>
    /// Classe de définition d'un Mot
    /// </summary>
    public class Mot
    {
        /// <summary>
        /// Constructeur de la classe : Mot
        /// </summary>
        /// <param name="idMot"></param>
        /// <param name="mot"></param>
        /// <param name="contexte"></param>
        /// <param name="liste"></param>
        /// <param name="acquisition"></param>
        public Mot(int idMot, string mot, string contexte, string liste, int acquisition)
        {
            this.IdMot = idMot;
            this.LeMot = mot;
            this.Contexte = contexte;
            this.Liste = liste;
            this.Acquisition = acquisition;
        }

        /// <summary>
        /// Porte le numero identifiant du mot 
        /// </summary>
        public int IdMot { get; set; }

        /// <summary>
        /// Porte le mot
        /// </summary>
        public string LeMot { get; set; }

        /// <summary>
        /// Porte le contexte du mot
        /// </summary>
        public string Contexte { get; set; }

        /// <summary>
        /// Porte le niveau de la liste du mot
        /// </summary>
        public string Liste { get; set; }

        /// <summary>
        /// Porte le niveau d'acquisition du mot pour un patient
        /// </summary>
        public int Acquisition { get; set; }
    }
}
