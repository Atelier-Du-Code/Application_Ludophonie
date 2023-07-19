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
    /// Vue - Fiche de patient - Côté praticien
    /// </summary>
    public partial class Vue_Detail_Patient : Form
    {
        Utilisateur patientEnCours;
        Controleur_Detail_Patient controleur = new Controleur_Detail_Patient();

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="patientEnCours"></param>
        public Vue_Detail_Patient(Utilisateur patientEnCours)
        {
            InitializeComponent();

            this.patientEnCours = patientEnCours;
            actualiseInfosPatient();
            remplisCbxJeux();
            //actualiseDgvSeries_Neutre(patientEnCours.IdUtilisateur);

        }
    
        /// <summary>
        /// Permet d'actualiser les textBox renseignant les informations du patient en cours
        /// </summary>
        private void actualiseInfosPatient()
        {
            pbxAvatar.ImageLocation = patientEnCours.UrlAvatar;
            lblIdentifiant.Text = patientEnCours.Identifiant;
            lblNom.Text = patientEnCours.Nom;
            lblPrenom.Text = patientEnCours.Prenom;
            lblClasse.Text = patientEnCours.Classe;
            lblGrade.Text = patientEnCours.Grade;
            lblScoreGlobal.Text = patientEnCours.Score_Global.ToString();
        }
    
        /// <summary>
        /// Permet de remplir le comboBox contenant le nom des jeux
        /// </summary>
        private void remplisCbxJeux()
        {
            List<string> lstJeux = new List<string>();

            lstJeux = controleur.recupereTousLesJeux();

            cbxJeux.Items.Add("Tous");

            for (int i = 0; i < lstJeux.Count; i++)
            {
                cbxJeux.Items.Add(lstJeux[i]);
            }
        }

        int ligneDGV = 0;

        /// <summary>
        /// Permet d'actualiser le DataGriedView contenant toutes les séries 
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="nomDuJeu"></param>
        private void actualiseDgvSeries_Jeu(int idUtilisateur, string nomDuJeu)
        {
           dgvSeries.Rows.Clear();

           List<Serie> lstSerieDuJeu = controleur.recupereToutesSeriesJeu(idUtilisateur, nomDuJeu);
            

           for (int i = 0; i < lstSerieDuJeu.Count; i++)
           {
               dgvSeries.Rows.Add(lstSerieDuJeu[i].DateDuJour.ToString("d"), lstSerieDuJeu[i].Jeu, lstSerieDuJeu[i].NbQuestionSerie, lstSerieDuJeu[i].NbErreurs, lstSerieDuJeu[i].Timer.ToString("mm:ss"), lstSerieDuJeu[i].Score);
                
                if (lstSerieDuJeu[i].SerieDemandee == 1)
                {
                    dgvSeries.Rows[ligneDGV].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                }
                else
                {
                    dgvSeries.Rows[ligneDGV].DefaultCellStyle.BackColor = Color.FromArgb(242, 250, 252);
                }
            }
        }

        /// <summary>
        /// Permet d'actualiser le DataGriedView contenant toutes les séries avec toutes les séries d'un utilisateur
        /// </summary>
        /// <param name="idUtilisateur"></param>
        private void actualiseDgvSeries_Neutre(int idUtilisateur)
        {
            dgvSeries.Rows.Clear();

            List<Serie> lstSerieDuJeu = controleur.recupereToutesSeriesUtilisateur(idUtilisateur);

            for (int i = 0; i < lstSerieDuJeu.Count; i++)
            {
                dgvSeries.Rows.Add(lstSerieDuJeu[i].DateDuJour.ToString("d"), lstSerieDuJeu[i].Jeu, lstSerieDuJeu[i].NbQuestionSerie, lstSerieDuJeu[i].NbErreurs, lstSerieDuJeu[i].Timer.ToString("mm:ss"), lstSerieDuJeu[i].Score);
            }
        }
        
        /// <summary>
        /// Permet d'actualiser le DataGriedView contenant toutes les séries avec toutes les séries d'un utilisateur 
        /// sur le critère de filtrage du jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void cbxJeux_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxJeux.SelectedItem.ToString() == "Tous")
            {
                actualiseDgvSeries_Neutre(patientEnCours.IdUtilisateur);
                lblNiveauJeu.Text = "-";
            }
            else
            {
                actualiseDgvSeries_Jeu(patientEnCours.IdUtilisateur, cbxJeux.SelectedItem.ToString());

                string niveauDUJeu = controleur.recupereNiveauDeJeuPourUnPatient(patientEnCours.IdUtilisateur, cbxJeux.SelectedItem.ToString());

                lblNiveauJeu.Text = "Niveau de jeu : " + niveauDUJeu;
            }
        }
        private void cbxJeux_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxJeux.SelectedItem.ToString() == "Tous")
            {
                actualiseDgvSeries_Neutre(patientEnCours.IdUtilisateur);
                lblNiveauJeu.Text = "-";
            }
            else
            {
                actualiseDgvSeries_Jeu(patientEnCours.IdUtilisateur, cbxJeux.SelectedItem.ToString());

                string niveauDUJeu = controleur.recupereNiveauDeJeuPourUnPatient(patientEnCours.IdUtilisateur, cbxJeux.SelectedItem.ToString());

                lblNiveauJeu.Text = "Niveau de jeu : " + niveauDUJeu;
            }
        }

        private void dgvSeries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ligneDGV = e.RowIndex;
        }
        /// <summary>
        /// Permet de fermer la fenêtre en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
