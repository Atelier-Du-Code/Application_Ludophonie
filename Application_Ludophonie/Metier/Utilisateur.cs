using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
	/// <summary>
	/// Classe de définition de l'utilisateur
	/// </summary>
	public class Utilisateur
	{
		/// <summary>
		/// Constructeur de la classe Utilisateur 
		/// </summary>
		/// <param name="idUtilisateur"></param>
		/// <param name="type_utilisateur"></param>
		/// <param name="identifiant"></param>
		/// <param name="nom"></param>
		/// <param name="prenom"></param>
		/// <param name="classe"></param>
		/// <param name="password"></param>
		/// <param name="urlAvatar"></param>
        public Utilisateur(int idUtilisateur, string type_utilisateur, string identifiant, string nom, string prenom, string classe, string password, string urlAvatar, int score_global, string grade)
		{
			this.IdUtilisateur = idUtilisateur;
			this.Type_Utilisateur = type_utilisateur;
			this.Identifiant = identifiant;
			this.Nom = nom;
			this.Prenom = prenom;
			this.Classe = classe;
			this.Password = password;
			this.UrlAvatar = urlAvatar;
			this.Score_Global = score_global;
			this.Grade = grade;
			
		}

		/// <summary>
		/// Porte le numéro d'identifiant d'un utilisateur
		/// </summary>
        public int IdUtilisateur { get; set; }

		/// <summary>
		/// Porte le type de l'utilisateur (patient ou praticien)
		/// </summary>
		public string Type_Utilisateur { get; set; }

		/// <summary>
		/// Porte l'identifiant de connexion de l'utilisateur 
		/// </summary>
		public string Identifiant { get; set; }

		/// <summary>
		/// Porte le nom de l'utilisateur 
		/// </summary>
		public string Nom { get; set; }

		/// <summary>
		/// Porte le prénom de l'utilisateur 
		/// </summary>
		public string Prenom { get; set; }

		/// <summary>
		/// Porte la classe de l'utilisateur 
		/// </summary>
		public string Classe { get; set; }

		/// <summary>
		/// Porte le mot de passe de l'utilisateur 
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Porte l'url de localisation de l'avatar de l'utilisateur 
		/// </summary>
		public string UrlAvatar { get; set; }

		/// <summary>
		/// Porte la date d'inscription de l'utilisateur 
		/// </summary>
		public DateTime DateInscription { get; set; }

		public int Score_Global { get; set; }

		public string Grade { get; set; }
	}
}

/*

grade.libelle_grade,grade_utilisateur.scoreUtilisateur

req += "INNER JOIN grade_utilisateur ON grade_utilisateur.idUtilisateur = utilisateurs.idUtilisateur ";
req += "INNER JOIN grade ON grade.idGrade = grade_utilisateur.idGrade ";

int score_global = ((int)curs.Field("scoreUtilisateur"));
string grade = ((string)curs.Field("grade"));

score_global, grade

*/