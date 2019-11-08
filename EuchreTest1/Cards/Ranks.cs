using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuchreTest1
{
    class Ranks
    {
        public static Cards cards;

        public Ranks(Suit suit)
        {
            DetermineRank(suit);
            Suits.AssignSuit();
            Suits.SwitchJacks(suit);
        }
        public void GetRanks()
        {
            cards.value = new List<int>();

            for (int i = 0; i < 24; i++)
            {
                cards.value.Add(i);
            }
        }
        public List<int> DetermineRank(Suit suit)
        {
            GetRanks();
            cards.trump = suit;

            if (cards.trump == Suit.Clubs)
            {
                cards.value[0] = (int)TrumpRank.Nine;
                cards.value[1] = (int)TrumpRank.Ten;
                cards.value[2] = (int)TrumpRank.Right;
                cards.value[3] = (int)TrumpRank.Queen;
                cards.value[4] = (int)TrumpRank.King;
                cards.value[5] = (int)TrumpRank.Ace;
                cards.value[6] = (int)Rank.Nine;
                cards.value[7] = (int)Rank.Ten;
                cards.value[8] = (int)Rank.Jack;
                cards.value[9] = (int)Rank.Queen;
                cards.value[10] = (int)Rank.King;
                cards.value[11] = (int)Rank.Ace;
                cards.value[12] = (int)OppColorRank.Nine;
                cards.value[13] = (int)OppColorRank.Ten;
                cards.value[14] = (int)TrumpRank.Left;
                cards.value[15] = (int)OppColorRank.Queen;
                cards.value[16] = (int)OppColorRank.King;
                cards.value[17] = (int)OppColorRank.Ace;
                cards.value[18] = (int)Rank.Nine;
                cards.value[19] = (int)Rank.Ten;
                cards.value[20] = (int)Rank.Jack;
                cards.value[21] = (int)Rank.Queen;
                cards.value[22] = (int)Rank.King;
                cards.value[23] = (int)Rank.Ace;
            }
            else if (cards.trump == Suit.Spades)
            {
                cards.value[12] = (int)TrumpRank.Nine;
                cards.value[13] = (int)TrumpRank.Ten;
                cards.value[14] = (int)TrumpRank.Right;
                cards.value[15] = (int)TrumpRank.Queen;
                cards.value[16] = (int)TrumpRank.King;
                cards.value[17] = (int)TrumpRank.Ace;
                cards.value[6] = (int)Rank.Nine;
                cards.value[7] = (int)Rank.Ten;
                cards.value[8] = (int)Rank.Jack;
                cards.value[9] = (int)Rank.Queen;
                cards.value[10] = (int)Rank.King;
                cards.value[11] = (int)Rank.Ace;
                cards.value[0] = (int)OppColorRank.Nine;
                cards.value[1] = (int)OppColorRank.Ten;
                cards.value[2] = (int)TrumpRank.Left;
                cards.value[3] = (int)OppColorRank.Queen;
                cards.value[4] = (int)OppColorRank.King;
                cards.value[5] = (int)OppColorRank.Ace;
                cards.value[18] = (int)Rank.Nine;
                cards.value[19] = (int)Rank.Ten;
                cards.value[20] = (int)Rank.Jack;
                cards.value[21] = (int)Rank.Queen;
                cards.value[22] = (int)Rank.King;
                cards.value[23] = (int)Rank.Ace;
            }
            else if (cards.trump == Suit.Diamonds)
            {
                cards.value[0] = (int)Rank.Nine;
                cards.value[1] = (int)Rank.Ten;
                cards.value[2] = (int)Rank.Jack;
                cards.value[3] = (int)Rank.Queen;
                cards.value[4] = (int)Rank.King;
                cards.value[5] = (int)Rank.Ace;
                cards.value[6] = (int)TrumpRank.Nine;
                cards.value[7] = (int)TrumpRank.Ten;
                cards.value[8] = (int)TrumpRank.Right;
                cards.value[9] = (int)TrumpRank.Queen;
                cards.value[10] = (int)TrumpRank.King;
                cards.value[11] = (int)TrumpRank.Ace;
                cards.value[12] = (int)Rank.Nine;
                cards.value[13] = (int)Rank.Ten;
                cards.value[14] = (int)Rank.Jack;
                cards.value[15] = (int)Rank.Queen;
                cards.value[16] = (int)Rank.King;
                cards.value[17] = (int)Rank.Ace;
                cards.value[18] = (int)OppColorRank.Nine;
                cards.value[19] = (int)OppColorRank.Ten;
                cards.value[20] = (int)TrumpRank.Left;
                cards.value[21] = (int)OppColorRank.Queen;
                cards.value[22] = (int)OppColorRank.King;
                cards.value[23] = (int)OppColorRank.Ace;
            }
            else if (cards.trump == Suit.Hearts)
            {
                cards.value[0] = (int)Rank.Nine;
                cards.value[1] = (int)Rank.Ten;
                cards.value[2] = (int)Rank.Jack;
                cards.value[3] = (int)Rank.Queen;
                cards.value[4] = (int)Rank.King;
                cards.value[5] = (int)Rank.Ace;
                cards.value[18] = (int)TrumpRank.Nine;
                cards.value[19] = (int)TrumpRank.Ten;
                cards.value[20] = (int)TrumpRank.Right;
                cards.value[21] = (int)TrumpRank.Queen;
                cards.value[22] = (int)TrumpRank.King;
                cards.value[23] = (int)TrumpRank.Ace;
                cards.value[12] = (int)Rank.Nine;
                cards.value[13] = (int)Rank.Ten;
                cards.value[14] = (int)Rank.Jack;
                cards.value[15] = (int)Rank.Queen;
                cards.value[16] = (int)Rank.King;
                cards.value[17] = (int)Rank.Ace;
                cards.value[6] = (int)OppColorRank.Nine;
                cards.value[7] = (int)OppColorRank.Ten;
                cards.value[8] = (int)TrumpRank.Left;
                cards.value[9] = (int)OppColorRank.Queen;
                cards.value[10] = (int)OppColorRank.King;
                cards.value[11] = (int)OppColorRank.Ace;
            }
            return cards.value;
        }
    }
}
