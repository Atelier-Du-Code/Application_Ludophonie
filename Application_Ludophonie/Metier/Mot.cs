using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    public class Mot
    {
        public Mot(int idMot, string mot, string contexte, string liste)
        {
            this.IdMot = idMot;
            this.LeMot = mot;
            this.Contexte = contexte;
            this.Liste = liste;
        }

        public int IdMot { get; set; }
        public string LeMot { get; set; }
        public string Contexte { get; set; }
        public string Liste { get; set; }
    }
}
