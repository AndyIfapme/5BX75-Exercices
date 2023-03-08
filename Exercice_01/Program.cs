using System;

namespace Exercice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string tmp; //Je suis un commentaire

            Console.Write("Ecrire une valeur : ");
            
            //tmp = Console.ReadLine()!;
            //a = Convert.ToInt32(tmp);

            a = Convert.ToInt32(Console.ReadLine());

            Console.Write($"La variable est : {a}");
        }
    }
}