namespace Theory_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            double b = 0;
            decimal c = 0;
            float d = 0;

            int? e = null;
            double? f = null;
            decimal? g = null;
            float? h = null;

//            e = 0;

            if (e.HasValue) //a != 0
            {
                Console.WriteLine(e.Value);
            }
            else
            {
                Console.WriteLine("    La variable n'est pas définie ".Trim());
            }
        }
    }
}