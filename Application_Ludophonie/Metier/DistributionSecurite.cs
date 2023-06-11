using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    public class DistributionSecurite
    {
        private HashMotDePasse_Singleton hashMotDePasse_Singleton;

        public DistributionSecurite()
        {
            hashMotDePasse_Singleton = HashMotDePasse_Singleton.GetInstance();
        }
    }
}
