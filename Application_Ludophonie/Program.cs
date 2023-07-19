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

            
            Utilisateur praticien = new Utilisateur(1, "praticien", "felix_pellerin", "Pellerin", "Felix", "", "59@h7a?b5eRVZ&", "https://i.pinimg.com/originals/69/4a/66/694a66860b36a48b6e58112dd16308c7.png", 2000000000, "praticien");

            Application.Run(new Vue_MenuPrincipal_Praticien(praticien));
            
            /*
            Utilisateur patient = new Utilisateur(2, "patient", "jade_vidal", "Jade", "Pellerin", "", "5w&rcRi29F6&*H", "https://i.pinimg.com/originals/69/4a/66/694a66860b36a48b6e58112dd16308c7.png", 200, "farfadet");
            Application.Run(new Vue_MenuPrincipal_Patient(patient));
            */

            //Application.Run(new Authentification());   
        }
    }
}
