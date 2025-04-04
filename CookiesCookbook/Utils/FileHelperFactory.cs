public static class FileHelperFactory
{
    public static IFileHelper CreateFileHelper(FileType fileType)
    {
        return fileType switch
        {
            FileType.Txt => new FileHelper(),
            FileType.Json => new JsonHelper(),
            _ => throw new ArgumentException("Unsupported file type specified.")
        };
    }

    public static string GetFilePath(FileType fileType)
    {
        return fileType switch
        {
            FileType.Txt => "recipes.txt",
            FileType.Json => "recipes.json",
            _ => throw new ArgumentException("Unsupported file type specified.")
        };
    }
}