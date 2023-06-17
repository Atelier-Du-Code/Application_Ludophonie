using Application_Ludophonie.Controleur.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie.Vue.Patient
{
    public partial class Vue_Carnet_De_Quetes : Form
    {
        Controleur_Carnet_De_Quetes controleur = new Controleur_Carnet_De_Quetes();

        int idUtilisateur;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idUtilisateur"></param>
        public Vue_Carnet_De_Quetes(int idUtilisateur)
        {
            InitializeComponent();

            this.idUtilisateur = idUtilisateur;
            rempliLstb();
        }

        /// <summary>
        /// Permet de récupérer toutes les missions du patient en cours
        /// </summary>
        public void rempliLstb()
        {
            List<string> lstMissions = new List<string>();

            lstMissions.Clear();
            lstbMissions.Items.Clear();

            lstMissions = controleur.recupereLstMissions(idUtilisateur);

            for(int i=0; i<lstMissions.Count; i++)
            {
                lstbMissions.Items.Add(lstMissions[i]);
            }
        }

        /// <summary>
        /// Permet de fermer le carnet de quête
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJeuDuMot_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
