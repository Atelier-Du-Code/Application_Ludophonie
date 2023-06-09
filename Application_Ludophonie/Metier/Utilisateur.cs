using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
	public class Utilisateur
	{

        public Utilisateur(int idUtilisateur, string type_utilisateur, string identifiant, string nom, string prenom, string classe, string password, string urlAvatar)
		{
			this.IdUtilisateur = idUtilisateur;
			this.Type_Utilisateur = type_utilisateur;
			this.Identifiant = identifiant;
			this.Nom = nom;
			this.Prenom = prenom;
			this.Classe = classe;
			this.Password = password;
			this.urlAvatar = urlAvatar;			
		}

        public int IdUtilisateur { get; set; }

		public string Type_Utilisateur { get; set; }

		public string Identifiant { get; set; }

		public string Nom { get; set; }

		public string Prenom { get; set; }

		public string Classe { get; set; }

		public string Password { get; set; }

		public string urlAvatar { get; set; }

		public DateTime DateInscription { get; set; }
	}
}
