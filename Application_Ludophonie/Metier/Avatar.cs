using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    /// <summary>
    /// Classe de définition d'un avatar 
    /// </summary>
    public class Avatar
    {
        /// <summary>
        /// Constructeur de la classe Avatar
        /// </summary>
        /// <param name="idAvatar"></param>
        /// <param name="nom"></param>
        /// <param name="url"></param>
        public Avatar(int idAvatar, string nom, string url)
        {
            this.IdAvatar = idAvatar;
            this.Nom = nom;
            this.Url = url;
        }

        /// <summary>
        /// Porte le numéro identifiant de l'avatar
        /// </summary>
        public int IdAvatar { get; set; }

        /// <summary>
        /// Porte le nom de l'avatar
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Porte l'url de localisation de l'avatar
        /// </summary>
        public string Url { get; set; }
    }
}
