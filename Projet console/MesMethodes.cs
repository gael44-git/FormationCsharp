using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_console
{
    public class MesMethodes
    {
        // pour les var: on utilise le camelCase / pour les methodes le PascalCase
        // visibilité [mot-clé : static] type-retour (void) Nom_Methode(param) {instructions}
        // une classe donnée peut posséder 2 types de méthodes:
        // une methode d'instance: accessible via une instance de la classe en question -- instancier une classe = créer un objet de cette classe
        // une méthode de classe : une méthode static ( une methode de classe) - pas besoin d'instancier la classe pour avoir accès aux méthodes static


        /// <summary>
        /// Méthode qui calcule la somme de 2 entiers
        /// </summary>
        /// <param name="x">est un entier</param>
        /// <param name="y">est un entier</param>
        /// <returns>un nbr entier</returns>
        public static int Somme(int x, int y)
        {
            return x + y;
        }

        //surcharge d'une méthode: pouvoir définir la meme méthode (meme signature) dans la meme classe avec uniquement la liste des param qui change

        public static int Somme(int x, int y, int z)
        {
            return x + y + z;
        }


        public static void Afficher(string chaine)
        {
            Console.WriteLine(chaine);
        }


        // definir une méthode qui liste le contenu d'un tab d'entier

        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        // une méthode qui renvoie la somme des éléments d'un tableau d'entiers

        public static int SommeElement(int[] tab)
        {
            // initialisation de la somme
            int somme = 0;
            //boucle pour parcourir le tab
            foreach (var item in tab)
            {
                somme += item;
            }

            return somme;
        }
        // une methode qui renvoie la moyenne des éléments d'un tableau d'entiers

        public static double Moyenne(int[] tab)
        {
            double somme = 0;
            foreach (var item in tab)
            {
                somme += item;
            }

            return somme / tab.Length;
        }
        // une méthode qui renvoie l'élément le plus petit d'un tableau d'entiers

        public static int Minimum(int[] tab)
        {
            int min = tab[0];

            for (int i = 1; i < tab.Length; i++)
            {
                if (min > tab[i])
                {
                    min = tab[i];
                }
            }


            return min;
        }

        // Param optionnels d'une méthode
        //z est un param optionnel car il possede une valeur par defaut -- 
        // les param optionnels possede des valeurs par deafut et doivent etre definis a la fin de la liste des param
        public static int SommeOptional(int x, int y, int z = 10)
        {
            return x + y + z;
        }

        // méthode qui permute 2 entiers
        // passage de param par réference (mot clé ref a utilisé seulement avec les types simples) -> types valeur -- pour les types complexe, par definitions sont deja des ref
        public static void Permuter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        //param en sortie d'une méthode 

        public static double Calcul(double a, double b, out double somme, out double moyenne )
        {
            somme = a + b;
            moyenne = (a + b) / 2;
            return a * b;
        }
    }
}
