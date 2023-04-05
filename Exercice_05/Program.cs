using System.Runtime.Intrinsics.Arm;

namespace Exercice_05
{
    internal class Program
    {
/*
 *  Pouvoir effectuer une division.
 *  La division par 0 est impossible, il faut donc afficher un message d'erreur.
 *  Afficher un message d'erreur si l'utilisateur n'introduit pas un nombre entier.
 *
 *  On propose à l'utilisateur de recommancer tant qu'il n'introduit pas des valeurs entières
 */
        static void Main(string[] args)
        {
            int a, b;
            string read;
            bool isParseOk;

            Console.WriteLine("Programme qui effectue une division");
            Console.WriteLine("-----------------------------------");

            do
            {
                Console.Write("Veuillez introduire un nombre : ");
                read = Console.ReadLine()!;
                isParseOk = int.TryParse(read, out a);

                if (isParseOk == false)
                {
                    Console.WriteLine("\tVous n'avez introduit un nombre entier");
                }

            } while (isParseOk == false);

            do
            {
                Console.Write("Veuillez introduire le diviseur : ");
                read = Console.ReadLine()!;
                isParseOk = int.TryParse(read, out b);

                if (isParseOk == false)
                {
                    Console.WriteLine("\tVous n'avez introduit un nombre entier");
                }
                else
                {
                    if (b == 0)
                    {
                        Console.WriteLine("\tLa division par 0 est impossible");
                    }
                }

            } while (isParseOk == false || b == 0);

            Console.WriteLine($"Le résulat de la division est {a / b}");
        }
    }
}