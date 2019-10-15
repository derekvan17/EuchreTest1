using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuchreTest1
{
    class Suits
    {
        public static Suit TrumpSuit(int input)
        {
            Ranks.cards.isTrump = new bool[24];

            if (input >= 0 && input <= 5)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Ranks.cards.isTrump[i] = true;
                }

                return Suit.Clubs;
            }

            else if (input >= 6 && input <= 11)
            {
                for (int i = 6; i <= 11; i++)
                {
                    Ranks.cards.isTrump[i] = true;
                }

                return Suit.Diamonds;
            }

            else if (input >= 12 && input <= 17)
            {
                for (int i = 12; i <= 17; i++)
                {
                    Ranks.cards.isTrump[i] = true;

                }

                return Suit.Spades;
            }

            else
            {
                for (int i = 18; i <= 23; i++)
                {
                    Ranks.cards.isTrump[i] = true;
                }

                return Suit.Hearts;
            }
        }
        public static void AssignSuit()
        {
            Ranks.cards.suit = new List<Suit>();

            for (int i = 0; i <= 5; i++)
            {
                Ranks.cards.suit.Add(Suit.Clubs);
            }

            for (int i = 6; i <= 11; i++)
            {
                Ranks.cards.suit.Add(Suit.Diamonds);
            }

            for (int i = 12; i <= 17; i++)
            {
                Ranks.cards.suit.Add(Suit.Spades);
            }

            for (int i = 18; i <= 23; i++)
            {
                Ranks.cards.suit.Add(Suit.Hearts);
            }
        }

        public static void SwitchJacks(Suit input)
        {
            if (input == Suit.Clubs)
            {
                Ranks.cards.suit[14] = Suit.Clubs;
                Ranks.cards.isTrump[14] = true;
            }
            else if (input == Suit.Spades)
            {
                Ranks.cards.suit[2] = Suit.Spades;
                Ranks.cards.isTrump[2] = true;
            }
            else if (input == Suit.Diamonds)
            {
                Ranks.cards.suit[20] = Suit.Diamonds;
                Ranks.cards.isTrump[20] = true;
            }
            else if (input == Suit.Hearts)
            {
                Ranks.cards.suit[8] = Suit.Hearts;
                Ranks.cards.isTrump[8] = true;
            }
        }
    }
}
