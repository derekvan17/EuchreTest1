using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuchreTest1
{
    class Trump
    {
        public static Suit WhichSuit(int input)
        {
            if (input >= 0 && input <= 5)
            {
                return Suit.Clubs;
            }

            else if (input >= 6 && input <= 11)
            {
                return Suit.Diamonds;
            }

            else if (input >= 12 && input <= 17)
            {
                return Suit.Spades;
            }

            else
            {
                return Suit.Hearts;
            }
        }
    }
}
