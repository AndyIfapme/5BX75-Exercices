namespace Theory_interface;

public class FileService : IFileService
{
    public string GetFile(string path)
    {
        return File.ReadAllText(path);
    }
}