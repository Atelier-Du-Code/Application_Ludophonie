using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    public class Avatar
    {
        public Avatar(int idAvatar, string nom, string url)
        {
            this.IdAvatar = idAvatar;
            this.Nom = nom;
            this.Url = url;
        }

        public int IdAvatar { get; set; }

        public string Nom { get; set; }

        public string Url { get; set; }
    }
}
