using Projet_DLL;
using System;


namespace Projet_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test c#");


            Tools.MethodeDll();


            #region Les Variables

            //Variable: zone mémoire contenant une valeur typée
            //Types simples(valeurs): entiers, rééls, boolean, char
            //types complèxes (types références): Array, string, enum, classe et objet

            // entiers: byte( 1 o), shrt(2 o), int(4 o), long(8 o)
            // pour déclarer une variable: Type Nom_Variable = valeur;

            int myInt = 10;
            int myInt2 = myInt;
            myInt = 20;
            Console.WriteLine("Contenu de la variable myInt" + myInt); // +: une concaténation

            char myChar = 'c';
            string chaine = "ceci est une chaine";
            string chaine2 = chaine;

            chaine = "nouvelle chaine";

            chaine = null;
            chaine = chaine.ToUpper();

            // appel explicite du garbage collector: cet appel explicite l'implique pas le passage immédiat du garbage collector
            GC.Collect();

            

            //réél: float(4 o), double (8 o), décimal(16 o)
            double myDouble = 10.5;

            bool myBool = true;

            // le mot clé var: inférence du type - le compilateur détermine le type de la variable selon la valeur qui lui a été affectée
            var maVariable = "10.5";

            // maVariable = 10; - Erreur de compilation

            //constante : variable dont on ne peut pas modifier la valeur typée: convention= nom des constantes en maj

            const double MA_CONSTANTE = 10.9;


            #endregion

            #region Opérateurs

            // Opérateurs arithmetiques: +,-,*,/,% (modulo - reste de la division entière)
            double resultat = 9 / 2;
            Console.WriteLine("9 divisé par: " + resultat); //4.5


            int mod = 9 % 2;
            Console.WriteLine("reste de la division de 9 sur 2: " + mod); // =1

            // Opérateurs d'incrementation et décrementation:
            int i = ;
            i++; // i = i+1; 
            i--; // i = i-1;

            // Opérateurs combinés: +=, -=, *=, /=
            i += 5; // i = i+5;

            // Opérateurs de comparaison: == (égalité), <, >, <=, >=, != (différent)
            // Opérateurs logiques: && (et), || (ou), ^ (ou exclusif), ! (non logique)
            int v1 = 10, v2 = = 15;

            Console.WriteLine((v2 > v1) && (v2 < v1); false; // false
            // table logique 
            // A    B    (A&&B)  (A||B)  (A^B)
            // v    v       v       v       f
            // v    f       f       v       v
            // f    v       f       v       v
            // f    f       f       f       f

            //Caractères d'echappement:
            Console.WriteLine("\t bonjour, \nje suis en formation chez dawan. \n formation c#.");
            string chemin = "c:\\test";

            // chaine verbatim
            string chemin2 = @"c:\test";

            string paragraph = @"Bonjour, je suis en formation c#";

            //formattage de chaines en utilisant l'interpolation
            int x = 20, y = 30;
            Console.WriteLine("x = " + x + "y = " + y); //concatenation
            Console.WriteLine("x = {0}")
            Console.WriteLine($"x={x} y = {y}"); // interpolation v2


            #endregion

            #region Conversion de types

            // conversion implicite: concerne le passage d'un type inférieur à un type superieur 
            byte myByte = 10;
            int myInteger = myByte;

            //conversion explicite: concerne le passage d'un type sup à un type inf
            //1- utilisation d'un CAST : (byte), (int), (double).... risque de pertes de données
            //2- utilisation de la classe convert
            //3- utilisation de la methode parse
            int myInteger2 = 10;
            byte myByte2 = (byte)myInteger2;
            byte myByte3 = Convert.ToByte(myInteger2);
            // byte myByte4 = byte.Parse(myInteger2); - la methode parse concerne les conversions en types non compatibles

            string str = "20";
            int chiffre = int.Parse(str);
            int chiffre2 = Convert.ToInt32(str);

            Console.WriteLine("merci de saisir votre age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"votre age est: {age}");



            #endregion

            #region Conditions

            //if (condition est vraie) {instru1} else {instruc1}
            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else if(nb==0)
            {
                Console.WriteLine("nb est null");
            }
            else
            {
                Console.WriteLine("nb est negatif");
            }

            //switch: une variante de la condition if
            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("juste la moyenne, 10, 11, 12");
                    break;
                default:
                    Console.WriteLine("reussite garantie");
                    break;
            }

            // Opérateur ternaire: (condition) ? expression1 : expression2; --- si la condition est vraie : resultat = epression1 sinon resultat recois expression2
            bool myBool = (10 > 5) ? false : true; // myBOOL = false;

            #endregion

            #region Boucles

            // boucles conditionnelles: while, do while
            // boucle itérative: for, for each

            //for: connaitre le nbr d'itérations
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"passage numero: {i}");
            }

            // for each: permet de faire un parcours complet d'une collection
            int[] tab = { 1, 2, 3, 4 };

            foreach (int item in tab) // pour chaque entier contenu dans le tableau tab
            {
                Console.WriteLine(item);
            }

            //while
            int valeur = 1;
            while (valeur < 5) // tant que valeur est inferieur a 5 :
            {
                Console.WriteLine($"passage numero: {valeur}");
                valeur++;

                //sortir de la boucle while si valeur == 3 
                if (valeur == 3)
                {
                    break;
                    //break nous permet de sortir de la boucle while
                }
            }

            // do - while: fais tant que condition est vraie
            do
            {
                Console.WriteLine($"passage numero: {valeur}");
                valeur++;
            } while (valeur < 10);

            #endregion

            #region Tableaux

            Console.WriteLine("******Tableaux******");

            // tableaux: ensemble d'éléments de taille fixe

            // 1 dimension
            int[] myTableau = new int[3]; //tab de 3 cases
            myTableau[0] = 10;
            myTableau[1] = 20;
            myTableau[3] = 30;

            int[] myTableau2 = { 10, 20, 30 };

            Console.WriteLine("taille du tableau2: " + myTableau2.Length);
            //lister le contenu du tableau
            foreach (var item in myTableau2)
            {
                Console.WriteLine(item);
            }

            for (int i=0; i < myTableau2.Length; i++)
            {
                Console.WriteLine(myTableau2[i]);
            }

            // tableau a 2 dimensions
            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 15;
            matrice[0, 2] = 20;
            matrice[1, 0] = 25;
            matrice[1, 1] = 30;
            matrice[1, 2] = 35;

            // autre methode

            int[,] matrice2 = { { 10, 20, 30 }, { 40, 50, 60 } };
            Console.WriteLine(matrice2[1, 0]); // 40 

            Console.WriteLine("nbr de ligne de matrice2" +matrice2.GetLength(0)); //2
            Console.WriteLine("nbr de ligne de matrice2" +matrice2.GetLength(1)); //3
            Console.WriteLine("nbr d'élément de la matrice2: " + matrice2.Length); //6
            Console.WriteLine("nbr de dimension de la matrice2 :" + matrice2.Rank); //2

            // lister le contenu de la matrice 2
            for (int ligne = 0; ligne < matrice2.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < matrice2.GetLength(1); colonne++) 
                {
                    Console.WriteLine(matrice2[ligne, colonne]);
                }
            }


            #endregion

            #region Méthodes

            // méthode: ensemble d'instructions réutilisables
            // en POO, 2 types de méthodes possibles
            // procédure: methode qui ne renvoie aucun résultat
            // fonction: méthode qui renvoie un résultat

            Console.WriteLine("******Methodes******");

           int res =  MesMethodes.Somme(10, 20);

            Console.WriteLine($"somme de 10 et 20 est {res}");

            MesMethodes.Somme(10, 20, 30);

            MesMethodes.Afficher("test de chaine");

            int[] tab = { 10, 0, 20, 15 };

            MesMethodes.Afficher(tab);

            int[] tab2 = { 10, 0, 20, 15, 48, 65 };

            MesMethodes.Afficher(tab2);

            int somElement = MesMethodes.SommeElement(tab);
            Console.WriteLine($"Somme des elements de tableau: { somElement}");

            Console.WriteLine($"la moy des elements du tab: {MesMethodes.Moyenne(tab)}");

            Console.WriteLine($" l'element min du tab: {MesMethodes.Minimum(tab)}");

            // appel de la methode qui prend des param optionnels
            MesMethodes.SommeOptional(10, 20); // 40
            MesMethodes.SommeOptional(10, 20, 30); // 60


            int valeur1 = 10, valeur2 = 20;

            Console.WriteLine($"avant permutation: valeur1= {valeur1} - valeur2={valeur2}"); // 10 -20

            MesMethodes.Permuter(ref valeur1, ref valeur2);

            Console.WriteLine($"apres permut : valeur1={valeur1} - valeur2={valeur2}"); // 20 - 10

            // appel de la méthode avec des params en sortie

            double a = 10, b = 20;
            double sommeSortie = 0, moyenneSortie = 0;

           double produit =  MesMethodes.Calcul(a, b, out sommeSortie, out moyenneSortie);

            Console.WriteLine($"produit = {produit}");
            Console.WriteLine($"somme en sortie = {sommeSortie}");
            Console.WriteLine($"moyenne en sortie = {moyenneSortie}");

            string number = "20";
            int numConvert = 0;
            bool conversion = int.TryParse(number, out numConvert);
            if (conversion)
            {
                Console.WriteLine($"conversion reussi - numConvert = {numConvert}");
            }
            else
            {
                Console.WriteLine("echec de la conversion");
            }

            #endregion
            // maintient la console active
            Console.ReadLine();
        }
    }
}
