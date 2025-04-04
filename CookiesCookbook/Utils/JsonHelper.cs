using System.Text.Json;
namespace CookiesCookbook.Utils.JsonHelper;
public class JsonHelper : IFileHelper
{
    public List<string> Read(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return new List<string>(); // Return an empty list if the file does not exist
        }

        var jsonContent = File.ReadAllText(filePath);

        // Deserialize the JSON content and ensure a non-null return value
        return JsonSerializer.Deserialize<List<string>>(jsonContent) ?? new List<string>();
    }


    // Writes text to a file (overwrites existing content)
    public void Write(string filePath, List<string> newData)
    {
        try
        {
            // Read existing data from the file
            var existingData = Read(filePath);

            // Merge the existing data with the new data
            existingData.AddRange(newData);

            // Serialize the combined data into JSON format
            var jsonContent = JsonSerializer.Serialize(existingData, new JsonSerializerOptions { WriteIndented = true });

            // Write the JSON content to the file
            File.WriteAllText(filePath, jsonContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
        }
    }
}