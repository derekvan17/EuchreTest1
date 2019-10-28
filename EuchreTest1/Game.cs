using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuchreTest1
{
    class Game
    {
        public static int Turn;
        public static void RandomDeal()
        {
            Random rand = new Random();

            int dealer = rand.Next(3);

            if (dealer == 0)
            {
                Dealer.playerDeal = true;
            }

            else if (dealer == 1)
            {
                Dealer.opp1Deal = true;
            }

            else if (dealer == 2)
            {
                Dealer.partnerDeal = true;
            }

            else
            {
                Dealer.opp2Deal = true;
            }
        }
    }
}
