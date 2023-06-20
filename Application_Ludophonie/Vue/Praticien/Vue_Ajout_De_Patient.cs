using Application_Ludophonie.Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie.Vue.Praticien
{
    /// <summary>
    /// Vue - Page d'ajout de patient - Côté praticien
    /// </summary>
    public partial class Vue_Ajout_De_Patient : Form
    {
        /// <summary>
        /// Initialise le nouveau patient créé dans le menu principal praticien
        /// </summary>
        public Utilisateur utilisateurAAjouter = null;

        private List<Utilisateur> lstPatients = new List<Utilisateur>();
        private Utilisateur utilisateurEnCours = null;
        private bool bInfosIdentifiant;
        private bool bInfosMotDePasse;

        /// <summary>
        /// Constructeur de la classe : Vue_Ajout_De_Patient
        /// </summary>
        /// <param name="lstPatients"></param>
        /// <param name="utilisateurEnCours"></param>
        public Vue_Ajout_De_Patient(List<Utilisateur> lstPatients, Utilisateur utilisateurEnCours)
        {
            InitializeComponent();

            this.lstPatients = lstPatients;
            this.utilisateurEnCours = utilisateurEnCours;
        }

        /// <summary>
        /// Méthode d'initialisation de l'interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vue_Ajout_De_Patient_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            txtbNom.Focus();
            AcceptButton = btnEnregistrer;
            txtbMotDePasse.UseSystemPasswordChar = false;
            txtbMotDePasseConfirmation.UseSystemPasswordChar = false;
        }

        /// <summary>
        /// Permet de vérifier si un identifiant n'est pas déjà inscrit dans la base
        /// </summary>
        /// <returns></returns>
        private bool verifieIdentifiant()
        {
            if(lstPatients.Count == 0)
            {
                bInfosIdentifiant = true;
            }
            else
            {
                for (int i = 0; i < lstPatients.Count; i++)
                {
                    if (lstPatients[i].Identifiant == txtbIdentifiant.Text)
                    {
                        bInfosIdentifiant = false;
                        break;
                    }
                    else
                    {
                        bInfosIdentifiant = true;
                    }
                }
            }
            

            return bInfosIdentifiant;
        }

        /// <summary>
        /// Permet de vérifier la colposition des mots de passe enregistrés
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
        /// Méthode évènementielle permettant la construction d'un nouveau patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (txtbNom.Text == "" || txtbPrenom.Text == "" || txtbClasse.Text == "" || txtbIdentifiant.Text == "" || txtbMotDePasse.Text == "" || txtbMotDePasseConfirmation.Text == "")
            {
                lblMessage.Text = "Un des champs est vide";
            }
            else
            {               

                if (verifieIdentifiant())
                {
                    if (txtbMotDePasse.Text != txtbMotDePasseConfirmation.Text)
                    {
                        lblMessage.Text = "Mot de passe différents";
                    }
                    else
                    {
                        verifieMotDePasse();

                        if (verifieMotDePasse())
                        {
                            string identifiant = txtbIdentifiant.Text;
                            string nom = txtbNom.Text;
                            string prenom = txtbPrenom.Text;
                            string classe = txtbClasse.Text;
                            string password = txtbMotDePasse.Text;

                            utilisateurAAjouter = new Utilisateur(0, "patient", identifiant, nom, prenom, classe, password, null);

                            Close();
                        }
                        else
                        {
                            lblMessage.Text = "Le mot de passe doit contenir au moins 12 caractères dont une majuscule, " +
                                   "une minusucle, un chiffre et un caractère spécial autorisé(@#$%^&*+$)";
                        }

                    }
                }
                else
                {
                    lblMessage.Text = "Identifiant non disponible";                    
                }

            }
        }

        private void txtbMotDePasseConfirmation_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbMotDePasse_TextChanged(object sender, EventArgs e)
       {
            lblMessage.Text = "";
        }
        private void txtbClasse_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbPrenom_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbNom_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtbIdentifiant_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        
    }
}
