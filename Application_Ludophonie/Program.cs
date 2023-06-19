using Application_Ludophonie.Metier;
using Application_Ludophonie.Vue.Jeux;
using Application_Ludophonie.Vue.Patient;
using Application_Ludophonie.Vue.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie
{
    /// <summary>
    /// C'est la classe du programme
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                        
            Application.Run(new Authentification());            
        }
    }
}
