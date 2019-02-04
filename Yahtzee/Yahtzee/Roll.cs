using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Roll
    {
           
        YahtzeeForm gameInstance;

        public int[] HoldDice = { 0, 0, 0, 0, 0 };
        public int[] DiceName = { 0, 0, 0, 0, 0 };
        public Roll ()
        {

        }
        public int RollDie()
        {
            Random random = new Random();
            int randomHold = new int();
            randomHold = random.Next(1, 7);
            return randomHold;
        }

        public void RollResults()
        {
            
            if (HoldDice[0] == 0)
            {
                DiceName[0] = RollDie();
            }
            if (HoldDice[1] == 0)
            {
                DiceName[1] = RollDie();
            }
            if (HoldDice[2] == 0)
            {
                DiceName[2] = RollDie();
            }
            if (HoldDice[3] == 0)
            {
                DiceName[3] = RollDie();
            }
            if (HoldDice[4] == 0)
            {
                DiceName[4] = RollDie();
            }
        }   
    }
}
