using System.Runtime.Intrinsics.Arm;

namespace Exercice_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var helloWord = "Hello, World!";

            //foreach (var word in helloWord)
            //{
            //    Console.WriteLine(word);   
            //}

            //Console.WriteLine(helloWord[13]);

            //for (int i = helloWord.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(helloWord[i]);
            

            int a;
            bool isOk;
            //Console.WriteLine("Veuillez introduire un nombre : ");
            //bool isOk = int.TryParse(Console.ReadLine()!, out a);

            //while (!isOk)
            //{
            //    Console.WriteLine("Veuillez introduire un nombre : ");
            //    isOk = int.TryParse(Console.ReadLine()!, out a);
            //}

            do
            {
                Console.WriteLine("Veuillez introduire un nombre : ");
                isOk = int.TryParse(Console.ReadLine()!, out a);
            } while (!isOk);
        }
    }
}