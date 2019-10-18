using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace EuchreTest1
{
    class Dealer
    {
        public static bool playerDeal, opp1Deal, partnerDeal, opp2Deal;

        public static void Deal()
        {

            if (playerDeal)
            {
                Game.turn = 0;
                opp1Deal = true;
                playerDeal = false;
            }

            else if (opp1Deal)
            {
                Game.turn = 1;
                partnerDeal = true;
                opp1Deal = false;
            }

            else if (partnerDeal)
            {
                Game.turn = 2;
                opp2Deal = true;
                partnerDeal = false;
            }

            else if(opp2Deal)
            {
                Game.turn = 3;
                playerDeal = true;
                opp2Deal = false;
            }
                

            Deck.Shuffle();
            Bidding.DetermineSuit();
            Ranks ranks = new Ranks();
            //Bidding.PlayerBid(PlayersCards());
        }

        public static List<int> PlayersCards()
        {
            List<int> hand = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                hand.Add(Deck.deck[i]);
            }

            hand.Sort();

            return hand;
        }

        public static List<int> Opp1Cards()
        {
            List<int> hand = new List<int>();

            for (int i = 5; i < 10; i++)
            {
                hand.Add(Deck.deck[i]);                
            }

            hand.Sort();

            return hand;
        }

        public static List<int> Opp2Cards()
        {
            List<int> hand = new List<int>();

            for (int i = 10; i < 15; i++)
            {
                hand.Add(Deck.deck[i]);
            }

            hand.Sort();

            return hand;
        }

        public static List<int> PartnersCards()
        {
            List<int> hand = new List<int>();

            for (int i = 15; i < 20; i++)
            {
                hand.Add(Deck.deck[i]);
            }

            hand.Sort();

            return hand;
        }



        public static int FaceCard()
        {
            return Deck.deck[20];
        }
    }
}
