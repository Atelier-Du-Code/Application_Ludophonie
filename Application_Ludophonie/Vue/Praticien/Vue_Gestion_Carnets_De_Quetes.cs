using Application_Ludophonie.Controleur.Praticien;
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

namespace Application_Ludophonie.Vue.Praticien
{
    /// <summary>
    /// Vue - Carnet de missions - Côté patient
    /// </summary>
    public partial class Vue_Gestion_Carnets_De_Quetes : Form
    {
        private Controleur_Gestion_Carnet__De_Mission controleur = new Controleur_Gestion_Carnet__De_Mission();

        private List<Mission> lstMissions = new List<Mission>();
        List<string> lstJeux = new List<string>();

        private int idUtilisateurEnCours;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idUtilisateurEnCours"></param>
        public Vue_Gestion_Carnets_De_Quetes(int idUtilisateurEnCours)
        {
            InitializeComponent();
            lblMessage.Text = "";

            this.idUtilisateurEnCours = idUtilisateurEnCours;
            actualiseListeMissions();
            actualiseCbxJeux();
            actualiseCbxNbQuestions();

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Gestion de l'ajout d'une mission
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Permet d'enregistrer une nouvelle mission pour le patient en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int nbSerie = (int)nudNbSeries.Value;
            int nbQuestions = (int)cbxNbQuestions.SelectedItem;
            bool bEnregistrer = true;

            for (int i = 0; i<nbSerie; i++)
            {
                bEnregistrer = controleur.enregistreMissions(idUtilisateurEnCours, cbxJeux.SelectedIndex+1, nbQuestions);
            }
            
            if(bEnregistrer)
            {
                lblMessage.Text = "La mission a bien été enregistrée";

                cbxNbQuestions.SelectedItem = 0;
                nudNbSeries.Value = 0;
                cbxJeux.SelectedIndex = 0;
            }
            else
            {
                lblMessage.Text = "La mission n'a pas pus être enregistrée";
            }

            actualiseListeMissions();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Gestion de la suppression d'une mission
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(lstCBxMissions.SelectedIndex > 0)
            {
                bool bSupprimer = controleur.supprimeUneMission(lstMissions[lstCBxMissions.SelectedIndex].IdMission);

                if(bSupprimer)
                {
                    lblMessage.Text = "La mission a bien été supprimée";
                    actualiseListeMissions();
                }
                else
                {
                    lblMessage.Text = "La mission n'a pas pus être supprimée";
                }
            }
        }

        private void btnToutSupprimer_Click(object sender, EventArgs e)
        {
            bool bSupprimerToutes = controleur.supprimeToutesMissions(idUtilisateurEnCours);

            if (bSupprimerToutes)
            {
                lblMessage.Text = "Les missions ont bien été supprimées";
                actualiseListeMissions();
            }
            else
            {
                lblMessage.Text = "Les missions n'ont pas pus être supprimées";
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Méthode de gestion + Interface
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet d'actualiser la listBox contenant les missions du patient en cours
        /// </summary>
        private void actualiseListeMissions()
        {
            lstMissions.Clear();
            lstMissions = controleur.recupereToutesMissions(idUtilisateurEnCours);

            lstCBxMissions.Items.Clear();

            for (int i = 0; i < lstMissions.Count; i++)
            {
                lstCBxMissions.Items.Add("Série de " + lstMissions[i].NbQuestions + " questions du "+ lstMissions[i].Jeu);

                if(lstMissions[i].MissionValide == 1)
                {
                    lstCBxMissions.SetItemChecked(i, true);
                }
            }
        }

        private void actualiseCbxJeux()
        {            
            lstJeux = controleur.recupereTousLesJeux();

            for (int i = 0; i < lstJeux.Count; i++)
            {
                cbxJeux.Items.Add(lstJeux[i]);
            }
        }

        private void actualiseCbxNbQuestions()
        {
            cbxNbQuestions.Items.Add(1);
            cbxNbQuestions.Items.Add(5);
        }
        /// <summary>
        /// Permet de fermer la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
