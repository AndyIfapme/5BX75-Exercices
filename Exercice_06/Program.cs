using Exercice_06.Totos;

namespace Exercice_06;

internal class Program
{
    static void Main(string[] args)
    {
        Color colorNumber;
        bool isParseOk;

        int numberCount = Enum.GetNames(typeof(Color)).Length;

        do
        {
            Console.Write("Choisir votre couleur : ");
            isParseOk = Color.TryParse(Console.ReadLine()!, out colorNumber);
            if (!isParseOk || colorNumber < 0 || (int)colorNumber >= numberCount)
            {
                Console.WriteLine("\tVous n'avez pas introduit une couleur");
            }
        } while (isParseOk == false || colorNumber < 0 || (int)colorNumber >= numberCount);


        switch (colorNumber)
        {
            case Color.Red:
                Console.WriteLine("Vous avez choisi la couleur est rouge");
                break;
            case Color.Green:
                Console.WriteLine("Vous avez choisi la couleur est verte");
                break;
            case Color.Blue:
                Console.WriteLine("Vous avez choisi la couleur est bleu");
                break;
            case Color.Black:
                break;
            case Color.White:
                Console.WriteLine("Vous avez choisi la couleur est blanche");
                break;
            default:
                Console.WriteLine("Vous n'avez pas séléctionner une couleur valide");
                break;
        }
    }
}
