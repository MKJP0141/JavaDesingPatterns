using System;
using VisitorPractice;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Making root entries...");
                Directory rootdir = new Directory("root");
                Directory bindir = new Directory("bin");
                Directory tmpdir = new Directory("tmp");
                Directory usrdir = new Directory("usr");
                rootdir.Add(bindir);
                rootdir.Add(tmpdir);
                rootdir.Add(usrdir);
                bindir.Add(new File("vi", 10000));
                bindir.Add(new File("latex", 20000));
                rootdir.Accept(new ListVisitor());

                Console.WriteLine("");
                Console.WriteLine("Making user entries...");
                Directory yuki = new Directory("yuki");
                Directory hanako = new Directory("hanako");
                Directory tomura = new Directory("tomura");
                usrdir.Add(yuki);
                usrdir.Add(hanako);
                usrdir.Add(tomura);
                yuki.Add(new File("diary.html", 100));
                yuki.Add(new File("Composite.java", 200));
                hanako.Add(new File("memo.tex", 300));
                hanako.Add(new File("index.html", 350));
                tomura.Add(new File("game.doc", 400));
                tomura.Add(new File("junk.mail", 500));
                rootdir.Accept(new ListVisitor());

                FileFindVisitor ffv = new FileFindVisitor(".html");
                rootdir.Accept(ffv);

                Console.WriteLine("HTML files are:");
                foreach (var file in ffv.FoundFiles)
                {
                    Console.WriteLine(file);
                }
            }
            catch (FileTreatmentException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
