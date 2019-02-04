using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Score
    {
        Roll roll;

        public int[] quantityOfEachDieNumber = { 0, 0, 0, 0, 0, 0 };
        //Fill with number of "1" dice at index 0, number of "2" dice at index 1...
        //quantityOfEachDieNumber counts number of dice that landed on 1,2,3,4,5 and 6

        public int totalScore;
        public int sum;
        public int bonus;

        public int onesScore;
        public int twosScore;
        public int threesScore;
        public int foursScore;
        public int fivesScore;
        public int sixesScore;

        public int threeKindScore;
        public int fourKindScore;
        public int fullHouseScore;
        public int smallStraightScore;
        public int largeStraightScore;
        public int chanceScore;
        public int yahtzeeScore;

        public Score()
        {
            onesScore = 0;
            twosScore = 0;
            threesScore = 0;
            foursScore = 0;
            fivesScore = 0;
            sixesScore = 0;
            totalScore = 0;
            sum = 0;
            bonus = 0;
            threeKindScore = 0;
            fourKindScore = 0;
            fullHouseScore = 0;
            smallStraightScore = 0;
            largeStraightScore = 0;
            chanceScore = 0;
            yahtzeeScore = 0;
        }

        public void Sum(Roll roll)
        {
            sum = 0;
            for (int index = 0; index < 5; index ++)
            {
                sum = sum + roll.DiceName[index];
            }
            //FIXME: After every 3 rolls, or every turn, renew Sum and add MORE to TotalScore
        }

        public void TotalScore(Roll roll)
        {
            for (int index = 0; index < 5; index++)
            {
                totalScore = totalScore + roll.DiceName[index];
            }
        }

        public void IterateNumberAmounts(Roll roll)
        {
            for (int index = 0; index < 5; index++)
            {
                quantityOfEachDieNumber[roll.DiceName[index] - 1]++;
                /*FIXME: 
                 * if (roll.DiceName[index] == 1)
                 * {    
                 *    roll.quantityOfEachDieNumber[0]++;    
                 * }
                 */
                //FIXME: each index at number count indicates the # of 1's through 6's rolled on the dice
                //Thus, each index for quantityOfEachDieNumber represents the DiceName in order (A-E or 1-5)
            }
        }

        public void OnesThroughSixes(Roll roll)
        {
            onesScore = 0;
            twosScore = 0;
            threesScore = 0;
            foursScore = 0;
            fivesScore = 0;
            sixesScore = 0;

            onesScore = quantityOfEachDieNumber[0] * 1;
            twosScore = quantityOfEachDieNumber[1] * 2;
            threesScore = quantityOfEachDieNumber[2] * 3;
            foursScore = quantityOfEachDieNumber[3] * 4;
            fivesScore = quantityOfEachDieNumber[4] * 5;
            sixesScore = quantityOfEachDieNumber[5] * 6;
        }
          
        public void ThreeOfAKind(Roll roll)
        {
            fourKindScore = 0;
            for (int index = 0; index < 6; index++)
            {
                if (quantityOfEachDieNumber[index] == 3)
                {
                    Sum(roll);
                    fourKindScore = sum;
                }
            }
        }

        public void FourOfAKind(Roll roll)
        {
            for (int index = 0; index < 6; index++)
            {
                if (quantityOfEachDieNumber[index] == 4)
                {
                    Sum(roll);
                    fourKindScore = sum;
                }
            }
        }

        public void FullHouse(Roll roll)
        {
            int pairs = 0;
            fullHouseScore = 0;
            for (int index = 0; index < 6; index++)
            {
                if (quantityOfEachDieNumber[index] == 3)
                {
                    pairs = 1;
                    //FIXME: index + 1, bc what if last if statement has a pair or a 3 
                }
                if(quantityOfEachDieNumber[index] == 2 && pairs == 1)
                {
                    fullHouseScore = 25;
                }
            }
        }

        public void SmallStraight(Roll roll)
        {
            if((quantityOfEachDieNumber[0] >= 1 && quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1) 
                || (quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1 && quantityOfEachDieNumber[5] >= 1) 
                || (quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1 && quantityOfEachDieNumber[5] >= 1 && quantityOfEachDieNumber[6] >= 1))
            {
                smallStraightScore = 30;
            }
            else
            {
                smallStraightScore = 0;
            }
        }

        public void LargeStraight(Roll roll)
        {
            if ((quantityOfEachDieNumber[0] >= 1 && quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1)
                || (quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1 && quantityOfEachDieNumber[5] >= 1 && quantityOfEachDieNumber[6] >= 1))
            {
                largeStraightScore = 40;
            }
            else
            {
                largeStraightScore = 0;
            }
        }

        public void Chance(Roll roll)
        {
            Sum(roll);
            chanceScore = sum;
        }

        public void YahtzeeCombo(Roll roll)
        {
            for(int index = 0; index < 6; index++)
            {
                if(roll.NumberCount[index] == 5)
                {
                    yahtzeeScore = 50;
                }
            }
        }

        public void CalcScores(Roll roll)
        {
            IterateNumberAmounts(roll);
            Sum(roll);

            OnesThroughSixes(roll);
            ThreeOfAKind(roll);
            FourOfAKind(roll);
            FullHouse(roll);
            SmallStraight(roll);
            LargeStraight(roll);
            Chance(roll);
            YahtzeeCombo(roll);
            //FIXME missing bonus
            //if a combo has alrdy been chosen, set a bool to true
        }

    }
}
