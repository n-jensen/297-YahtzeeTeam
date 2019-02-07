using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Roll
    {
        private IRandom randomVal;
        YahtzeeForm gameInstance;
        //FIXME: Make this gmae instance not null

        public int[] HoldDice = { 0, 0, 0, 0, 0 };
        public int[] DiceValues = { 0, 0, 0, 0, 0 };

        //FIXME: constructor

        public Roll(IRandom randomVal)
        {
            this.randomVal = randomVal;
        }

        public void RollResults()
        {
            for (int index = 0; index < 5; index++)
            {
                if(HoldDice[index] == 0)
                {
                    //FIXME: .Next doesn't seem to work?
                    DiceValues[index] = randomVal.Next(1, 7);
                }
            }
        }   
    }
}
