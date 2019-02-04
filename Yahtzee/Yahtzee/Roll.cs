using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Roll
    {
        IRandom randomVal;
        YahtzeeForm gameInstance;

        public int[] HoldDice = { 0, 0, 0, 0, 0 };
        public int[] DiceName = { 0, 0, 0, 0, 0 };
        
        public Roll()
        {
            this.randomVal = randomVal;       
        }

        public void RollResults()
        {
            if (HoldDice[0] == 0)
            {
                DiceName[0] = randomVal.Next(1,7);
            }
            if (HoldDice[1] == 0)
            {
                DiceName[1] = randomVal.Next(1, 7);
            }
            if (HoldDice[2] == 0)
            {
                DiceName[2] = randomVal.Next(1, 7);
            }
            if (HoldDice[3] == 0)
            {
                DiceName[3] = randomVal.Next(1, 7);
            }
            if (HoldDice[4] == 0)
            {
                DiceName[4] = randomVal.Next(1, 7);
            }
        }   
    }
}
