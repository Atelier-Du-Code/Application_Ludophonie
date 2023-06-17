using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    public class Image
    {
        public Image(string nom, string url)
        {
            this.Nom = nom;
            this.Url = url;
        }

        public string Nom { get; set; }

        public string Url { get; set; }
    }
}
