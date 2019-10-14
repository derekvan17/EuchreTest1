using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuchreTest1
{
    public struct Cards
    {
        public Suit trump;
        public Suit suit;
        public List<int> value;

    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum TrumpRank
    {
        Nine,
        Ten,
        Queen,
        King,
        Ace,
        Left,
        Right
    }   
        
    class Deck
    {        
        public static List<int> deck = new List<int>();

        //ISSUE SELECTING SUIT HERE
        /*public static Suit WhichSuit(List<int> input)
        {
            for (int i = 0; i < 5; i++)
            {
                if (input[i] >= 0 && input[i] <= 5)
                {
                    return Suit.Clubs;
                }

                else if (input[i] >= 6 && input[i] <= 11)
                {
                    return Suit.Diamonds;
                }

                else if (input[i] >= 12 && input[i] <= 17)
                {
                    return Suit.Spades;
                }

                else
                {
                    return Suit.Hearts;
                }
            }

        }*/


        public static void Shuffle()
        {
            deck.Clear();
            List<int> deckRemaining = Enumerable.Range(0,23).ToList();
            
            Random rand = new Random();

            for (int i = 0; i < 21; i++)
            {
                int index; 
                index = rand.Next(0, deckRemaining.Count);
                deck.Add(deckRemaining[index]);                
                deckRemaining.RemoveAt(index);
            }
        }
    }
}
