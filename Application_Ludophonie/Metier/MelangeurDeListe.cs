using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
    class MelangeurDeListe
    {
        //Objets pour le mélange individuel des listes
        List<Mot> lstMelange1 = new List<Mot>();
        List<Mot> lstMelange2 = new List<Mot>();
        List<Mot> lstMelange3 = new List<Mot>();


        //Objets pour la concaténation des listes
        List<Mot> lstMelangee1 = new List<Mot>();
        List<Mot> lstMelangee2 = new List<Mot>();
        List<Mot> lstMelangee3 = new List<Mot>();
        List<Mot> lstMelangee4 = new List<Mot>();
        List<Mot> lstMelangee5 = new List<Mot>();

        List<Mot> lstMotsDefinitive = new List<Mot>();

        Random nbAleatoire = new Random();



        public MelangeurDeListe()
        {
        }

        

        /*public List<Mot> melangeListe(List<Mot> liste_Initiale)
        {
            //Etape de mélange 1

            while(liste_Initiale.Count != 0)
            {
                int indexAsupprimer1 = nbAleatoire.Next(0, liste_Initiale.Count);

                if(liste_Initiale.Count == 1)
                {
                    indexAsupprimer1 = 0;
                }

                lstMelange1.Add(liste_Initiale[indexAsupprimer1]);

                liste_Initiale.Remove(liste_Initiale[indexAsupprimer1]);
            }

            //Etape de mélange 2

            while (lstMelange1.Count != 0)
            {
                int indexAsupprimer2 = nbAleatoire.Next(1, lstMelange1.Count);

                if (lstMelange1.Count == 1)
                {
                    indexAsupprimer2 = 0;
                }

                lstMelange2.Add(lstMelange1[indexAsupprimer2]);

                lstMelange1.Remove(lstMelange1[indexAsupprimer2]);
            }

            //Etape de mélange 3

            while (lstMelange2.Count != 0)
            {
                int indexAsupprimer3 = nbAleatoire.Next(1, lstMelange2.Count);

                if (lstMelange2.Count == 1)
                {
                    indexAsupprimer3 = 0;
                }

                lstMelange3.Add(lstMelange2[indexAsupprimer3]);

                lstMelange2.Remove(lstMelange2[indexAsupprimer3]);
            }

            return lstMelange3;
        }*/

        /*public List<Mot> melangeListe(List<Mot>liste_Initiale)
        {
            List<int> nbAleatoire_index1 = new List<int>();

            for(int i = 0; i < liste_Initiale.Count; i++)
            {
                nbAleatoire_index1.Add(nbAleatoire.Next(0, liste_Initiale.Count));
            }

            List<int> nbAleatoire_index2 = new List<int>();
            List<int> nbAleatoire_lstMelangee = new List<int>();
            List<int> nbAleatoire_lstDefinitive = new List<int>();

            for (int i = 0; i < liste_Initiale.Count; i++)
            {
                nbAleatoire_index2.Add(nbAleatoire.Next(0, liste_Initiale.Count));                
            }

            for(int k = 0; k < liste_Initiale.Count; k++)
            {
                nbAleatoire_lstDefinitive.Add(nbAleatoire_index2[nbAleatoire_index1[k]]);
            }

            List<Mot> lstMotsMelanges = new List<Mot>();

            for(int m = 0; m < liste_Initiale.Count; m++)
            {
                lstMotsMelanges.Add(liste_Initiale[nbAleatoire_lstDefinitive[m]]);
            }

            return lstMotsMelanges;
        }*/

        public int genereIntAleatoire(List<Mot> lstMots)
        {
            List<int> nbAleatoire_index1 = new List<int>();
            List<int> nbAleatoire_index2 = new List<int>();
            List<int> nbAleatoire_lstMelangee = new List<int>();
            List<int> nbAleatoire_lstDefinitive = new List<int>();


            for (int i = 0; i < lstMots.Count; i++)
            {
                nbAleatoire_index1.Add(nbAleatoire.Next(0, lstMots.Count));
            }

            for (int i = 0; i < lstMots.Count; i++)
            {
                nbAleatoire_index2.Add(nbAleatoire.Next(0, lstMots.Count));
            }

            for (int k = 0; k < lstMots.Count; k++)
            {
                nbAleatoire_lstDefinitive.Add(nbAleatoire_index2[nbAleatoire_index1[k]]);
            }

            return nbAleatoire_lstDefinitive[0];
        }

        public List<Mot> melangeList(List<Mot> lstMots)
        {
            List<Mot> lstMotsMelanges = new List<Mot>();
            int nbMots = lstMots.Count;

            for (int m = 0; m < nbMots; m++)
            {
                int index = genereIntAleatoire(lstMots);
                lstMotsMelanges.Add(lstMots[index]);

                lstMots.RemoveAt(index);
            }

            return lstMotsMelanges;
        }

        public List<Mot> concateneListe(List<Mot> liste_Initiale1, List<Mot> liste_Initiale2, List<Mot> liste_Initiale3, List<Mot> liste_Initiale4, List<Mot> liste_Initiale5)
        {
            lstMelangee1 = melangeList(liste_Initiale1);
            lstMelangee2 = melangeList(liste_Initiale2);
            lstMelangee3 = melangeList(liste_Initiale3);
            lstMelangee4 = melangeList(liste_Initiale4);
            lstMelangee5 = melangeList(liste_Initiale5);

            lstMotsDefinitive.AddRange(lstMelangee1);
            lstMelangee1.Clear();

            lstMotsDefinitive.AddRange(lstMelangee2);
            lstMelangee2.Clear();

            lstMotsDefinitive.AddRange(lstMelangee3);
            lstMelangee3.Clear();

            lstMotsDefinitive.AddRange(lstMelangee4);
            lstMelangee4.Clear();

            lstMotsDefinitive.AddRange(lstMelangee5);
            lstMelangee5.Clear();

            return lstMotsDefinitive;
        }
    }
}
