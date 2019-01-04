namespace Singleton
{
    public class TicketMaker
    {
        private static TicketMaker _instance = new TicketMaker();

        private int _ticket = 1000;

        private TicketMaker()
        {
        }

        public static TicketMaker GetInstance()
        {
            return _instance;
        }

        public int GetNextTicketNumber()
        {
            return _ticket++;
        }
    }
}