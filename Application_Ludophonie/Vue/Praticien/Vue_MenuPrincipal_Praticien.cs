using Application_Ludophonie.Controleur;
using Application_Ludophonie.Controleur.Praticien;
using Application_Ludophonie.Metier;
using Application_Ludophonie.Vue.Praticien.Gestion_des_jeux;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie.Vue.Praticien
{
    public partial class Vue_MenuPrincipal_Praticien : Form
    {
        Controleur_MenuPrincipal_Praticien controleur = new Controleur_MenuPrincipal_Praticien();
        Utilisateur utilisateurEnCours;

        List<Utilisateur> lstTousLesPatients = new List<Utilisateur>();
        List<Serie> lstToutesSeriesEffectuees = new List<Serie>();

        public Vue_MenuPrincipal_Praticien(Utilisateur utilisateurEnCours)
        {
            InitializeComponent();

            this.utilisateurEnCours = utilisateurEnCours;
            initialiseInterface();

            if (dgvPatients.SelectedRows.Count == 1)
            {
                btnModifierPatient.Enabled = true;
            }
            else
            {
                btnModifierPatient.Enabled = false;
            }
        }

        private void initialiseInterface()
        {

            lblBienvenue.Text = "Bienvenue " + utilisateurEnCours.Prenom;


            //Initialisation tabPage 1
            actualiseDgvSeriesEffectuees();



            //Initialisation tabPage 2

            pNouveauPatient.Visible = false;
            lblMessage.Text = "";

            actualiseDgvPatient();


        }

        private void actualiseDgvPatient()
        {
            lstTousLesPatients.Clear();
            dgvPatients.Rows.Clear();
            lstTousLesPatients = controleur.recupereTousLesPatients();

            for (int i = 0; i < lstTousLesPatients.Count; i++)
            {
                dgvPatients.Rows.Add(lstTousLesPatients[i].Identifiant,
                    lstTousLesPatients[i].Prenom,
                    lstTousLesPatients[i].Nom
                    );

            }
        }

        private void actualiseDgvSeriesEffectuees()
        {
            lstToutesSeriesEffectuees = controleur.recupereToutesLesSeries();

            for (int i = 0; i < lstToutesSeriesEffectuees.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstToutesSeriesEffectuees[i].DateDuJour.ToString("d"),
                    lstToutesSeriesEffectuees[i].Nom,
                    lstToutesSeriesEffectuees[i].Prenom,
                    lstToutesSeriesEffectuees[i].Jeu,
                    lstToutesSeriesEffectuees[i].NbQuestionSerie,
                    lstToutesSeriesEffectuees[i].NbErreurs,
                    lstToutesSeriesEffectuees[i].Timer.ToString("mm:ss"));
            }
        }
               


                //Initialisation tabPage 3            

            

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Menu de navigation 
        //////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            tbc_MenuPrincipal.SelectedTab = tabPage1;
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            tbc_MenuPrincipal.SelectedTab = tabPage2;
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            tbc_MenuPrincipal.SelectedTab = tabPage3;
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Page d'accueil - tabPage 1
        //////////////////////////////////////////////////////////////////////////////////////////////////
        
        public int nbSeries = 0;       

        private void btnTriDateAujourd_hui_Click(object sender, EventArgs e)
        {
            dgvDernieresSeries.Rows.Clear();
            nbSeries = 0;

            List<Serie> lstSeriesEffectueesAujourdhui = new List<Serie>();
            lstSeriesEffectueesAujourdhui = controleur.recupereLesSeriesEffectueesAujourdhui();

            for (int i = 0; i < lstSeriesEffectueesAujourdhui.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstSeriesEffectueesAujourdhui[i].DateDuJour.ToString("d"), lstSeriesEffectueesAujourdhui[i].Nom, lstSeriesEffectueesAujourdhui[i].Prenom, lstSeriesEffectueesAujourdhui[i].Jeu, lstSeriesEffectueesAujourdhui[i].NbQuestionSerie, lstSeriesEffectueesAujourdhui[i].NbErreurs, lstSeriesEffectueesAujourdhui[i].Timer.ToString("mm:ss"));
                nbSeries++;
            }

            lblNbSerieEffectuees.Text = nbSeries.ToString();
        }

        private void btnTout_Click(object sender, EventArgs e)
        {
            dgvDernieresSeries.Rows.Clear();
            nbSeries = 0;

            List<Serie> lstSeriesEffectueesAujourdhui = new List<Serie>();
            lstSeriesEffectueesAujourdhui = controleur.recupereToutesLesSeries();
            

            for (int i = 0; i < lstSeriesEffectueesAujourdhui.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstSeriesEffectueesAujourdhui[i].DateDuJour.ToString("d"), lstSeriesEffectueesAujourdhui[i].Nom, lstSeriesEffectueesAujourdhui[i].Prenom, lstSeriesEffectueesAujourdhui[i].Jeu, lstSeriesEffectueesAujourdhui[i].NbQuestionSerie, lstSeriesEffectueesAujourdhui[i].NbErreurs, lstSeriesEffectueesAujourdhui[i].Timer.ToString("mm:ss"));
                nbSeries++;
            }

            lblNbSerieEffectuees.Text = nbSeries.ToString();
        }

        private void btnJMoins7_Click(object sender, EventArgs e)
        {
            dgvDernieresSeries.Rows.Clear();
            nbSeries = 0;

            List<Serie> lstSeriesEffectueesSemaine = new List<Serie>();
            lstSeriesEffectueesSemaine = controleur.recupereLesSeriesEffectueesSemaine();

            for (int i = 0; i < lstSeriesEffectueesSemaine.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstSeriesEffectueesSemaine[i].DateDuJour.ToString("d"), lstSeriesEffectueesSemaine[i].Nom, lstSeriesEffectueesSemaine[i].Prenom, lstSeriesEffectueesSemaine[i].Jeu, lstSeriesEffectueesSemaine[i].NbQuestionSerie, lstSeriesEffectueesSemaine[i].NbErreurs, lstSeriesEffectueesSemaine[i].Timer.ToString("mm:ss"));
                nbSeries++;
            }

            lblNbSerieEffectuees.Text = nbSeries.ToString();
        }

        private void btnTriMois_Click(object sender, EventArgs e)
        {

            dgvDernieresSeries.Rows.Clear();
            nbSeries = 0;

            List<Serie> lstSeriesEffectueesMois = new List<Serie>();
            lstSeriesEffectueesMois = controleur.recupereLesSeriesEffectueesMois();

            for (int i = 0; i < lstSeriesEffectueesMois.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstSeriesEffectueesMois[i].DateDuJour.ToString("d"), lstSeriesEffectueesMois[i].Nom, lstSeriesEffectueesMois[i].Prenom, lstSeriesEffectueesMois[i].Jeu, lstSeriesEffectueesMois[i].NbQuestionSerie, lstSeriesEffectueesMois[i].NbErreurs, lstSeriesEffectueesMois[i].Timer.ToString("mm:ss"));
                nbSeries++;
            }

            lblNbSerieEffectuees.Text = nbSeries.ToString();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Catalogue des patients - tabPage 2
        //////////////////////////////////////////////////////////////////////////////////////////////////

        bool bInfos = true;
        string identifiantPatientEnCours;
        Utilisateur patientEnCours;

        bool bUtilisateurCree;

        Utilisateur utilisateurAModifier;
        bool bUtilisatuerModifie;
        

        //******************************
        //Gestion du bouton Voir
        //*****************************
        private void btnVoir_Click(object sender, EventArgs e)
        {
            identifiantPatientEnCours = dgvPatients.CurrentRow.Cells["C_Identifiant"].Value.ToString();

            patientEnCours = controleur.recuperePatient(identifiantPatientEnCours);

            Vue_Detail_Patient fenetre_detailPatient = new Vue_Detail_Patient(patientEnCours);
            fenetre_detailPatient.Show();
        }

        //******************************
        //Gestion de l'ajour d'un nouveau patient
        //*****************************
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            pNouveauPatient.Visible = true;
            pBtnEnregistrerModif.Visible = false;

            lblTitrePModifAjoutPatient.Text = "Création d'un nouveau patient";
            btnEnregistrer_Ajout.Enabled = true;
        }

        private void btnEnregistrer_Ajout_Click(object sender, EventArgs e)
        {
            if (verifieNewInfosPatient() == true)
            {
                //enregistre le patient
                Utilisateur nouvelUtilisateur = new Utilisateur(0, null, txtbIdentifiant.Text, txtbNom.Text, txtbPrenom.Text, txtbClasse.Text, HashMotDePasse_Singleton.GetInstance().HashMotDePasse(txtbMotDePasse.Text), null);

                bUtilisateurCree = controleur.creeUtilisateur(nouvelUtilisateur);
                if(bUtilisateurCree == true)
                {
                    lblMessage.Text = "L'utilisateur a été créé";

                    txtbNom.Text = "";
                    txtbPrenom.Text = "";
                    txtbClasse.Text = "";
                    txtbIdentifiant.Text = "";
                    txtbMotDePasse.Text = "";
                    txtbMotDePasseConfirmation.Text = "";

                    actualiseDgvPatient();
                }
                else
                {
                    lblMessage.Text = "L'utilisateur n'a pas pus être créé";
                }              
                
            }
            else
            {
                
            }
        }

        //******************************
        //Gestion de la modification d'un patient
        //*****************************
        private void btnModifierPatient_Click(object sender, EventArgs e)
        {
            pBtnEnregistrerModif.Visible = true;

            if(dgvPatients.SelectedRows.Count == 1)
            {
                btnModifierPatient.Enabled = true;
                pNouveauPatient.Visible = true;
                lblTitrePModifAjoutPatient.Text = "Modification du patient";
                btnEnregistrer_Ajout.Enabled = true;

                identifiantPatientEnCours = dgvPatients.CurrentRow.Cells["C_Identifiant"].Value.ToString();

                for (int i = 0; i < lstTousLesPatients.Count; i++)
                {
                    if (lstTousLesPatients[i].Identifiant == identifiantPatientEnCours)
                    {
                        utilisateurAModifier = lstTousLesPatients[i];
                    }
                }


                txtbNom.Text = utilisateurAModifier.Nom;
                txtbPrenom.Text = utilisateurAModifier.Prenom;
                txtbClasse.Text = utilisateurAModifier.Classe;
                txtbIdentifiant.Text = utilisateurAModifier.Identifiant;
            }
            else
            {
                btnModifierPatient.Enabled = false; 
            }
           
        }
        private void btnEnregistrerModification_Click(object sender, EventArgs e)
        {

            if (verifieNewInfosPatient() == true)
            {
                utilisateurAModifier.Nom = txtbNom.Text;
                utilisateurAModifier.Prenom = txtbPrenom.Text;
                utilisateurAModifier.Classe = txtbClasse.Text;

                if (utilisateurAModifier.Identifiant != txtbIdentifiant.Text)
                {
                    utilisateurAModifier.Identifiant = txtbIdentifiant.Text;
                }

                if (utilisateurAModifier.Password != HashMotDePasse_Singleton.GetInstance().HashMotDePasse(txtbMotDePasse.Text))
                {
                    utilisateurAModifier.Password = HashMotDePasse_Singleton.GetInstance().HashMotDePasse(txtbMotDePasse.Text);
                }

                bUtilisatuerModifie = controleur.ModifieUtilisateur(utilisateurAModifier);
                if(bUtilisatuerModifie == true)
                {
                    lblMessage.Text = "L'utilisateur a bien été modifié";
                   
                    actualiseDgvPatient();

                    txtbNom.Text = "";
                    txtbPrenom.Text = "";
                    txtbClasse.Text = "";
                    txtbIdentifiant.Text = "";
                    txtbMotDePasse.Text = "";
                    txtbMotDePasseConfirmation.Text = "";
                }
                else
                {
                    lblMessage.Text = "L'utilisateur n'a pas pus être modifié";
                }
            }
            else
            {
                verifieNewInfosPatient();
            }
        }

        //******************************
        //Méthodes outils
        //*****************************
        private bool verifieNewInfosPatient()
        {
            if(txtbNom.Text == "" || txtbPrenom.Text == "" || txtbClasse.Text == "" || txtbIdentifiant.Text == "" || txtbMotDePasse.Text == "" || txtbMotDePasseConfirmation.Text == "")
            {
                lblMessage.Text = "Un des champs est vide";
                bInfos = false;
            }
            else
            {
                for(int i = 0; i < lstTousLesPatients.Count; i++)
                {
                    if(lstTousLesPatients[i].Identifiant == txtbIdentifiant.Text)
                    {
                        lblMessage.Text = "Identifiant non disponible";
                        bInfos = false;
                    }
                    else
                    {
                        if(txtbMotDePasse.Text != txtbMotDePasseConfirmation.Text)
                        {
                            lblMessage.Text = "Mot de passe différents";
                            bInfos = false;
                        }
                        else
                        {
                            bool contientMajuscule = Regex.IsMatch(txtbMotDePasse.Text, "[A-Z]");
                            bool contientMinuscule = Regex.IsMatch(txtbMotDePasse.Text, "[a-z]");
                            bool contientChiffre = Regex.IsMatch(txtbMotDePasse.Text, "[0-9]");
                            bool nbCaracteres = Regex.IsMatch(txtbMotDePasse.Text, ".{12,}");
                            bool caractereSpeciaux = Regex.IsMatch(txtbMotDePasse.Text, @"^[a-zA-Z0-9@#$%^&*]+$");

                            if (contientMajuscule && contientMinuscule && contientChiffre && nbCaracteres && caractereSpeciaux)
                            {
                                bInfos = true;
                            }
                            else
                            {
                                lblMessage.Text = "Le mot de passe doit contenir au moins 12 caractères \n dont une majuscule, une minusucle, un chiffre et \n un caractère spécial autorisé(@#$%^&*+$)";
                                bInfos = false;
                            }
                        }

                    }
                }
                
            }

            return bInfos;
        }
       

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pNouveauPatient.Visible = false;

            txtbNom.Text = "";
            txtbPrenom.Text = "";
            txtbClasse.Text = "";
            txtbIdentifiant.Text = "";
            txtbMotDePasse.Text = "";
            txtbMotDePasseConfirmation.Text = "";

            lblMessage.Text = "";
        }

        private void txtbNom_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbPrenom_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbClasse_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbIdentifiant_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbMotDePasse_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbMotDePasseConfirmation_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        //******************************
        //Gestion de l'ouverture du carnet de missions
        //*****************************

        private void btnCarnetDeQuetes_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                identifiantPatientEnCours = dgvPatients.CurrentRow.Cells["C_Identifiant"].Value.ToString();

                patientEnCours = controleur.recuperePatient(identifiantPatientEnCours);

                Vue_Gestion_Carnets_De_Quetes fenetre__Gestion_CarnetDeQuetes = new Vue_Gestion_Carnets_De_Quetes(patientEnCours.IdUtilisateur);
                fenetre__Gestion_CarnetDeQuetes.Show();
            }            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                identifiantPatientEnCours = dgvPatients.CurrentRow.Cells["C_Identifiant"].Value.ToString();
                patientEnCours = controleur.recuperePatient(identifiantPatientEnCours);

                bool bSupprimeUtilisateur = controleur.SupprimeUtilisateur(patientEnCours);
                bool bSupprimeSesSeries = true;

                for (int i = 0; i<lstToutesSeriesEffectuees.Count;i++)
                {
                    if(lstToutesSeriesEffectuees[i].IdUtilisateur == patientEnCours.IdUtilisateur)
                    {
                        bSupprimeSesSeries = controleur.SupprimeSesSeries(patientEnCours);
                    }
                }                

                if(bSupprimeUtilisateur == true && bSupprimeSesSeries == true)
                {
                    lblMeessageSuppression.Text = "L'utilisateur a bien été supprimé";
                    actualiseDgvPatient();
                    actualiseDgvSeriesEffectuees();
                }
                else
                {
                    lblMeessageSuppression.Text = "L'utilisateur n'a pas pus etre supprimé";
                    actualiseDgvPatient();
                    actualiseDgvSeriesEffectuees();
                }
               
            }
        }

        private void btnGestion_JeuDuMot_Click(object sender, EventArgs e)
        {
            Vue_Gestionnaire_JeuLeMot fenetre_Gestionnaire_JeuDuMot = new Vue_Gestionnaire_JeuLeMot();
            fenetre_Gestionnaire_JeuDuMot.Show();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// Gestion des jeux - tabPage 3
        //////////////////////////////////////////////////////////////////////////////////////////////////


    }
}
