namespace Exercice_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Programe qui effectue une division");

            Console.WriteLine("Veuillez introduire un nombre : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Veuillez introduire le diviseur : ");
            b = Convert.ToInt32(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Vous ne pouvez pas diviser par 0 !");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
    }
}