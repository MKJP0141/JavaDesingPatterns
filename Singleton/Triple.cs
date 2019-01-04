namespace Singleton
{
    public class Triple
    {
        private static Triple[] _instances = new Triple[3] {
            new Triple(1),
            new Triple(2),
            new Triple(3)
        };

        private int _id;

        private Triple(int id)
        {
            _id  = id;
        }

        public static Triple GetInstance(int id)
        {
            return _instances[id];
        }
    }
}