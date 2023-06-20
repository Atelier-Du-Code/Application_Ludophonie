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
using Serilog;

namespace Application_Ludophonie.Vue.Praticien
{
    /// <summary>
    /// Vue - Menu principal - Côté praticien
    /// </summary>
    public partial class Vue_MenuPrincipal_Praticien : Form
    {
        Utilisateur utilisateurEnCours;

        private Controleur_MenuPrincipal_Praticien controleur = new Controleur_MenuPrincipal_Praticien();



        ///////////////////////////////////////////
        ///Gestion des variables de l'accueil
        ///////////////////////////////////////////

        private List<Serie> lstToutesSeriesEffectuees = new List<Serie>();
        private int nbSeries = 0;

        ///////////////////////////////////////////////////////
        ///Gestion des variables du catalogue des patients
        ///////////////////////////////////////////////////////

        private List<Utilisateur> lstTousLesPatients = new List<Utilisateur>();

        Utilisateur patientEnCours;
        Utilisateur utilisateurAModifier;
        /// <summary>
        /// Permet l'échange du nouveau patient entre la vue de création d'un nouveau patient et du menu principal
        /// </summary>
        public Utilisateur nouvelUtilisateur;

       // private bool bIdentifiantValide = true;
        private bool bInfosIdentifiant = true;
        private bool bInfosMotDePasse = true;
        private bool bUtilisateurCree;



        string identifiantPatientEnCours;

        /// <summary>
        /// Contructeur de la classe : Vue_MenuPrincipal_Praticien
        /// </summary>
        /// <param name="utilisateurEnCours"></param>
        public Vue_MenuPrincipal_Praticien(Utilisateur utilisateurEnCours)
        {
            InitializeComponent();
            this.utilisateurEnCours = utilisateurEnCours;

        }

        private void Vue_MenuPrincipal_Praticien_Load(object sender, EventArgs e)
        {
            lblBienvenue.Text = "Bienvenue " + utilisateurEnCours.Prenom + " !";

            //Initialisation tabPage 1
            actualiseDgvSeriesEffectuees();

            //Initialisation tabPage 2

            pNouveauPatient.Visible = false;
            lblMessage.Text = "";

            actualiseDgvPatient();

            dgvPatients.ClearSelection();

            if(dgvPatients.SelectedRows.Count < 1)
            {
                btnModifierPatient.Enabled = false;
            }

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("logs/logs_Utilisateurs.txt",
                rollingInterval: RollingInterval.Day)
                .CreateLogger();

            lblMeessageSuppression.Text = "";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///Initialisation de l'interface des différentes pages du panneau
        //////////////////////////////////////////////////////////////////////////////////////////////////

        //Initialisation tabPage 1 - Accueil

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

        //Initialisation tabPage 2 - Catalogue des patients

        /// <summary>
        /// Permet d'actualiser le DataGridView contenant la liste des patients
        /// </summary>
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

        //////////////////////////////////////////////////////////////////////////////////////////////////
        //Menu de navigation 
        //////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet d'afficherla page d'accueil du menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            tbc_MenuPrincipal.SelectedTab = tabPage1;
        }
        /// <summary>
        /// Permet d'afficher le catalogue des patients 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            tbc_MenuPrincipal.SelectedTab = tabPage2;
        }

        /// <summary>
        /// Permet d'afficher la page permettant d'accéder aux interface de gestion des différents jeux 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestion_Click(object sender, EventArgs e)
        {
            tbc_MenuPrincipal.SelectedTab = tabPage3;
        }

        /// <summary>
        /// Permet de quitter le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Page d'accueil - tabPage 1
        //////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet de n'afficher que les séries ayant été faites aujourd'hui
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTriDateAujourd_hui_Click(object sender, EventArgs e)
        {
            dgvDernieresSeries.Rows.Clear();
            nbSeries = 0;
             
            List<Serie>  lstSeriesEffectueesAujourdhui = controleur.recupereLesSeriesEffectueesAujourdhui();

            for (int i = 0; i < lstSeriesEffectueesAujourdhui.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstSeriesEffectueesAujourdhui[i].DateDuJour.ToString("d"), lstSeriesEffectueesAujourdhui[i].Nom, lstSeriesEffectueesAujourdhui[i].Prenom, lstSeriesEffectueesAujourdhui[i].Jeu, lstSeriesEffectueesAujourdhui[i].NbQuestionSerie, lstSeriesEffectueesAujourdhui[i].NbErreurs, lstSeriesEffectueesAujourdhui[i].Timer.ToString("mm:ss"));
                nbSeries++;
            }

