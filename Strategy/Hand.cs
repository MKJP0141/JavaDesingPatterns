namespace Strategy
{
    public class Hand
    {
        public static readonly int HANDVALUE_GUU = 0;
        public static readonly int HANDVALUE_CHO = 1;
        public static readonly int HANDVALUE_PAA = 2;

        public static readonly Hand[] Hands = {
            new Hand(HANDVALUE_GUU),
            new Hand(HANDVALUE_CHO),
            new Hand(HANDVALUE_PAA)
        };

        private int _handValue;
        private static string[] Name = {
            "グー", "チョキ","パー"
        };

        private Hand(int handValue)
        {
            _handValue = handValue;
        }

        public static Hand GetHand(int handValue)
        {
            return Hands[handValue];
        }

        public bool IsStrongerThan(Hand h)
        {
            return Fight(h) == 1;
        }

        public bool IsWeakerThen(Hand h )
        {
            return Fight(h) == -1;
        }

        private int Fight(Hand h)
        {
            if (this == h)
            {
                return 0;
            }
            else if ((this._handValue + 1) % 3 == h._handValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return Name[_handValue];
        }
    }
}