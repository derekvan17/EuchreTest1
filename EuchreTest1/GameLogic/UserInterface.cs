using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuchreTest1
{
    public class UserInterface
    {
        public bool ShouldKittyBeVisible(int PassCount)
        {
            if (PassCount > 3)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool DecisionLabelVisible(int turn)
        {
            if(turn == Game.Turn)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }
    }
}
