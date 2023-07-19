
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppOrthophonie.BDD
{
    /// <summary>
    /// Classe publique BddMySql
    /// </summary>
    public class BddMySql
    {
        private static string server;
        private static string userid;
        private static string password;
        private static string database;

        private static readonly string emplacementBDD = "local";
        

        /// <summary>
        /// Unique instance de la classe
        /// </summary>
        private static BddMySql instance = null;

        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private MySqlConnection connection;

        /// <summary>
        /// objet contenant le résultat d'une requête "select" (curseur)
        /// </summary>
        private MySqlDataReader reader;

        /// <summary>
        /// Constructeur privé pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        private BddMySql(string stringConnect)
        {
            try
            {
                connection = new MySqlConnection(chaineDeConnexion());

                //Gestion du temps avant la fermeture de la connexion
                MySqlConnectionStringBuilder constucteurDeConnexion = new MySqlConnectionStringBuilder();
                constucteurDeConnexion.ConnectionTimeout = 1000;

                connection.Open();
            }
            catch (MySqlException ex)
            {
                ErreurGraveBddNonAccessible(ex);
            }
        }

        /// <summary>
        /// Configure la chaine de connexion avec un paramétrage de l'emplacemetn de la base de données : local ou distant
        /// </summary>
        /// <param name="emplacementBDD"></param>
        /// <returns></returns>
        private static string chaineDeConnexion()
        {
            string chaineDeConnexion = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";


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


                //server = 154.49.245.52; user id = u607780247_testLudo; database = u607780247_testLudo; persistsecurityinfo = True
            }

            return chaineDeConnexion;
        }
        /// <summary>
        /// Crée une instance unique de la classe
        /// </summary>
        /// <param name="">chaine de connexion</param>
        /// <returns>instance unique de la classe</returns>
        public static BddMySql GetInstance()
        {
            if (instance is null)
            {
                instance = new BddMySql(chaineDeConnexion());               
            }
            return instance;
        }

        /// <summary>
        /// Exécute une requête type "select" et valorise le curseur
        /// </summary>
        /// <param name="stringQuery"></param>
        /// <param name="parameters"></param>
        public void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            MySqlCommand command;
            
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                command.CommandTimeout = 1000;
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                ErreurGraveBddNonAccessible(e);
            }
        }

        /// <summary>
        /// Tente de lire la ligne suivante du curseur
        /// </summary>
        /// <returns>false si fin de curseur atteinte</returns>
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Retourne le contenu d'un champ dont le nom est passé en paramètre
        /// </summary>
        /// <param name="nameField">nom du champ</param>
        /// <returns>valeur du champ</returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Exécution d'une requête autre que "select"
        /// </summary>
        /// <param name="stringQuery">requête autre que select</param>
        /// <param name="parameters">dictionnire contenant les parametres</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            MySqlCommand command;
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                command.CommandTimeout = 3000;

                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (InvalidOperationException e)
            {
                ErreurGraveBddNonAccessible(e);
            }
        }

        /// <summary>
        /// Exécution d'une requête de type LCT (begin transaction)
        /// </summary>
        /// <param name="stringQuery"></param>
        public void ReqControle(string stringQuery)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            command.CommandTimeout = 1000;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Fermeture du curseur
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
                connection.Close();
                instance = null;
            }
        }

        /// <summary>
        /// Pas d'accès à la BDD : arrêt de l'application
        /// </summary>
        private void ErreurGraveBddNonAccessible(Exception ex)
        {
            //MessageBox.Show("Base de données non accessibles", "Erreur grave");
            MessageBox.Show("Erreur MySQL : " + ex.Message);
            MessageBox.Show("Code d'erreur MySQL : " + ex.Source);
           // MessageBox.Show(ex.Message);
            Environment.Exit(1);
        }
    }
}