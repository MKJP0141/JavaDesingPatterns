using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adapter
{
    public class FileProperties : FileIO
    {
        private Dictionary<string, string> _properties;

        public FileProperties()
        {
            _properties = new Dictionary<string, string>();
        }

        public string GetValue(string key)
        {
            if (_properties.ContainsKey(key))
            {
                return _properties[key];
            }
            return string.Empty;
        }

        public void ReadFromFile(string fileName)
        {
            using (var stream = new StreamReader(fileName))
            {
                while (!stream.EndOfStream)
                {
                    var line = stream.ReadLine();
                    var keyValue = line.Split('=');
                    _properties.Add(keyValue[0], keyValue[1]);
                }
            }
        }

        public void SetValue(string key, string value)
        {
            if (_properties.ContainsKey(key))
            {
                _properties[key] = value;
            }
            else
            {
                _properties.Add(key, value);
            }
        }

        public void WriteToFile(string fileName)
        {
            using (var stream = new StreamWriter(fileName, append:false, encoding:Encoding.UTF8))
            {
                var iterator = _properties.GetEnumerator();
                while (iterator.MoveNext())
                {
                    var item = iterator.Current;
                    stream.WriteLine($"{item.Key}={item.Value}");
                }
            }
        }
    }
}