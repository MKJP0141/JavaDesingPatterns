namespace Framework
{
    public abstract class Factory
    {
        public Product Create(int id, string owner)
        {
            Product p = CreateProduct(id, owner);
            RegisterProduct(p);
            return p;
        }

        protected abstract Product CreateProduct(int id, string owner);
        protected abstract void RegisterProduct(Product product);
    }
}