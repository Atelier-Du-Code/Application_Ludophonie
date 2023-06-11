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

namespace Application_Ludophonie.Vue.Praticien.Gestion_des_jeux
{
    public partial class Vue_Gestionnaire_JeuLeMot : Form
    {
        Controleur_Gestion_JeuDuMot controleur = new Controleur_Gestion_JeuDuMot();

        public Vue_Gestionnaire_JeuLeMot()
        {
            InitializeComponent();

            actualiseDgvLstMots();
            rempliCbx();
        }

        private void rempliCbx()
        {
            List<string> lstTouteslistes = new List<string>();
            lstTouteslistes = controleur.recupereToutesListes();

            for(int i = 0; i < lstTouteslistes.Count; i++)
            {
                cbxTriListes.Items.Add(lstTouteslistes[i]);
                cbxTypeListe.Items.Add(lstTouteslistes[i]);
            }
        }

        private void actualiseDgvLstMots()
        {
            dgvLstMots.Rows.Clear();

            List<Mot> lstTousLesMots = new List<Mot>();

            lstTousLesMots.Clear();
            lstTousLesMots = controleur.recupereTousLesMots();

            for (int i = 0; i < lstTousLesMots.Count; i++)
            {
                dgvLstMots.Rows.Add(lstTousLesMots[i].LeMot, lstTousLesMots[i].Contexte, lstTousLesMots[i].Liste);
            }
        }

        private void cbxTriListes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string liste = cbxTriListes.SelectedItem.ToString();          

            actualiseDgvParListe(liste);
        }

        private void actualiseDgvParListe(string liste)
        {
            dgvLstMots.Rows.Clear();

            List<Mot> lstTousLesMotsListe = new List<Mot>();

            lstTousLesMotsListe.Clear();
            lstTousLesMotsListe = controleur.recupereTousLesMotsDelaListe(liste);

            for (int i = 0; i < lstTousLesMotsListe.Count; i++)
            {
                dgvLstMots.Rows.Add(lstTousLesMotsListe[i].LeMot, lstTousLesMotsListe[i].Contexte, lstTousLesMotsListe[i].Liste);
            }
        }

        

        void btnSupprimer_Click(object sender, EventArgs e)
        {
            string motAsupprimer = "";

            if (dgvLstMots.SelectedRows.Count == 1)
            {
                motAsupprimer = dgvLstMots.CurrentRow.Cells["C_Mot"].Value.ToString();

                bool bSupprimer = controleur.supprimeUnMot(motAsupprimer);

                if (bSupprimer == true)
                {
                    lblMessage.Text = "Le mot a bien été supprimé";
                    txtbMot.Text = "";
                    txtbContexte.Text = "";
                    cbxTypeListe.SelectedIndex = 0;

                    actualiseDgvLstMots();
                    
                    //mettre a jour le dgv 
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

        private void btnEnregistrerNewMot_Click(object sender, EventArgs e)
        {
            string liste = "";

            if (txtbMot.Text != "" && txtbContexte.Text != "" && cbxTypeListe.SelectedItem.ToString() != "")
            {
                liste = cbxTypeListe.SelectedItem.ToString();

                bool bEnregistrer = controleur.enregistreUnMot(txtbMot.Text, txtbContexte.Text, cbxTypeListe.SelectedIndex + 1);

                if (bEnregistrer == true)
                {
                    lblMessage.Text = "Le mot a bien été ajouté";
                    txtbMot.Text = "";
                    txtbContexte.Text = "";
                    cbxTypeListe.SelectedIndex = 0;
                    actualiseDgvParListe(liste);
                    
                }
                else
                {
                    lblMessage.Text = "Le mot n'a pas pus etre ajouté";
                }
            }
            else
            {
                lblMessage.Text = "Au moins un champs du formulaire est vide";
            }

        }
    }
}
