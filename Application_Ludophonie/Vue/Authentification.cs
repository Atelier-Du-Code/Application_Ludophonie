using Application_Ludophonie.Controleur;
using Application_Ludophonie.Metier;
using Application_Ludophonie.Vue.Patient;
using Application_Ludophonie.Vue.Praticien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie
{
    public partial class Authentification : Form
    {
        Controleur_Authentification controleur = new Controleur_Authentification();
        
        Utilisateur utilisateurAIdentifier = new Utilisateur(0, null, null, null, null, null, null, null);
        
        /// <summary>
        /// Constructeur
        /// </summary>
        public Authentification()
        {
            InitializeComponent();
            lblMessage.Text = "";
            lblMessageMDP.Text = "";

            txtbIdentifiant.Focus();
            AcceptButton = btnValider;
        }        
        /// <summary>
        /// Permet de vérifier si un utilisateur existe vraiment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {

            if (txtbIdentifiant.Text != "")
            {
                bool bExiste = controleur.utilisateurExiste(txtbIdentifiant.Text);

                if (bExiste)
                {
                    utilisateurAIdentifier = controleur.recupereUtilisateur(txtbIdentifiant.Text);

                    pIdentifiant.Visible = false;

                    txtbMotDePasse.Focus();
                    AcceptButton = btnConnexion;

                    lblBienvenue.Text = "Bienvenue " + utilisateurAIdentifier.Prenom;
                    pbxAvatarIdentifie.ImageLocation = utilisateurAIdentifier.urlAvatar;
                }
                else
                {
                    lblMessage.Text = "Cet identifiant est incorrect";
                }
            }
            else
            {
                lblMessage.Text = "Veillez à entrer un identifiant";
            }
        }

        /// <summary>
        /// Permet de vider le label de message d'erreur au niveau de l'identifiant
        /// lorsqu'une nouvelle lettre est tapée dans le textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbIdentifiant_TextChanged(object sender, EventArgs e)
        {           
            lblMessage.Text = "";
        }

        /// <summary>
        /// Permet de vérifier si le mot de passe enté par un utilisateur reconnu est correcte
        /// Gère l'aiguillage de l'utilisateur connecté.
        /// Soit vers l'espace "patient".
        /// Soit vers l'espace "praticien"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {           

            if (txtbMotDePasse.Text == utilisateurAIdentifier.Password)
            {
                txtbIdentifiant.Text = "";
                txtbMotDePasse.Text = "";

                if (utilisateurAIdentifier.Type_Utilisateur == "patient")
                {
                    Vue_MenuPrincipal_Patient fenetre_MenuPrincipal_Patient = new Vue_MenuPrincipal_Patient(utilisateurAIdentifier);
                    fenetre_MenuPrincipal_Patient.Show();                  
                    
                }
                else
                {
                    if (utilisateurAIdentifier.Type_Utilisateur == "praticien")
                    {
                        Vue_MenuPrincipal_Praticien fenetre_MenuPrincipal_Praticien = new Vue_MenuPrincipal_Praticien(utilisateurAIdentifier);
                        fenetre_MenuPrincipal_Praticien.Show();                       
                    }
                    else
                    {
                        lblMessageMDP.Text = "Vous n'êtes pas autorisé à utiliser cette application";
                    }
                }
                
            }
            else
            {
                lblMessageMDP.Text = "Votre mot de passe est incorrect";
            }
        }

        /// <summary>
        /// Permet de vider le label de message d'erreur au niveau du mot de passe 
        /// lorsqu'une nouvelle lettre est tapée dans le textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbMotDePasse_TextChanged(object sender, EventArgs e)
        {
            lblMessageMDP.Text = "";
        }

        /// <summary>
        /// Permet de quitter complètement le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Permet le switch entre le panneau de reconnaissance de l'identifiant et du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetourPanel_Click(object sender, EventArgs e)
        {
            pIdentifiant.Visible = true;

            txtbIdentifiant.Text = "";
            txtbMotDePasse.Text = "";

            AcceptButton = btnValider;
        }
    }
}
