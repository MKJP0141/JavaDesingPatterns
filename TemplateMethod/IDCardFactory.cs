using Framework;
using System.Collections.Generic;

namespace IDCard
{
    public class IDCardFactory : Factory
    {
        private int _id = 100;
        private Dictionary<int, string> _owners = new Dictionary<int, string>();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(_id++, owner);
        }

        protected override void RegisterProduct(Product product)
        {
            _owners.Add(((IDCard)product).GetId(), ((IDCard)product).GetOwner());
        }

        public Dictionary<int, string> GetOwners()
        {
            return _owners;
        }
    }
}