namespace Traveller.Services;

public class FileService
{
    private const string FolderPath = @"C:\Users\anabe\OneDrive\Pictures";
    
    public async Task<string> SaveFileAsync(Stream inputStream, string fileName)
    {
        var filePath = Path.Combine(FolderPath, fileName);
        await SaveStreamToFile(inputStream, filePath);
        return filePath;
    }

    private async Task SaveStreamToFile(Stream inputStream, string filePath)
    {
        await using var fileStream = File.Create(filePath);
        await inputStream.CopyToAsync(fileStream);
    }
    
    public Stream GetFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"The file was not found at path: {filePath}");
        }

        return File.OpenRead(filePath);
    }
    
    public string GetFileName(string filePath)
    {
        return Path.GetFileName(filePath);
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