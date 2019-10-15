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
        public bool[] isTrump;
        public List<Suit> suit;
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

    public enum OppColorRank
    {
        Nine = 1,
        Ten,
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
