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
    public partial class Vue_Detail_Patient : Form
    {
        Utilisateur patientEnCours;
        Controleur_Detail_Patient controleur = new Controleur_Detail_Patient();

        public Vue_Detail_Patient(Utilisateur patientEnCours)
        {
            InitializeComponent();

            this.patientEnCours = patientEnCours;
            actualiseInfosPatient();
            remplisCbxJeux();
            actualiseDgvSeries_Neutre(patientEnCours.IdUtilisateur);

        }

        private void actualiseInfosPatient()
        {
            pbxAvatar.ImageLocation = patientEnCours.urlAvatar;
            lblIdentifiant.Text = patientEnCours.Identifiant;
            lblNom.Text = patientEnCours.Nom;
            lblPrenom.Text = patientEnCours.Prenom;
            lblClasse.Text = patientEnCours.Classe;
        }

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



        private void actualiseDgvSeries_Jeu(int idUtilisateur, string nomDuJeu)
        {
            dgvSeries.Rows.Clear();

            List<Serie> lstSerieDuJeu = new List<Serie>();
            lstSerieDuJeu = controleur.recupereToutesSeriesJeu(idUtilisateur, nomDuJeu);

            for (int i = 0; i < lstSerieDuJeu.Count; i++)
            {
                dgvSeries.Rows.Add(lstSerieDuJeu[i].DateDuJour.ToString("d"), lstSerieDuJeu[i].Jeu, lstSerieDuJeu[i].NbQuestionSerie, lstSerieDuJeu[i].NbErreurs, lstSerieDuJeu[i].Timer.ToString("mm:ss"));
            }
        }

        private void actualiseDgvSeries_Neutre(int idUtilisateur)
        {
            dgvSeries.Rows.Clear();

            List<Serie> lstSerieDuJeu = new List<Serie>();
            lstSerieDuJeu = controleur.recupereToutesSeriesUtilisateur(idUtilisateur);

            for (int i = 0; i < lstSerieDuJeu.Count; i++)
            {
                dgvSeries.Rows.Add(lstSerieDuJeu[i].DateDuJour.ToString("d"), lstSerieDuJeu[i].Jeu, lstSerieDuJeu[i].NbQuestionSerie, lstSerieDuJeu[i].NbErreurs, lstSerieDuJeu[i].Timer.ToString("mm:ss"));
            }
        }

        private void cbxJeux_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxJeux.SelectedItem.ToString() == "Tous")
            {
                actualiseDgvSeries_Neutre(patientEnCours.IdUtilisateur);
            }
            else
            {
                actualiseDgvSeries_Jeu(patientEnCours.IdUtilisateur, cbxJeux.SelectedItem.ToString());
            }
        }
    }
}
