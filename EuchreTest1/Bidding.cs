using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EuchreTest1
{
    class Bidding
    {
        public static bool BidActive { get; set; }
        public static int PassCount { get; set; }
        public static Suit FaceCardSuit()
        {
            return Suits.TrumpSuit(Dealer.FaceCard());
        }
        public static int BidPoints(List<int> input, bool dealer)
        {
            int score = 0;

            for (int i = 0; i <= 4; i++)
            {
                if (Ranks.cards.isTrump[input[i]] == true)
                {
                    if (Ranks.cards.value[input[i]] >= 5)
                    {
                        score++;
                        score++;
                        score++;
                    }

                    else if (Ranks.cards.value[input[i]] >= 2)
                    {
                        score++;
                        score++;
                    }

                    else
                    {
                        score++;
                    }
                }

                else if (Ranks.cards.value[input[i]] == 5)
                {
                    score++;
                }
            }

            if (dealer)
            {
                if (Ranks.cards.value[Dealer.FaceCard()] >= 5)
                {
                    score++;
                    score++;
                    score++;
                }

                else if (Ranks.cards.value[Dealer.FaceCard()] >= 2)
                {
                    score++;
                    score++;
                }

                else
                {
                    score++;
                }
            }
            return score;
        }
        public static int BidPoints2(List<int> input, bool dealer)
        {
            int score = 0;

            for (int i = 0; i <= 4; i++)
            {
                if (Ranks.cards.isTrump[input[i]] == true)
                {
                    if (Ranks.cards.value[input[i]] >= 5)
                    {
                        score++;
                        score++;
                        score++;
                    }

                    else if (Ranks.cards.value[input[i]] >= 2)
                    {
                        score++;
                        score++;
                    }

                    else
                    {
                        score++;
                    }
                }

                else if (Ranks.cards.value[input[i]] == 5)
                {
                    score++;
                }
            }

            return score;
        }
        public static int BidDecision(int input)
        {
            if (input >= 10)
            {
                return 2;
            }

            else if (input >= 7)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
     }
}
