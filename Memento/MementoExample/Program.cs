using System;
using System.IO;
using System.Threading;
using MementoExample.Game;

namespace MementoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer(100);

            Memento memento;
            if (File.Exists("memento.dat"))
            {
                memento = Memento.Deserialize();
            }
            else
            {
                memento = gamer.CreateMemento();
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"==== {i}");
                Console.WriteLine($"現状：{gamer}");

                gamer.Bet();

                Console.WriteLine($"所持金は{gamer.Money}円になりました。");

                if (gamer.Money > memento.Money)
                {
                    Console.WriteLine("      (だいぶ増えたので、現在の状態を保存しておこう)");
                    memento = gamer.CreateMemento();
                }
                else if (gamer.Money < memento.Money / 2)
                {
                    Console.WriteLine("      (だいぶ減ったので、以前の状態に復帰しよう)");
                    gamer.RestoreMemento(memento);
                }

                try
                {
                    Thread.Sleep(10);
                }
                catch (System.Exception)
                {

                    throw;
                }
                Console.WriteLine("");
            }
            memento.Serialize();
        }
    }
}
