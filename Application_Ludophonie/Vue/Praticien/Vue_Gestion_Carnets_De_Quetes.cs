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
    public partial class Vue_Gestion_Carnets_De_Quetes : Form
    {
        private Controleur_Gestion_Carnet__De_Mission controleur = new Controleur_Gestion_Carnet__De_Mission();

        private List<string> lstMissions = new List<string>();

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
        }        

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Gestion de l'ajout d'une mission
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet d'enregistrer une nouvelle mission pour le patient en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string mission = txtbMission.Text;
            txtbMission.Text = "";

            bool bEnregistrer = controleur.enregistreMissions(mission, idUtilisateurEnCours);
            if(bEnregistrer)
            {
                lblMessage.Text = "La mission a bien été enregistrée";
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
            if(lstBMissions.SelectedIndex > 0)
            {
                bool bSupprimer = controleur.supprimeUneMission(lstBMissions.SelectedItem.ToString(), idUtilisateurEnCours);

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
        ///Méthode de gestion + Interface
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet d'actualiser la listBox contenant les missions du patient en cours
        /// </summary>
        private void actualiseListeMissions()
        {
            lstMissions.Clear();
            lstMissions = controleur.recupereToutesMissions(idUtilisateurEnCours);

            lstBMissions.Items.Clear();
            for (int i = 0; i < lstMissions.Count; i++)
            {
                lstBMissions.Items.Add(lstMissions[i]);
            }
        }

        /// <summary>
        /// Permet de vider le label de message lorsqu'une lettre est écrite dans le textBox d'ajout de mission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbMission_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
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
