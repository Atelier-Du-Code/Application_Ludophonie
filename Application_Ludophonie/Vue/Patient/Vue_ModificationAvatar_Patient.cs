using Application_Ludophonie.Controleur.Patient;
using Application_Ludophonie.Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie.Vue.Patient
{
    public partial class Vue_ModificationAvatar_Patient : Form
    {
        private int avatarchoisis;       
        private bool bModifAvatar;
        private string urlAvatar;

        Controleur_ModifAvatar controleur = new Controleur_ModifAvatar();

        int idUtilisateur;
        List<Button> lstBtn = new List<Button>();

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idutilisateur"></param>
        public Vue_ModificationAvatar_Patient(int idutilisateur)
        {
            InitializeComponent();
            this.idUtilisateur = idutilisateur;

            lstBtn.Add(btnDefaut);
            lstBtn.Add(btnBrun);
            lstBtn.Add(btnJaune);
            lstBtn.Add(btnOrange);
            lstBtn.Add(btnRose);
            lstBtn.Add(btnVert);
        }

        /// <summary>
        /// Permet de modifier l'avatar dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValideAvatar_Click(object sender, EventArgs e)
        {            
            List<Avatar> lstAvatar = controleur.recuperelstAvatar();

            urlAvatar = lstAvatar[avatarchoisis-1].Url;
            
            bModifAvatar = controleur.modifAvatar(avatarchoisis, idUtilisateur);

            Close();   
        }

        /// <summary>
        /// Permet de changer la couleur des boutons suivant si ils ne sont pas cliqués
        /// </summary>
        private void donneLaPrio()
        {
            for (int i = 0; i < lstBtn.Count; i++)
            {
                lstBtn[i].FlatAppearance.BorderColor = Color.AliceBlue;
            }
        }

        /// <summary>
        /// Permet de selectionner l'avatar par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefaut_Click(object sender, EventArgs e)
        {
            avatarchoisis = 0;         

            donneLaPrio();
            btnDefaut.FlatAppearance.BorderColor = Color.Black;

            avatarchoisis = 1;          
        }

        /// <summary>
        /// Permet de selectionner l'avatar brun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrun_Click(object sender, EventArgs e)
        {
            avatarchoisis = 0;
           
            donneLaPrio();
            btnBrun.FlatAppearance.BorderColor = Color.Black;

            avatarchoisis = 2;
        }

        /// <summary>
        /// Permet de selectionner l'avatar jaune
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJaune_Click(object sender, EventArgs e)
        {
            avatarchoisis = 0;

            donneLaPrio();
            btnJaune.FlatAppearance.BorderColor = Color.Black;

            avatarchoisis = 3;
        }

        /// <summary>
        /// Permet de selectionner l'avatar orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrange_Click(object sender, EventArgs e)
        {
            avatarchoisis = 0;

            donneLaPrio();
            btnOrange.FlatAppearance.BorderColor = Color.Black;

            avatarchoisis = 4;
        }

        /// <summary>
        /// Permet de selectionner l'avatar rose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRose_Click(object sender, EventArgs e)
        {
            avatarchoisis = 0;

            donneLaPrio();
            btnRose.FlatAppearance.BorderColor = Color.Black;

            avatarchoisis = 5;
        }

        /// <summary>
        /// Permet de selectionner l'avatar vert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVert_Click(object sender, EventArgs e)
        {
            avatarchoisis = 0;

            donneLaPrio();
            btnVert.FlatAppearance.BorderColor = Color.Black;

            avatarchoisis = 6;
        }

        /// <summary>
        /// Permet de quitter la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
