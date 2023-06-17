using Application_Ludophonie.Controleur.Praticien.Gestion;
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
using Serilog;

namespace Application_Ludophonie.Vue.Praticien.Gestion_des_jeux
{
    public partial class Vue_Gestionnaire_JeuLeMot : Form
    {
        Controleur_Gestion_JeuDuMot controleur = new Controleur_Gestion_JeuDuMot();

        /// <summary>
        /// Constructeur
        /// </summary>
        public Vue_Gestionnaire_JeuLeMot()
        {
            InitializeComponent();

            actualiseDgvLstMots();
            rempliCbx();
        }

        private void Vue_Gestionnaire_JeuLeMot_Load(object sender, EventArgs e)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("logs/logs_CreationMots.txt",
                rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        ///Gestion du CRUD
        //////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet d'enregistrer de nouveaux mots 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerNewMot_Click(object sender, EventArgs e)
        {
            string liste = "";

            if (txtbMot.Text != "" && txtbContexte.Text != "" && cbxTypeListe.SelectedItem.ToString() != "")
            {
                liste = cbxTypeListe.SelectedItem.ToString();

                bool bEnregistrer = controleur.enregistreUnMot(txtbMot.Text, txtbContexte.Text, cbxTypeListe.SelectedIndex + 1);

                if (bEnregistrer)
                {
                    //Pour tous les utilisateurs de la base, ajouter un tuple pour le nouveau mot
                    ajoutTupleBDD();
                    actualiseDgvParListe(liste);

                    Log.Information("Un mot a bien été créé : " + txtbMot.Text);

                    lblMessage.Text = "Le mot '" + txtbMot.Text + "'a bien été ajouté";
                    txtbMot.Text = "";
                    txtbContexte.Text = "";
                    cbxTypeListe.SelectedIndex = 0;
                }
                else
                {
                    lblMessage.Text = "Le mot '" + txtbMot.Text + "'n'a pas été ajouté";
                    Log.Error("Le mot '" + txtbMot.Text + "'n'a pas été ajouté");

                }
            }
            else
            {
                lblMessage.Text = "Au moins un champs du formulaire est vide";
            }

        }

        /// <summary>
        /// Permet de supprimer un mot ainsi que toutes les informations qui lui sont ratachées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnSupprimer_Click(object sender, EventArgs e)
        {
            string motAsupprimer = "";

            if (dgvLstMots.SelectedRows.Count == 1)
            {
                motAsupprimer = dgvLstMots.CurrentRow.Cells["C_Mot"].Value.ToString();

                supprimeTupleBDD(motAsupprimer);

                bool bSupprimer = controleur.supprimeUnMot(motAsupprimer);

                if (bSupprimer)
                {
                    lblMessage.Text = "Le mot a bien été supprimé";
                    txtbMot.Text = "";
                    txtbContexte.Text = "";
                    cbxTypeListe.SelectedIndex = 0;

                    if (cbxTriListes.SelectedItem == null)
                    {
                        actualiseDgvLstMots();
                    }
                    else
                    {
                        actualiseDgvParListe(cbxTriListes.SelectedItem.ToString());
                    }
                }
                else
                {
                    lblMessage.Text = "Le mot n'a pas pus etre supprimé";
                }
            }
            else
            {
                lblMessage.Text = "Selectionnez un mot à supprimer";
            }

        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        ///Méthodes outils
        //////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Permet de créer des tuples dans la table qui gère l'acquisition des mots
        /// </summary>
        private void ajoutTupleBDD()
        {
            //recupererle nouveau mot
            int idDernierMot = controleur.recupereDernierMotCree();

            //recuperer la liste des id d'utilisateur de la base            
            List<int> lstIdPatients = controleur.lstidPatient();

            for (int j = 0; j < lstIdPatients.Count; j++)
            {
                controleur.creationAcquisition_leMot(lstIdPatients[j], idDernierMot, 1);
            }
        }

        /// <summary>
        /// Permet de supprimer des tuples dans la table qui gère l'acquisition des mots
        /// </summary>
        private void supprimeTupleBDD(string mot)
        {
            //recuperer le mot selectionné 
            Mot motASupprimer = controleur.recupereUnmot(mot);

            //recuperer la liste des id d'utilisateur de la base
            List<int> lstIdDespatients = controleur.lstidPatient();

            //boucle de suppression
            for (int j = 0; j < lstIdDespatients.Count; j++)
            {
                controleur.supprimeTuplesBDD(lstIdDespatients[j], motASupprimer.IdMot);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        ///Gestion de l'interface
        //////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet de remplir le comboBox contenant les niveaux de liste
        /// </summary>
        private void rempliCbx()
        {            
            List<string> lstTouteslistes = controleur.recupereToutesListes();

            for(int i = 0; i < lstTouteslistes.Count; i++)
            {
                cbxTriListes.Items.Add(lstTouteslistes[i]);
                cbxTypeListe.Items.Add(lstTouteslistes[i]);
            }
        }

        /// <summary>
        /// Permet d'actualiser le datagridview contenant les mots qui seront proposés en exercice
        /// avec tous les mots de la base, sans filtrage
        /// </summary>
        private void actualiseDgvLstMots()
        {
            List<Mot> lstTousLesMots = new List<Mot>();
            lstTousLesMots.Clear();
            dgvLstMots.Rows.Clear();

            lstTousLesMots = controleur.recupereTousLesMots();

            for (int i = 0; i < lstTousLesMots.Count; i++)
            {
                dgvLstMots.Rows.Add(lstTousLesMots[i].LeMot, lstTousLesMots[i].Contexte, lstTousLesMots[i].Liste);
            }
        }

        /// <summary>
        /// Permet de changer le paramètre de tri des séries sur un critère de liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTriListes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string liste = cbxTriListes.SelectedItem.ToString();          

            actualiseDgvParListe(liste);
        }

        /// <summary>
        /// Permet d'actualiser le datagridview contenant les mots qui seront proposés en exercice
        /// avec tous les mots d'une liste
        /// </summary>
        private void actualiseDgvParListe(string liste)
        {
            List<Mot> lstTousLesMotsListe = new List<Mot>();
            lstTousLesMotsListe.Clear();
            dgvLstMots.Rows.Clear();

            lstTousLesMotsListe = controleur.recupereTousLesMotsDelaListe(liste);

            for (int i = 0; i < lstTousLesMotsListe.Count; i++)
            {
                dgvLstMots.Rows.Add(lstTousLesMotsListe[i].LeMot, lstTousLesMotsListe[i].Contexte, lstTousLesMotsListe[i].Liste);
            }
        }

        /// <summary>
        /// Permet de fermer la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
