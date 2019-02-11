using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Display b1 = new StringDisplay("Hello, World.");
            Display b2 = new SideBorder(b1, '#');
            Display b3 = new FullBorder(b2);
            b1.Show();
            b2.Show();
            b3.Show();

            Display b4 = new SideBorder(
                new FullBorder(
                    new FullBorder(
                        new SideBorder(
                            new FullBorder(
                                new StringDisplay("Hello!!")
                            ), '*'
                        )
                    )
                ), '/'
            );
            b4.Show();
        }
    }
}
