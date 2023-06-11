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

        

        public Authentification()
        {
            InitializeComponent();
            lblMessage.Text = "";
            
        }        

        private void btnValider_Click(object sender, EventArgs e)
        {
            //A décommenter si BDD connectée
            utilisateurAIdentifier = controleur.controleIdentite(txtbIdentifiant.Text);

            

            if(txtbIdentifiant.Text != "")
            {
                if (utilisateurAIdentifier.Identifiant == txtbIdentifiant.Text)
                {
                    pIdentifiant.Visible = false;

                    lblBienvenue.Text = "Bienvenue " + utilisateurAIdentifier.Prenom;
                    pbxAvatarIdentifie.ImageLocation = utilisateurAIdentifier.urlAvatar;
                }
                else
                {
                    lblMessage.Text = "Cet identifiant est incorrecte";
                }
            }
            else
            {
                lblMessage.Text = "Veuilliez renseigner un identifiant";
            }
            
        }

        private void txtbIdentifiant_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string motDePasseHash = HashMotDePasse_Singleton.GetInstance().HashMotDePasse(txtbMotDePasse.Text);

            //string motDePasseSaisi = DistributionSecurite.Instance.HashMotDePasse_Singleton.HashDeMotDePasse(txtbMotDePasse.Text);

            if (motDePasseHash.Equals(utilisateurAIdentifier.Password))
            {

                if (utilisateurAIdentifier.Type_Utilisateur == "patient")
                {
                    Vue_MenuPrincipal_Patient fenetre_MenuPrincipal_Patient = new Vue_MenuPrincipal_Patient(utilisateurAIdentifier);
                    fenetre_MenuPrincipal_Patient.Show();
                    txtbMotDePasse.Text = "";
                    //Close();
                }
                else
                {
                    if (utilisateurAIdentifier.Type_Utilisateur == "praticien")
                    {
                        Vue_MenuPrincipal_Praticien fenetre_MenuPrincipal_Praticien = new Vue_MenuPrincipal_Praticien(utilisateurAIdentifier);
                        fenetre_MenuPrincipal_Praticien.Show();
                        txtbMotDePasse.Text = "";
                        //Close();
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

        private string hashMotDePasse(string motDePasse)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasse));

                //Permet de concaténer des chaine et des valeurs de variables
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    sb.Append(hashedBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        private void txtbMotDePasse_TextChanged(object sender, EventArgs e)
        {
            lblMessageMDP.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
