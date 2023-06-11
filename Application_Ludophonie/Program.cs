using Application_Ludophonie.Metier;
using Application_Ludophonie.Vue.Praticien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie
{
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


           Utilisateur utilisateur = new Utilisateur(3, "praticien", "Avril_Loiselle", "Loiselle", "Avril", "-", "0000", "https://i.pinimg.com/564x/09/02/52/090252ec643baa0e7e90c3d965724f90.jpg");


            Application.Run(new Vue_MenuPrincipal_Praticien(utilisateur));
            //Application.Run(new Authentification());
        }
    }
}
