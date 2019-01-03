using System;
using System.IO;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIO f = new FileProperties();
            try
            {
                f.ReadFromFile("file.txt");
                f.SetValue("year", "2004");
                f.SetValue("month", "4");
                f.SetValue("day", "21");
                f.WriteToFile("newfile.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
