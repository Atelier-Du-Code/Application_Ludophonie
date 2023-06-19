using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie.Metier
{
    /// <summary>
    /// Définition de la classe Son
    /// </summary>
    public class Son
    {
        /// <summary>
        /// Porte l'url de l'emplacement du son
        /// </summary>
        static public string url = "";
    }

    /// <summary>
    /// Définition de la classe SonSysteme
    /// </summary>
    class SonSysteme : Son
    {
        public void ReponseVraie()
        {            
            url = "https://static.wixstatic.com/mp3/9fdfb6_8054ccd57c9445be8c5e175483747932.wav";

            SoundPlayer son = new SoundPlayer(url);
            son.Play();

        }
        public void ReponseFausse()
        {
            url = "https://static.wixstatic.com/mp3/9fdfb6_faa63280e13643a3a19accb9162724f8.wav";          

            SoundPlayer son = new SoundPlayer(url);
            son.Play();
        }
        public void finDeSerie()
        {            
            url = "https://static.wixstatic.com/mp3/9fdfb6_0a20d711a4614e09a2b44ef519e0ff6b.wav";

            SoundPlayer son = new SoundPlayer(url);
            son.Play();
        }
    }
}
