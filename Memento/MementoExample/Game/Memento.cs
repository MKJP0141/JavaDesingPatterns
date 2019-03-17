using System.Collections.Generic;

namespace MementoExample.Game
{
    public class Memento
    {
        int _money;
        List<string> _fruits;

        public Memento(int money)
        {
            _money = money;
            _fruits = new List<string>();
        }

        public int Money => _money;

        internal void AddFruits(string fruit)
        {
            _fruits.Add(fruit);
        }

        internal IEnumerable<string> Fruits => _fruits;
    }
}