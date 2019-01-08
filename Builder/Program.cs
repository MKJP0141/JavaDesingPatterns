using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                usage();
                return;
            }

            if (args[0].Equals("plain", StringComparison.OrdinalIgnoreCase))
            {
                Builder textBuilder = new TextBuilder();
                Director director = new Director(textBuilder);
                director.Construct();
                
            }
        }
    }
}
