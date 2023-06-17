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

            Utilisateur utilisateurAControler = new Utilisateur(1, "patient", "Jade_Vidal", "Vidal", "Jade", "CE2", "000", "https://i.pinimg.com/564x/8f/cc/6e/8fcc6e362c58546f130310c97ad0df39.jpg");


            Utilisateur utilisateurAControler2 = new Utilisateur(3, "praticien", "Felix_Pellerin", "Pellerin", "Felix", "", "0000", "https://i.pinimg.com/564x/8f/cc/6e/8fcc6e362c58546f130310c97ad0df39.jpg");

            //Application.Run(new Vue_GestionnaireDeSerie_JeuDuLot(utilisateurAControler2));
            Application.Run(new Authentification());
            //Application.Run(new Vue_MenuPrincipal_Praticien(utilisateurAControler2));
        }
    }
}
