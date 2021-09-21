using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {

            // déclaration des variables
            string choix = "";
            int valeur1 = 0, valeur2 = 0;

            //affichage d'un menu
            Console.WriteLine("*****CALCULATRICE CONSOLE*****");
            Console.WriteLine("addtion: tapez a");
            Console.WriteLine("soustraction: tapez b");
            Console.WriteLine("multiplication: tapez c");
            Console.WriteLine("division: tapez d");

            // récuperer le choix: tant que le choix saisi est invalid - inviter le user a faire un nouveau choix

            do
            {
                Console.WriteLine("merci de faire votre choix");
                choix = Console.ReadLine();

            } while (!(choix == "a") || (choix == "b") || (choix == "c") || (choix == "d")  );


            // tant que les valeurs saisies ne sont pas valides: le user doit saisir de nouvelles valeurs
            // recuperer valeur1:
            do
            {
                Console.WriteLine("merci de saisir la premiere valeur:");
                try
                {
                    valeur1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                   
                }
                
            } while (true);


            //recuperer valeur2:
            do
            {
                Console.WriteLine("merci de saisir la premiere valeur:");
                try
                {
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {


                }

            } while (true);


            //affichage du résultat

            switch (choix)
            {
                case "a":
                    Console.WriteLine(valeur1 + "+" + valeur2 + "=" + (valeur1+valeur2));
                    break;
                case "b":
                    Console.WriteLine(valeur1 + "-" + valeur2 + "=" + (valeur1 - valeur2));
                    break;
                case "c":
                    Console.WriteLine(valeur1 + "*" + valeur2 + "=" + (valeur1 * valeur2));
                    break;
                case "d":
                    Console.WriteLine(valeur1 + "/" + valeur2 + "=" + (valeur1 / valeur2));
                    break;
                    
            }



            Console.ReadLine();
        }
    }
}
