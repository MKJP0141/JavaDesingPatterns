using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed1 = 312;
            int seed2 = 15;

            Player player1 = new Player("Taro", new RandomStrategy(seed1));
            Player player2 = new Player("Hana", new ProbStrategy(seed2));

            for (int i = 0; i < 10000; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Hand nextHand2 = player2.NextHand();
                if (nextHand1.IsStrongerThan(nextHand2))
                {
                    Console.WriteLine($"Winner: {player1}");
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.IsStrongerThan(nextHand1))
                {
                    Console.WriteLine($"Winner: {player2}");
                    player2.Win();
                    player1.Lose();
                }
                else
                {
                    Console.WriteLine("Even...");
                    player1.Even();
                    player2.Even();
                }
            }
            Console.WriteLine($"Total result:");
            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());
        }
    }
}
