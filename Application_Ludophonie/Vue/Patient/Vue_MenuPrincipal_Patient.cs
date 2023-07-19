using Application_Ludophonie.Controleur.Patient;
using Application_Ludophonie.Metier;
using Application_Ludophonie.Vue.Jeux;
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
    /// <summary>
    /// Vue - Menu Principal - Côté patient
    /// </summary>
    public partial class Vue_MenuPrincipal_Patient : Form
    {
        Utilisateur utilisateurEnCours;
        controleur_MenuPatient controleur = new controleur_MenuPatient();

        Vue_ModificationAvatar_Patient fenetre_Vue_ModificationAvatar;

        string grade_String;
        int grade_int;

        string niveau;

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="utilisateurEnCours"></param>
        public Vue_MenuPrincipal_Patient(Utilisateur utilisateurEnCours)
        {
            InitializeComponent();
            this.utilisateurEnCours = utilisateurEnCours;

            pbAvatar.ImageLocation = utilisateurEnCours.UrlAvatar;

            initialiseGrade();
            initialiseNiveau();
            btnJeuLaSyllabe.Enabled = false;

            lblGrade.Text = "Grade : " + grade_String;
            lblNiveau_LeMot.Text = "Niveau : " + niveau;

        }

        private void initialiseGrade()
        {
            grade_String = controleur.recupereLeGradeString(utilisateurEnCours.IdUtilisateur);

            grade_int = controleur.recupereLeGradeInt(utilisateurEnCours.IdUtilisateur);

        }

        private void initialiseNiveau()
        {
            niveau = controleur.recupereNiveauPatient(utilisateurEnCours.IdUtilisateur);
        }

       

        /// <summary>
        /// Permet d'ouvrir le carnet de missions pour le patient en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarnetDeMission_Click(object sender, EventArgs e)
        {
            Vue_Carnet_De_Missions fenetre_Carnet_De_Mission = new Vue_Carnet_De_Missions(utilisateurEnCours.IdUtilisateur);
            fenetre_Carnet_De_Mission.Show();
        }

        /// <summary>
        /// Permet d'ouvrir le gestionnaire de séries du jeu du mot pour le patient en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJeuDuMot_Click(object sender, EventArgs e)
        {
            Vue_GestionnaireDeSerie_JeuDuLot fenetre_GestionnaireSerie_Mot = new Vue_GestionnaireDeSerie_JeuDuLot(utilisateurEnCours);
            fenetre_GestionnaireSerie_Mot.Show();
        }

        /// <summary>
        /// Permet d'ouvrir le panneau de modification de l'avatar pour le patient en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAvatar_Click(object sender, EventArgs e)
        {
            fenetre_Vue_ModificationAvatar = new Vue_ModificationAvatar_Patient(utilisateurEnCours.IdUtilisateur, grade_int);
            fenetre_Vue_ModificationAvatar.ShowDialog();
            
            pbAvatar.ImageLocation = controleur.recupereAvatar(utilisateurEnCours.IdUtilisateur).Url;
        }

        /// <summary>
        /// Permet d'accéder à l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
