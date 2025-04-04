public interface IFileHelper
{
    List<string> Read(string filepath);
    void Write(string filePath, List<string> strings);
}
