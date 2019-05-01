using InterpreterSample;
using System;
using System.IO;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var lines = File.ReadAllLines(@"..\..\..\program.txt");
                foreach (var line in lines)
                {
                    Console.WriteLine($"text = {line}");
                    Node node = new ProgramNode();
                    node.Parse(new Context(line));
                    Console.WriteLine($"Node = {node.ToString()}");
                }
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
