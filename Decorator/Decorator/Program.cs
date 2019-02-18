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

            Display b5 = new FullBorder(
                new UpdownBorder(
                    new SideBorder(
                        new UpdownBorder(
                            new SideBorder(
                                new StringDisplay("Hello."),
                                '*'
                            ),
                            '='
                        ),
                        '|'
                    ),
                    '/'
                )
            );
            b5.Show();

            MultiStringDisplay md = new MultiStringDisplay();
            md.Add("おはようございます。");
            md.Add("こんにちは。");
            md.Add("おやすみなさい、また明日。");
            md.Show();

            Display d6 = new SideBorder(md, '#');
            d6.Show();
            Display d7 = new FullBorder(md);
            d7.Show();
        }
    }
}
