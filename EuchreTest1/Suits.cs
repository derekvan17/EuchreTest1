using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuchreTest1
{
    class Suits
    {
        /*public static Suit WhichSuit(int input)
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
        }*/

        public static void AssignSuit()
        {
            Ranks.cards.suit = new List<Suit>();

            for (int i = 0; i < 6; i++)
            {
                Ranks.cards.suit.Add(Suit.Clubs);
            }

            for (int i = 6; i < 12; i++)
            {
                Ranks.cards.suit.Add(Suit.Diamonds);
            }

            for (int i = 12; i < 18; i++)
            {
                Ranks.cards.suit.Add(Suit.Spades);
            }

            for (int i = 18; i < 24; i++)
            {
                Ranks.cards.suit.Add(Suit.Hearts);
            }
        }

        public static void SwitchJacks(Suit input)
        {
            if (input == Suit.Clubs)
            {
                Ranks.cards.suit[14] = (int)Suit.Clubs;
            }
            else if (input == Suit.Spades)
            {
                Ranks.cards.value[2] = (int)Suit.Spades;
            }
            else if (input == Suit.Diamonds)
            {
                Ranks.cards.value[20] = (int)Suit.Diamonds;
            }
            else if (input == Suit.Hearts)
            {
                Ranks.cards.value[8] = (int)Suit.Hearts;
            }
        }
    }
}
