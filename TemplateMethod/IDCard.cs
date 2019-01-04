using System;
using Framework;

namespace IDCard
{
    public class IDCard : Product
    {
        private int _id;
        private string _owner;
        public IDCard(int id, string owner)
        {
            this._id = id;
            this._owner = owner;
            Console.WriteLine($"{_owner}({_id})のカードを作ります");
        }

        public override void Use()
        {
            Console.WriteLine($"{_id}:{_owner}のカードを使います");
        }

        public int GetId()
        {
            return _id;
        }
        public string GetOwner()
        {
            return _owner;
        }
    }
}