using System;

namespace Exercice_04
{
    internal class Program
    {
        /*
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
            Console.Write("Veuillez introduire un nombre : ");

            if (int.TryParse(Console.ReadLine()!, out a))
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Vous n'avez pas introduit un chiffre !");
            }
        }
    }
}