using Application_Ludophonie.Controleur.Jeux;
using Application_Ludophonie.Metier;
using SpeechLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = Application_Ludophonie.Metier.Image;

namespace Application_Ludophonie.Vue.Jeux
{
    public partial class Vue_Jeu_DuMot : Form
    {
        //Gestion de la configuration de la partie
        private Utilisateur utilisateur;
        private string liste;
        private int nbQuestionsSerie;

        //Gestion du chronometre
        private Chrono chronometre = new Chrono();
        private DateTime temps;
        private DateTime tempsNull;
        private int passage = 0;

        //Gestion et affichage des étoiles
        private List<Image> listeDesEtoiles;
        private string etoileJaune;
        private string etoileNoire;
        private PictureBox boiteAImage;
        private List<PictureBox> lstImagesEtoiles;

        //Gestion des mots
        private Controleur_JeuDuMot controleur = new Controleur_JeuDuMot();

        //Création d'un série
        private MelangeurDeListe melangeur = new MelangeurDeListe();

        private List<Mot> lstMotsNonEvalue = new List<Mot>();
        private List<Mot> lstMotsEchec = new List<Mot>();
        private List<Mot> lstMotsUneRepCorrecte = new List<Mot>();
        private List<Mot> lstMotsDeuxRepCorrectes = new List<Mot>();
        private List<Mot> lstMotsAquis = new List<Mot>();

        private List<Mot> lstMotsNonEvalue_Melangee = new List<Mot>();
        private List<Mot> lstMotsEchec_Melangee = new List<Mot>();
        private List<Mot> lstMotsUneRepCorrecte_Melangee = new List<Mot>();
        private List<Mot> lstMotsDeuxRepCorrectes_Melangee = new List<Mot>();
        private List<Mot> lstMotsAquis_Melangee = new List<Mot>();

        private List<Mot> lstMotsDeLaSerie = new List<Mot>();

        // Objets pour la synthèse vocale
        private SpVoice voix = new SpVoice();
        private SpeechVoiceSpeakFlags flags = SpeechVoiceSpeakFlags.SVSFlagsAsync;

        // Objets de gestion du son
        private SonSysteme son = new SonSysteme();


        //Gestion de la partie
        private int score = 0;
        private int motEnCours = 0;
        private int tentative = 0;
        private int erreur = 0;

