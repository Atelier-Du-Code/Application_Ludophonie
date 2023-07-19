using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Ludophonie.BDD
{
    class GestionBddMySQL
    {
        private MySqlConnection connexion;
        private MySqlCommand command;
        private MySqlDataReader reader;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Connexion à la base de données 
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private static string server;
        private static string userid;
        private static string password;
        private static string database;

        private static readonly string emplacementBDD = "distant";

        private string chaineDeConnexion = "server=" + server + ";user id = " + userid + "; password=" + password + ";database=" + database + ";SslMode=none";

        

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public GestionBddMySQL()
        {
            initialiseChaineDeConnexion();
            InitConnexion();
        }

        /// <summary>
        /// Initialise la chaine de connexion à la base de données
        /// </summary>
        /// <returns></returns>
        private static void initialiseChaineDeConnexion()
        {
            if (emplacementBDD == "local")
            {
                server = "127.0.0.1";
                userid = "root";
                password = "";
                database = "ludophonie";
            }
            else
            {
                server = "154.49.245.52";
                userid = "u607780247_testLudo";
                password = "gTyHI2QZez";
                database = "u607780247_testLudo";
            }
        }

        /// <summary>
        /// Initilisation de la connexion à la base de données
        /// </summary>
        private void InitConnexion()
        {
            try
            {
                connexion = new MySqlConnection(chaineDeConnexion);
                connexion.Open();
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);

               
            }
            
        }



    }
}
