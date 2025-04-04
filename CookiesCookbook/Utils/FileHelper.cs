namespace CookiesCookbook.Utils.FileHelper;
public class FileHelper : IFileHelper
{
    // Reads all lines from a file
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string filePath)
{
    try
    {
        // Read all lines from the file and return them as a list
        return File.ReadAllLines(filePath).ToList();
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine($"Error: The file '{filePath}' was not found.");
        return new List<string>(); // Return an empty list if the file is not found
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
        return new List<string>(); // Return an empty list in case of other errors
    }
}


    // Writes text to a file (overwrites existing content)
    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Separator, strings));
    }
}