        //Gestion de la mise à jour de la base de données 
        private List<Mot> lstMotsUpdate = new List<Mot>();

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="liste"></param>
        /// <param name="nbQuestions"></param>
        public Vue_Jeu_DuMot(Utilisateur utilisateur, string liste, int nbQuestions)
        {
            InitializeComponent();

            this.utilisateur = utilisateur;
            this.liste = liste;
            this.nbQuestionsSerie = nbQuestions;

            pSerieFinie.Visible = false;
            lblScore.Text = score + " / " + nbQuestionsSerie;
            initialiseLesEtoiles(nbQuestionsSerie);

            initialisationDesListes(liste, utilisateur.IdUtilisateur);
            creationDeLaListeDeMotsDeLaSerie();

            lblMinutes.Text = "00";
            lblSecondes.Text = "00";

            AcceptButton = btnEcouter;

        }

        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Gestion du panneau des étoiles
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Gestion de la création du panneau des étoiles
        /// </summary>
        private void initialiseLesEtoiles(int nbQuestionsSerie)
        {
            listeDesEtoiles = new List<Image>();
            listeDesEtoiles = controleur.recupereToutesImagesInterface();

            etoileNoire = listeDesEtoiles[0].Url;
            etoileJaune = listeDesEtoiles[1].Url;
           
            lstImagesEtoiles = new List<PictureBox>();

            if (nbQuestionsSerie < 10)
            {
                //On crée toutes les images pour les nombres des questions par série en dessous de 10

                flpDesEtoiles.Width = 114;

                for (int k = 0; k < nbQuestionsSerie; k++)
                {
                    boiteAImage = new PictureBox();
                    lstImagesEtoiles.Add(boiteAImage);
                    flpDesEtoiles.Controls.Add(boiteAImage);                    
                    
                    boiteAImage.Size = new Size(70, 70);
                    boiteAImage.SizeMode = PictureBoxSizeMode.Zoom;
                    boiteAImage.BackColor = Color.Transparent;
                    
                    boiteAImage.ImageLocation = etoileNoire;
                    
                }
            }
            else
            {
                if (nbQuestionsSerie == 10)
                {
                    //On crée toutes les images pour les nombres des questions par série égal à 10

                    flpDesEtoiles.Width = 140;

                    for (int k = 0; k < nbQuestionsSerie; k++)
                    {
                        boiteAImage = new PictureBox();
                        lstImagesEtoiles.Add(boiteAImage);
                        flpDesEtoiles.Controls.Add(boiteAImage);

                        
                        boiteAImage.Size = new Size(70, 70);
                        boiteAImage.SizeMode = PictureBoxSizeMode.Zoom;
                        boiteAImage.BackColor = Color.Transparent;
                        boiteAImage.ImageLocation = etoileNoire;                        
                    }

                }
                else
                {
                    if (nbQuestionsSerie > 10)
                    {
                        //On crée toutes les images pour les nombres des questions par série au dessus de 10

                        flpDesEtoiles.Width = 240; 

                        for (int k = 0; k < nbQuestionsSerie; k++)
                        {
                            boiteAImage = new PictureBox();
                            lstImagesEtoiles.Add(boiteAImage);
                            flpDesEtoiles.Controls.Add(boiteAImage);

                            
                            boiteAImage.Size = new Size(70, 70);
                            boiteAImage.SizeMode = PictureBoxSizeMode.Zoom;
                            boiteAImage.BackColor = Color.Transparent;
                            boiteAImage.ImageLocation = etoileNoire;                            
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Gestion du changement de couleur des étoiles en fonction du score
        /// </summary>
        private void passeLesEtoilesEnJaune()
        {
            if (score > 0)
            {
                for (int i = 0; i < score; i++)
                {
                    lstImagesEtoiles[i].ImageLocation = etoileJaune;
                }
            }
        }

        /// <summary>
        /// Gestion du changement de la couleur des étoiles lors d'un échec
        /// </summary>
        private void passeToutesLesEtoilesEnNoir()
        {
            for (int i = 0; i < nbQuestionsSerie; i++)
            {
                lstImagesEtoiles[i].ImageLocation = etoileNoire;
            }
        }

        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Création de la liste des mots de la partie
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Récupération des mots suivant leur liste et leur niveau d'acquisition du patient en cours
        /// </summary>
        /// <param name="listeChoisie"></param>
        /// <param name="idUtilisateur"></param>
        private void initialisationDesListes(string listeChoisie, int idUtilisateur)
        {
            lstMotsNonEvalue = new List<Mot>();
            lstMotsNonEvalue = controleur.recupereMotsParListeNiveauAcquisitionIdUtilisateur(liste, 1, idUtilisateur);

            lstMotsEchec = new List<Mot>();
            lstMotsEchec = controleur.recupereMotsParListeNiveauAcquisitionIdUtilisateur(liste, 2, idUtilisateur);

            lstMotsUneRepCorrecte = new List<Mot>();
            lstMotsUneRepCorrecte = controleur.recupereMotsParListeNiveauAcquisitionIdUtilisateur(liste, 3, idUtilisateur);

            lstMotsDeuxRepCorrectes = new List<Mot>();
            lstMotsDeuxRepCorrectes = controleur.recupereMotsParListeNiveauAcquisitionIdUtilisateur(liste, 4, idUtilisateur);

            lstMotsAquis = new List<Mot>();
            lstMotsAquis = controleur.recupereMotsParListeNiveauAcquisitionIdUtilisateur(liste,5, idUtilisateur);

        }

        /// <summary>
        /// Permet de créer la liste de mot de la série
        /// </summary>
        private void creationDeLaListeDeMotsDeLaSerie()
        {
            lstMotsDeLaSerie = melangeur.concateneListe(lstMotsNonEvalue, lstMotsEchec, lstMotsUneRepCorrecte, lstMotsDeuxRepCorrectes, lstMotsAquis);
            lstMotsUpdate = lstMotsDeLaSerie;
        }


        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Gestion du chronomètre
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Permet d'incrémenter le chronometre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chrono_Tick(object sender, EventArgs e)
        {
            temps = new DateTime(1, 1, 1, 0, 0, 0);

            temps = chronometre.mecaniqueChrono();
            
            lblMinutes.Text = temps.Minute.ToString();
            lblSecondes.Text = temps.Second.ToString();          
        }

        /// <summary>
        /// Permet d'arreter le chronomètre 
        /// </summary>
        private void ChronoStop()
        {
            chrono.Stop();

            tempsNull = new DateTime(1, 1, 1, 0, 0, 0);
            temps = tempsNull;

            lblMinutes.Text = "0";
            lblSecondes.Text = "0";

            chronometre.secondes = 0;
            chronometre.minutes = 0;
            chronometre.heures = 0;

        }


        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Déroulement de la partie
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
       
        /// <summary>
        /// Permet d'écouter une nouvelle fois le mot en cours
        /// Au premier clic, démarrer le chronomètre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEcouter_Click(object sender, EventArgs e)
        {
            btnValiderReponse.Enabled = true;
            txtbReponse.Enabled = true;
            txtbReponse.Focus();
            lblVerdict.Text = "";
            AcceptButton = btnValiderReponse;

            voix.Speak(lstMotsDeLaSerie[motEnCours].LeMot, flags);
            voix.Speak(lstMotsDeLaSerie[motEnCours].Contexte, flags);

            //Démarage du chrono
            if (passage == 0)
            {
                chrono.Start();
                passage++;
            }
        }

        /// <summary>
        /// Permet de valider une réponse, 
        /// gérer le niveau d'acquisition du mot qui vient d'être validé suivant si il est vrai ou faux 
        /// gérer la fin de la série
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderReponse_Click(object sender, EventArgs e)
        {
            txtbReponse.Enabled = false;
            AcceptButton = btnEcouter;


            if (score < nbQuestionsSerie)
            {
                //La réponse est juste
                if (txtbReponse.Text == lstMotsDeLaSerie[motEnCours].LeMot)
                {
                    // Le joueur a donné la bonne réponse au premier essai
                    if (tentative == 0)
                    {
                        score++;


                        if (lstMotsUpdate[motEnCours].Acquisition != 5)
                        {
                            if (lstMotsUpdate[motEnCours].Acquisition == 1)
                            {
                                lstMotsUpdate[motEnCours].Acquisition = 3;
                            }
                            else
                            {
                                if (lstMotsUpdate[motEnCours].Acquisition == 3)
                                {
                                    lstMotsUpdate[motEnCours].Acquisition = 4;
                                }
                                else
                                {
                                    if (lstMotsUpdate[motEnCours].Acquisition == 4)
                                    {
                                        lstMotsUpdate[motEnCours].Acquisition = 5;
                                    }
                                    else
                                    {
                                        if (lstMotsUpdate[motEnCours].Acquisition == 2)
                                        {
                                            lstMotsUpdate[motEnCours].Acquisition = 3;
                                        }
                                    }
                                }
                                    
                            }
                        }
                        else
                        {
                            lstMotsUpdate[motEnCours].Liste = "Acquis";                            
                        }

                        motEnCours++;
                    }
                    else // Le joueur a donné la bonne réponse au deuxième essai
                    {
                        score++;
                        motEnCours++;
                        tentative = 0;

                    }

                    //Interface
                    lblMessage.Visible = false;
                    btnValiderReponse.Enabled = false;

                    txtbReponse.Text = "";

                    //Vérification si c'est la fin de la partie
                    if (score == nbQuestionsSerie)
                    {
                        chrono.Stop();

                        pSerieFinie.Visible = true;

                        lblErreur.Text = erreur.ToString();
                        lblMinureFin.Text = temps.Minute.ToString();
                        lblSecondesFIn.Text = temps.Second.ToString();

                        passeLesEtoilesEnJaune();
                        son.finDeSerie();


                        btnValiderReponse.Enabled = false;
                        btnEcouter.Enabled = false;

                        txtbReponse.Enabled = false;
                        txtbReponse.Text = "";

                        btnNewSerie.Visible = true;                        
                        btnMenuPrincipal.Visible = true;

                        updateDeLaBaseAvecMotsDeLaSerie();
                        creeLaSerie(erreur, temps);
                    }
                    else
                    {
                        lblVerdict.Text = "Bravo ! C'est la bonne réponse !";
                        lblScore.Text = score + "/" + nbQuestionsSerie;

                        son.ReponseVraie();
                        passeLesEtoilesEnJaune();
                        btnEcouter.Focus();
                    }

                    passeLesEtoilesEnJaune();

                }
                //La réponse est fausse
                else
                {
                    // Le joueur n'a pas donné la bonne réponse

                    //Gestion de la mécanique de jeu

                    score = 0;
                    erreur++;
                    tentative++;
                    lstMotsUpdate[motEnCours].Acquisition = 2;

                    if (tentative > 2)
                    {
                        lblMessage.Visible = true;
                        lblMessage.Text = "La bonne réponse est : " + lstMotsDeLaSerie[motEnCours].LeMot;
                    }

                    //Interface
                    btnValiderReponse.Enabled = false;

                    txtbReponse.Text = "";
                    lblVerdict.Text = "Vas-y! Recommence!";
                    lblScore.Text = score + "/" + nbQuestionsSerie;

                    son.ReponseFausse();
                    passeToutesLesEtoilesEnNoir();
                    btnEcouter.Focus();
                }
            }
        }

        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Gestion de l'après jeu
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
              
        
        /// <summary>
        /// Permet de mettre à jour les niveaux d'acquisition des mots étudiés dans la série 
        /// </summary>
        private void updateDeLaBaseAvecMotsDeLaSerie()
        {
            for (int i = 0; i < lstMotsUpdate.Count; i++)
            {
                bool bUpdate = controleur.updateDeLaBaseAvecMotsDeLaSerie(utilisateur.IdUtilisateur, lstMotsUpdate[i].IdMot, lstMotsUpdate[i].Acquisition);
            }          
        }

        /// <summary>
        /// Permet de créer la série dans la base de données
        /// </summary>
        /// <param name="nbErreur"></param>
        /// <param name="temps"></param>
        private void creeLaSerie(int nbErreur, DateTime temps)
        {
            DateTime dateDuJour = DateTime.Today;
            bool bCreation = controleur.creationSerieEffectuees(utilisateur.IdUtilisateur, 1, nbQuestionsSerie, nbErreur, dateDuJour, temps);
        }

        /// <summary>
        /// Permet de faire apparaître le panneau de configuration de série pour en faire une nouvelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewSerie_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Permet d'accéder au menu principal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Permet d'accéder au menu principal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Permet d'interdire les caratères d'espacement dans la zone de réponse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbReponse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
