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

        public int[] HoldDice = { 0, 0, 0, 0, 0 }; //Hold or not hold die at index 0 = A, index 1 = B....

        public int[] Dice = { 0, 0, 0, 0, 0 };
        //Fill with DieA,DieB,DieC,DieD,DieE
        
        public Roll(IRandom randomVal)
        {
            this.randomVal = randomVal;
        }

        /*public void getHolds(int diceX, int holdIndicator)
        {
            if (holdIndicator == 1)
            {
                HoldDice[diceX] = 1;
            }
            if (gameInstance.buttonPushCounter == 3)
            {
                foreach (int index in HoldDice)
                {
                    HoldDice[index] = 0;
                }
            }
        }*/

        public void RollResults()
        {
            if (HoldDice[0] == 0)
            {
                Dice[0] = randomVal.Next(1, 7);
            }
            if (HoldDice[1] == 0)
            {
                Dice[1] = randomVal.Next(1, 7);
            }
            if (HoldDice[2] == 0)
            {
                Dice[2] = randomVal.Next(1, 7);
            }
            if (HoldDice[3] == 0)
            {
                Dice[3] = randomVal.Next(1, 7);
            }
            if (HoldDice[4] == 0)
            {
                Dice[4] = randomVal.Next(1, 7);
            }
        }   
    }
}
