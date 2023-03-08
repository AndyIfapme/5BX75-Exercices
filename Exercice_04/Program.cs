using System;

namespace Exercice_04
{
    internal class Program
    {
        /*5
         * 5
         *  Pouvoir effectuer une soustraction.
         *
         *  La division par 0 est impossible,
         * il faut donc afficher un message d'erreur.
         *
         * Afficher un message d'erreur si l'utilisateur
         * n'introduit pas un nombre entier.
         */
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Programe qui effectue une division");

            Console.WriteLine("Veuillez introduire un nombre : ");
            bool isOk = int.TryParse(Console.ReadLine()!, out a);

            if (isOk)
            {
                Console.WriteLine("Veuillez introduire votre diviseur : ");
                isOk = int.TryParse(Console.ReadLine()!, out b);

                if (isOk)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Vous ne pouvez pas diviser par 0 !");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas introduit un nombre !");
                }
            }
            else
            {
                Console.WriteLine("Vous n'avez pas introduit un nombre !");
            }
           
        }
    }
}