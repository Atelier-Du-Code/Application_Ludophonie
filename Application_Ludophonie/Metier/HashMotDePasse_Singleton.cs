using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    public class HashMotDePasse_Singleton
    {
        private static HashMotDePasse_Singleton instanceUniqueHash;
        private SHA256 sha256;

        
       
        private HashMotDePasse_Singleton()
        {
            sha256 = SHA256.Create();
        }

        public static HashMotDePasse_Singleton GetInstance()
        {
            if(instanceUniqueHash == null)
            {
                instanceUniqueHash = new HashMotDePasse_Singleton();
            }

            return instanceUniqueHash;
        }

        public string HashMotDePasse(string motDePasse)
        {
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasse));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashedBytes.Length; i++)
            {
                sb.Append(hashedBytes[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
