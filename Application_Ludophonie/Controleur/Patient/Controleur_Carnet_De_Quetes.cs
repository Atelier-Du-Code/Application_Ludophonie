using Application_Ludophonie.Modele.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Controleur.Patient
{
    public class Controleur_Carnet_De_Quetes
    {
        public List<string>recupereLstMissions(int idUtilisateur)
        {
            List<string> lstMissions = new List<string>();
            lstMissions = Modele_Carnet_de_quetes.recupereLstMissions(idUtilisateur);

            return lstMissions;
        }
    }
}
