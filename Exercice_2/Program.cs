using System;

namespace Exercice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;

            Console.WriteLine("Quel est la somme de 7 + 3 ?");
            res = Convert.ToInt32(Console.ReadLine());

            if (res != 10)
            {
                Console.WriteLine("Réponse incorrect !");
            }
            else
            {
                Console.WriteLine("Réponse correct !");
            }
        }
    }
}