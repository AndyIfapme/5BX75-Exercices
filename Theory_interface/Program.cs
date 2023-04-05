namespace Theory_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez introduie le chemin du fichier : ");
            var path = Console.ReadLine()!;


            UseFileService(path, new FileService());
        }

        private static void UseFileService(string path, IFileService service)
        {
            var data = service.GetFile(path);
            Console.WriteLine(data);
        }
    }
}