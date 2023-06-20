using Application_Ludophonie.Controleur.Jeux;
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

namespace Application_Ludophonie.Vue.Jeux
{
    /// <summary>
    /// Vue - Gestionnaire de série avant de débuter le jeu du mot - Côté patient
    /// </summary>
    public partial class Vue_GestionnaireDeSerie_JeuDuLot : Form
    {
        Utilisateur utilisateur;
        Controleur_Gestionnaire_De_Serie_Mot controleur = new Controleur_Gestionnaire_De_Serie_Mot();

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="utilisateur"></param>
        public Vue_GestionnaireDeSerie_JeuDuLot(Utilisateur utilisateur)
        {
            InitializeComponent();

            this.utilisateur = utilisateur;
            rempliCbx();

            lblMessage.Text = "";

        }

        /// <summary>
        /// Permet de remplir le comboBox avec les listes
        /// </summary>
        public void rempliCbx()
        {
            List<string> lstListes = new List<string>();

            lstListes.Clear();
            lstListes = controleur.recupereToutesListes();

            cbxNiveau.Items.Clear();

            for(int i=0; i<lstListes.Count; i++)
            {
                cbxNiveau.Items.Add(lstListes[i]);
            }           
        }

        private void cbxNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNiveau.SelectedItem.ToString() == "Liste 2")
            {
                cbxNbQuestions.Items.Clear();
                cbxNbQuestions.Items.Add(1);
                cbxNbQuestions.Items.Add(5);
            }
            else
            {
                cbxNbQuestions.Items.Clear();
                cbxNbQuestions.Items.Add(1);
                cbxNbQuestions.Items.Add(5);
                cbxNbQuestions.Items.Add(10);
            }
        }
        /// <summary>
        /// Permet de commencer un série du "Jeu du mot"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDebutSerie_Click(object sender, EventArgs e)
        {
            if(cbxNiveau.SelectedItem == null || cbxNbQuestions.SelectedItem == null)
            {
                lblMessage.Text = "Veillez à sélectionner un niveau de liste et un nombre de questions";
            }
            else
            {
                Vue_Jeu_DuMot fenetre_Vue_JeuDuMot = new Vue_Jeu_DuMot(utilisateur, cbxNiveau.SelectedItem.ToString(), (int)cbxNbQuestions.SelectedItem);
                fenetre_Vue_JeuDuMot.ShowDialog();
            }
            
        }

        /// <summary>
        /// Permet de quitter la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
