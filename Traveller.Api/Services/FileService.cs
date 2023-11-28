namespace Traveller.Services;

public class FileService
{
    private const string FolderPath = @"C:\Users\enzor\source\repos\Travel-Agency-Web\Travel-Agency-Web\src\assets\Images";
    private const string RelativeFolderPath = @"Images";

    public string GetPath(string fileName, int id) => Path.Combine(FolderPath, $"({id}){fileName}");
    public string GetRelativePath(string fileName, int id) => Path.Combine(RelativeFolderPath, $"({id}){fileName}");
    public async Task SaveFileAsync(IFormFile inputStream, string fileName, int id)
    {
        var filePath = GetFilePath(fileName, id);
        await using var fileStream = File.Create(filePath);
        await inputStream.CopyToAsync(fileStream);
    }

    public void DeleteFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"The file was not found at path: {filePath}");
        }
        File.Delete(filePath);
    }
}