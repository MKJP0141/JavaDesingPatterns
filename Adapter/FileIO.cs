namespace Adapter
{
    public interface FileIO
    {
         void ReadFromFile(string fileName);
         void WriteToFile(string fileName);
         void SetValue(string key, string value);
         string GetValue(string key);
    }
}