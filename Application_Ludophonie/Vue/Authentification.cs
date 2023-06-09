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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie
{
    public partial class Authentification : Form
    {
        Controleur_Authentification controleur = new Controleur_Authentification();

        //A décommenter si BDD connectée
        //Utilisateur utilisateurAIdentifier = new Utilisateur(0, null, null, null, null, null, null, null, null);

        //A décommenter si BDD non connectée       
        Utilisateur utilisateurAIdentifier = new Utilisateur(1, "praticien","Jade_Vidal", "Vidal", "Jade", "CE2","5w+rcRi29F6*H", "https://i.pinimg.com/564x/8f/cc/6e/8fcc6e362c58546f130310c97ad0df39.jpg");

        public Authentification()
        {
            InitializeComponent();
            lblMessage.Text = "";
        }        

        private void btnValider_Click(object sender, EventArgs e)
        {
            //A décommenter si BDD connectée
            //utilisateurAIdentifier = controleur.controleIdentite(txtbIdentifiant.Text);

            lblMessage.Text = utilisateurAIdentifier.Identifiant;

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
            if(txtbMotDePasse.Text != utilisateurAIdentifier.Password)
            {
                lblMessageMDP.Text = "Votre mot de passe est incorrect";
            }
            else
            {
                if(utilisateurAIdentifier.Type_Utilisateur == "patient")
                {
                    Vue_MenuPrincipal_Patient fenetre_MenuPrincipal_Patient = new Vue_MenuPrincipal_Patient();
                    fenetre_MenuPrincipal_Patient.Show();
                    txtbMotDePasse.Text = "";
                    //Close();
                }
                else
                {
                    if(utilisateurAIdentifier.Type_Utilisateur == "praticien")
                    {
                        Vue_MenuPrincipal_Praticien fenetre_MenuPrincipal_Praticien = new Vue_MenuPrincipal_Praticien();
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
