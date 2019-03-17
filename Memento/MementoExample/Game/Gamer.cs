using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoExample.Game
{
    public class Gamer
    {
        private int _money;
        private List<string> _fruits = new List<string>();
        private Random _random = new Random();
        private static string[] FruitsName = {
            "りんご", "ぶどう", "バナナ", "みかん",
        };

        public Gamer(int money)
        {
            _money = money;
        }

        public int Money => _money;

        public void Bet()
        {
            var dice = _random.Next(0, 6) + 1;
            if (dice == 1)
            {
                _money += 100;
                Console.WriteLine("所持金が増えました");
            }
            else if (dice == 2)
            {
                _money /= 2;
                Console.WriteLine("所持金が半分になりました。");
            }
            else if (dice == 6)
            {
                var fruit = GetFruit();
                Console.WriteLine($"フルーツ({fruit})をもらいました。");
                _fruits.Add(fruit);
            }
            else
            {
                Console.WriteLine("何も起こりませんでした。");
            }
        }

        public Memento CreateMemento()
        {
            var memento = new Memento(_money);
            var iterator = _fruits.GetEnumerator();

            foreach (var fruit in _fruits)
            {
                if (fruit.StartsWith("おいしい"))
                {
                    memento.AddFruits(fruit);
                }
            }
            return memento;
        }

        public void RestoreMemento(Memento memento)
        {
            _money = memento.Money;
            _fruits = memento.Fruits.ToList();
        }

        public override string ToString()
        {
            string fruits = string.Empty;
            string separator = string.Empty;
            foreach (var fruit in _fruits)
            {
                fruits += $"{separator}{fruit}";
                separator = ",";
            }
            return $"[money = {_money}, fruits = {fruits} ]";
        }

        private string GetFruit()
        {
            var prefix = "";
            if (_random.Next(0, 2) == 1)
            {
                prefix = "おいしい";
            }
            return prefix + FruitsName[_random.Next(0, FruitsName.Length)];
        }
    }
}