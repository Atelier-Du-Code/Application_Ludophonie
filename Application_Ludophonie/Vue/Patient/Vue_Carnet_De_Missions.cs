using Application_Ludophonie.Controleur.Patient;
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

namespace Application_Ludophonie.Vue.Patient
{
    /// <summary>
    /// Vue - Carnet de missions - Côté patient
    /// </summary>
    public partial class Vue_Carnet_De_Missions : Form
    {
        Controleur_Carnet_De_Quetes controleur = new Controleur_Carnet_De_Quetes();

        int idUtilisateur;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idUtilisateur"></param>
        public Vue_Carnet_De_Missions(int idUtilisateur)
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
            List<Mission> lstMissions = new List<Mission>();

            lstMissions.Clear();
            ckLstbMissions.Items.Clear();

            lstMissions = controleur.recupereToutesMissions(idUtilisateur);

            for(int i=0; i<lstMissions.Count; i++)
            {
                ckLstbMissions.Items.Add("Série de " + lstMissions[i].NbQuestions + " questions du " + lstMissions[i].Jeu);

                if (lstMissions[i].MissionValide == 1)
                {
                    ckLstbMissions.SetItemChecked(i, true);
                }
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
