using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    /// <summary>
    /// Classe de définition d'une image 
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Constructeur de la classe Image
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="url"></param>
        public Image(string nom, string url)
        {
            this.Nom = nom;
            this.Url = url;
        }

        /// <summary>
        /// Porte le nom de l'image 
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Porte l'url de localisation de l'image
        /// </summary>
        public string Url { get; set; }
    }
}
