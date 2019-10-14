using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuchreTest1
{
    class Bidding
    {
        public static Suit DetermineSuit()
        {
            return Trump.WhichSuit(Dealer.FaceCard());            
        }                
    }
}
