using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory rootdir = new Directory("root");

            Directory usrdir = new Directory("usr");
            rootdir.Add(usrdir);

            Directory yuki = new Directory("yuki");
            usrdir.Add(yuki);

            File file = new File("Composite.java", 100);
            yuki.Add(file);
            rootdir.PrintList();

            Console.WriteLine("");
            Console.WriteLine($"file = {file.GetFullName()}");
            Console.WriteLine($"yuki = {yuki.GetFullName()}");
        }
    }
}
