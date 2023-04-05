namespace Theory_interface;

public class FileMockService : IFileService
{
    public string GetFile(string path)
    {
        return "Banane\nPomme\nPoire";
    }
}