            lblNbSerieEffectuees.Text = nbSeries.ToString();
        }

        /// <summary>
        /// Permet d'afficher toutes les séries effectuées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTout_Click(object sender, EventArgs e)
        {
            dgvDernieresSeries.Rows.Clear();
            nbSeries = 0;
           
            List<Serie> lstSeriesEffectueesAujourdhui = controleur.recupereToutesLesSeries();            

            for (int i = 0; i < lstSeriesEffectueesAujourdhui.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstSeriesEffectueesAujourdhui[i].DateDuJour.ToString("d"), lstSeriesEffectueesAujourdhui[i].Nom, lstSeriesEffectueesAujourdhui[i].Prenom, lstSeriesEffectueesAujourdhui[i].Jeu, lstSeriesEffectueesAujourdhui[i].NbQuestionSerie, lstSeriesEffectueesAujourdhui[i].NbErreurs, lstSeriesEffectueesAujourdhui[i].Timer.ToString("mm:ss"));
                nbSeries++;
            }

            lblNbSerieEffectuees.Text = nbSeries.ToString();
        }

        /// <summary>
        /// Permet de n'afficher que les séries ayant été faites pendant les 7 derniers jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJMoins7_Click(object sender, EventArgs e)
        {
            dgvDernieresSeries.Rows.Clear();
            nbSeries = 0;

           
            List<Serie> lstSeriesEffectueesSemaine = controleur.recupereLesSeriesEffectueesSemaine();

            for (int i = 0; i < lstSeriesEffectueesSemaine.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstSeriesEffectueesSemaine[i].DateDuJour.ToString("d"), lstSeriesEffectueesSemaine[i].Nom, lstSeriesEffectueesSemaine[i].Prenom, lstSeriesEffectueesSemaine[i].Jeu, lstSeriesEffectueesSemaine[i].NbQuestionSerie, lstSeriesEffectueesSemaine[i].NbErreurs, lstSeriesEffectueesSemaine[i].Timer.ToString("mm:ss"));
                nbSeries++;
            }

            lblNbSerieEffectuees.Text = nbSeries.ToString();
        }

        /// <summary>
        /// Permet de n'afficher que les séries ayant été faites pendant les 30 derniers jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTriMois_Click(object sender, EventArgs e)
        {

            dgvDernieresSeries.Rows.Clear();
            nbSeries = 0;
            
            List<Serie> lstSeriesEffectueesMois = controleur.recupereLesSeriesEffectueesMois();

            for (int i = 0; i < lstSeriesEffectueesMois.Count; i++)
            {
                dgvDernieresSeries.Rows.Add(lstSeriesEffectueesMois[i].DateDuJour.ToString("d"), lstSeriesEffectueesMois[i].Nom, lstSeriesEffectueesMois[i].Prenom, lstSeriesEffectueesMois[i].Jeu, lstSeriesEffectueesMois[i].NbQuestionSerie, lstSeriesEffectueesMois[i].NbErreurs, lstSeriesEffectueesMois[i].Timer.ToString("mm:ss"));
                nbSeries++;
            }

            lblNbSerieEffectuees.Text = nbSeries.ToString();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Catalogue des patients - tabPage 2
        //////////////////////////////////////////////////////////////////////////////////////////////////

       
        //******************************
        //Gestion du bouton Voir
        //*****************************

        /// <summary>
        /// Permet d'instancier la page de détail d'un patient séléctionné dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoir_Click(object sender, EventArgs e)
        {         
            pNouveauPatient.Visible = false;

            identifiantPatientEnCours = dgvPatients.CurrentRow.Cells["C_Identifiant"].Value.ToString();

            patientEnCours = controleur.recuperePatient(identifiantPatientEnCours);

            Vue_Detail_Patient fenetre_detailPatient = new Vue_Detail_Patient(patientEnCours);
            fenetre_detailPatient.ShowDialog();
        }

        //******************************
        //Gestion de l'ajout d'un nouveau patient
        //*****************************

        /// <summary>
        /// Permet de faire apparaître la fenetre d'ajout d'un nouveau patient
        /// Permet d'ajouter un patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Vue_Ajout_De_Patient fenetreAjoutPatient = new Vue_Ajout_De_Patient(lstTousLesPatients, utilisateurEnCours);
            fenetreAjoutPatient.ShowDialog();

            nouvelUtilisateur = fenetreAjoutPatient.utilisateurAAjouter;
            bUtilisateurCree = controleur.creeUtilisateur(nouvelUtilisateur);
            if (bUtilisateurCree)
            {
                lblMessage.Text = "L'utilisateur a été créé";

                creationTupleBdd();
                videLesChamps();
                actualiseDgvPatient();
                btnModifierPatient.Enabled = false;

                Log.Information("Un patient à été créé");
            }
            else
            {

                lblMessage.Text = "Le nouveau patient n'a pas pus être créé";
                Log.Error("la création d'un nouveau patient a échouée");
            }

        }   

        //******************************
        //Gestion de la modification d'un patient
        //*****************************

        /// <summary>
        /// Permet de faire apparaître le panel de modification d'un patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierPatient_Click(object sender, EventArgs e)
        {           
            pNouveauPatient.Visible = true;
            btnModifierPatient.BackColor = Color.FromArgb(116, 159, 171);
            btnAjouter.BackColor = Color.FromArgb(172, 215, 227);

            txtbMotDePasse.UseSystemPasswordChar = true;
            txtbMotDePasseConfirmation.UseSystemPasswordChar = true;

            lblTitrePModifAjoutPatient.Text = "Modification d'un patient";
            lblMeessageSuppression.Text = ""; 

            if(dgvPatients.SelectedRows.Count > 0)
            {
                txtbNom.Text = utilisateurAModifier.Nom;
                txtbPrenom.Text = utilisateurAModifier.Prenom;
                txtbClasse.Text = utilisateurAModifier.Classe;
                txtbIdentifiant.Text = utilisateurAModifier.Identifiant;
                txtbMotDePasse.Text = utilisateurAModifier.Password;
                txtbMotDePasseConfirmation.Text = utilisateurAModifier.Password;
            }
            

        }

        /// <summary>
        /// Permet de modifier un patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModification_Click(object sender, EventArgs e)
        {
            if (txtbNom.Text != "" || txtbPrenom.Text != "" || txtbClasse.Text != "" || txtbIdentifiant.Text != "" || txtbMotDePasse.Text != "" || txtbMotDePasseConfirmation.Text != "")
            {
                if (txtbNom.Text != utilisateurAModifier.Nom)
                {
                    utilisateurAModifier.Nom = txtbNom.Text;
                }

                if (txtbPrenom.Text != utilisateurAModifier.Prenom)
                {
                    utilisateurAModifier.Prenom = txtbPrenom.Text;
                }

                if (txtbClasse.Text != utilisateurAModifier.Classe)
                {
                    utilisateurAModifier.Classe = txtbClasse.Text;
                }

                if (txtbIdentifiant.Text != utilisateurAModifier.Identifiant)
                {
                    //Verifie si il y a pas déjà cet identifiant utilisé dans la base
                    if(verifieIdentifiant())
                    {
                        utilisateurAModifier.Identifiant = txtbIdentifiant.Text;
                    }  
                    else
                    {
                        lblMessage.Text = "Cet identifiant est déja utilisé";
                    }
                }

                //Si les deux champs de mot de passe sont identiques
                if (txtbMotDePasse.Text == txtbMotDePasseConfirmation.Text)
                {
                    //si le mot de passe des textBox est différent de celui de la base
                    if (txtbMotDePasse.Text != utilisateurAModifier.Password)
                    {
                        //vérifie si la composition du mot de passe est correcte
                        if(verifieMotDePasse())
                        {
                            utilisateurAModifier.Password = txtbMotDePasse.Text;
                        }
                        else
                        {
                            lblMessage.Visible = true;
                        }
                        
                    }
                   
                }
                else
                {
                    lblMessage.Text = "Les deux mots de passe entrés sont différents";

                }
            }
            else
            {
                lblMessage.Text = "Veillez à remplir tous les champs du formulaire";
            }

            bool bUtilisateurModifie = controleur.ModifieUtilisateur(utilisateurAModifier);

            if (bUtilisateurModifie)
            {
                lblMessage.Text = "L'utilisateur a bien été modifié";

                actualiseDgvPatient();

                videLesChamps();               
                
                btnModifierPatient.BackColor = Color.FromArgb(172, 215, 227);
                pNouveauPatient.Visible = false;

                Log.Information("l'utilisateur " + utilisateurAModifier.Identifiant + " a bien été modifié");
            }
            else
            {
                lblMessage.Text = "L'utilisateur n'a pas pus être modifié";
            }
        }

        /// <summary>
        /// Permet au clic sur une des cellules du datagriedview lisant les patients la selection en vue
        /// de la modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifierPatient.Enabled = true;
            lblMeessageSuppression.Text = "";

            if (dgvPatients.SelectedRows.Count == 1)
            {
                btnModifierPatient.Enabled = true;
                pNouveauPatient.Visible = true;
                lblTitrePModifAjoutPatient.Text = "Modification d'un patient";
                lblMeessageSuppression.Text = "";

                txtbMotDePasse.UseSystemPasswordChar = true;
                txtbMotDePasseConfirmation.UseSystemPasswordChar = true;

                identifiantPatientEnCours = dgvPatients.CurrentRow.Cells["C_Identifiant"].Value.ToString();

                for (int i = 0; i < lstTousLesPatients.Count; i++)
                {
                    if (lstTousLesPatients[i].Identifiant == identifiantPatientEnCours)
                    {
                        //Définition du patient à modifier
                        utilisateurAModifier = lstTousLesPatients[i];
                    }
                }

                //Récupération des informations de ce patient pour alimenter les textBox 
                txtbNom.Text = utilisateurAModifier.Nom;
                txtbPrenom.Text = utilisateurAModifier.Prenom;
                txtbClasse.Text = utilisateurAModifier.Classe;
                txtbIdentifiant.Text = utilisateurAModifier.Identifiant;
                txtbMotDePasse.Text = utilisateurAModifier.Password;
                txtbMotDePasseConfirmation.Text = utilisateurAModifier.Password;
            }     
            else
            {
                videLesChamps();
            }
        }

        //******************************
        //Méthodes outils
        //*****************************
        
        /// <summary>
        /// Permet de vérifier si un identifiant n'est pas déjà inscrit dans la base
        /// </summary>
        /// <returns></returns>
        private bool verifieIdentifiant()
        {
            for (int i = 0; i < lstTousLesPatients.Count; i++)
            {
                if (lstTousLesPatients[i].Identifiant == txtbIdentifiant.Text)
                {
                    lblMessage.Text = "Identifiant non disponible";
                    bInfosIdentifiant = false;
                }
                else
                {
                    bInfosIdentifiant = true;
                }
            }

            return bInfosIdentifiant;
        }

        /// <summary>
        /// Permet de vérifier que le mot de passe est bien composé de 12 caractères dont :
        /// une majuscule, une minuscule, un chiffre et un caractètre spécial parmis les caractères autorisés 
        /// </summary>
        /// <returns></returns>
        private bool verifieMotDePasse()
        {
            bool contientMajuscule = Regex.IsMatch(txtbMotDePasse.Text, "[A-Z]");
            bool contientMinuscule = Regex.IsMatch(txtbMotDePasse.Text, "[a-z]");
            bool contientChiffre = Regex.IsMatch(txtbMotDePasse.Text, "[0-9]");
            bool nbCaracteres = Regex.IsMatch(txtbMotDePasse.Text, ".{12,}");
            bool caractereSpeciaux = Regex.IsMatch(txtbMotDePasse.Text, @"^[a-zA-Z0-9@#$%^&*]+$");

            if (contientMajuscule && contientMinuscule && contientChiffre && nbCaracteres && caractereSpeciaux)
            {
                bInfosMotDePasse = true;
            }
            else
            {                
                bInfosMotDePasse = false;
            }

            return bInfosMotDePasse;
        }

        /// <summary>
        /// Permet de vider tous les champs du formulaire d'ajout ou de modification
        /// </summary>
        private void videLesChamps()
        {
            txtbNom.Text = "";
            txtbPrenom.Text = "";
            txtbClasse.Text = "";
            txtbIdentifiant.Text = "";
            txtbMotDePasse.Text = "";
            txtbMotDePasseConfirmation.Text = "";
        }

        /// <summary>
        /// Création des tuples correspondant à un profil qui viens d'être créé
        /// </summary>
        private void creationTupleBdd()
        {   
            List<int> lstTousIdMots = controleur.recupereTousIdLesMots();
                        
            int plusGrandIdPatient = controleur.recuperePlusGrandIdPatient();

            for (int i = 0; i < lstTousIdMots.Count; i++)
            {
                controleur.creationAcquisition_leMot(plusGrandIdPatient, lstTousIdMots[i], 1);
            }            
        }

        /// <summary>
        /// Permet de fermer le panneau d'ajout ou de modification d'un patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pNouveauPatient.Visible = false;

            videLesChamps();
            lblMessage.Text = "";
            btnModifierPatient.Enabled = false;

            btnModifierPatient.BackColor = Color.FromArgb(172, 215, 227);
            btnAjouter.BackColor = Color.FromArgb(172, 215, 227);
        }

        /// <summary>
        /// Permet de vider le label de message lors de l'ajout d'une lettre dans le textBox accueillant 
        /// le nom du patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbNom_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMeessageSuppression.Text = "";
        }

        /// <summary>
        /// Permet de vider le label de message lors de l'ajout d'une lettre dans le textBox accueillant 
        /// le prénom du patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbPrenom_TextChanged(object sender, EventArgs e)
        {
           lblMessage.Text = "";
           lblMeessageSuppression.Text = "";
        }

        /// <summary>
        /// Permet de vider le label de message lors de l'ajout d'une lettre dans le textBox accueillant 
        /// la classe du patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbClasse_TextChanged(object sender, EventArgs e)
        {            
            lblMessage.Text = "";
            lblMeessageSuppression.Text = "";
        }

        /// <summary>
        /// Permet de vider le label de message lors de l'ajout d'une lettre dans le textBox accueillant 
        /// l'identifiant du patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbIdentifiant_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMeessageSuppression.Text = "";
        }

        /// <summary>
        /// Permet de vider le label de message lors de l'ajout d'une lettre dans le textBox accueillant 
        /// le mot de passe du patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbMotDePasse_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMeessageSuppression.Text = "";
        }

        /// <summary>
        /// Permet de vider le label de message lors de l'ajout d'une lettre dans le textBox accueillant 
        /// la confirmation du mot de passe du patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbMotDePasseConfirmation_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMeessageSuppression.Text = "";
        }

        //******************************
        //Gestion de l'ouverture du carnet de missions
        //*****************************

        /// <summary>
        /// Permet d'instancier la page contenant le carnet de mission d'un patient sélectionné dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarnetDeQuetes_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                pNouveauPatient.Visible = false;
                identifiantPatientEnCours = dgvPatients.CurrentRow.Cells["C_Identifiant"].Value.ToString();

                patientEnCours = controleur.recuperePatient(identifiantPatientEnCours);

                Vue_Gestion_Carnets_De_Quetes fenetre__Gestion_CarnetDeQuetes = new Vue_Gestion_Carnets_De_Quetes(patientEnCours.IdUtilisateur);
                fenetre__Gestion_CarnetDeQuetes.ShowDialog();
            }     
            else
            {
                lblMeessageSuppression.Text = "Veilliez à selectionner un patient dans la liste";
            }
        }

        /// <summary>
        /// Permet de supprimer un patient ainsi que toutes ses données de la base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                identifiantPatientEnCours = dgvPatients.CurrentRow.Cells["C_Identifiant"].Value.ToString();
                patientEnCours = controleur.recuperePatient(identifiantPatientEnCours);

                bool bSupprimerSesAcquisitions = controleur.supprimeAcquisitionLeMot(patientEnCours.IdUtilisateur);

                bool bSupprimerMissions = controleur.supprimeMissionsCarnet(patientEnCours.IdUtilisateur);

                bool bSupprimeSesSeries = controleur.SupprimeSesSeries(patientEnCours);

                bool bSupprimeUtilisateur = controleur.SupprimeUtilisateur(patientEnCours.IdUtilisateur);

                if(bSupprimerSesAcquisitions && bSupprimerMissions && bSupprimeSesSeries && bSupprimeUtilisateur)
                {
                    Log.Information("l'utilisateur " + utilisateurAModifier.Identifiant + " a bien été supprimé");

                    lblMeessageSuppression.Text = "L'utilisateur a été supprimé";
                    actualiseDgvPatient();
                    pNouveauPatient.Visible = false;                   
                }
                else
                {
                    lblMeessageSuppression.Text = "L'utilisateur n'a pas pus être supprimé";
                    Log.Error("l'utilisateur " + utilisateurAModifier.Identifiant + " n a pas été supprimé");
                }                
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Gestion des jeux - tabPage 3
        //////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet d'instancier la fenêtre permettant la gestion des questions du "Jeu du Mot"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestion_JeuDuMot_Click(object sender, EventArgs e)
        {
            lblMeessageSuppression.Text = "";

            Vue_Gestionnaire_JeuLeMot fenetre_Gestionnaire_JeuDuMot = new Vue_Gestionnaire_JeuLeMot();
            fenetre_Gestionnaire_JeuDuMot.ShowDialog();
            
        }

        
    }
}