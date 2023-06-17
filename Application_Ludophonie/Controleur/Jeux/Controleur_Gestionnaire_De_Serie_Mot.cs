using Application_Ludophonie.Modele.Jeux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Jeux
{
    public class Controleur_Gestionnaire_De_Serie_Mot
    {
        public List<string> recupereToutesListes()
        {
            List<string> toutesListes = new List<string>();
            toutesListes = Modele_Gestionnaire_De_Serie_Mot.recupereToutesLesListes();

            return toutesListes;
        }
    }
}
