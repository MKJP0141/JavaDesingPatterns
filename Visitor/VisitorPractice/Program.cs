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

                Console.WriteLine("File size is:");
                SizeVisitor sv = new SizeVisitor();
                rootdir.Accept(sv);
                Console.WriteLine($"{sv.Size}");

                // 
                Directory root1 = new Directory("root1");
                root1.Add(new File("diary.html", 10));
                root1.Add(new File("Index.html", 20));

                Directory root2 = new Directory("root2");
                root2.Add(new File("diary.html", 1000));
                root2.Add(new File("index.html", 2000));

                ElementList list = new ElementList();
                list.Add(root1);
                list.Add(root2);
                list.Add(new File("etc.html", 1234));

                list.Accept(new ListVisitor());
            }
            catch (FileTreatmentException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
