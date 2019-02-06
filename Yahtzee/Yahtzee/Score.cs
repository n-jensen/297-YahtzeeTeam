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
        public int[] tempDiceValues = { 0, 0, 0, 0, 0 };

        public int totalScore;
        public int sum;
        public int bonusScore;

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
            bonusScore = 0;
            threeKindScore = 0;
            fourKindScore = 0;
            fullHouseScore = 0;
            smallStraightScore = 0;
            largeStraightScore = 0;
            chanceScore = 0;
            yahtzeeScore = 0;
            fillTempDiceValues(roll);
            IterateNumberAmounts();
        }

        public void fillTempDiceValues(Roll roll)
        {
            foreach (int index in roll.DiceValues)
            {
                tempDiceValues[index] = roll.DiceValues[index];
            }
        }

        public void IterateNumberAmounts()
        {
            for (int index = 0; index < 5; index++)
            {
                quantityOfEachDieNumber[tempDiceValues[index] - 1]++;
            }
        }

        public void TotalScore(int additionalScore)
        {
            totalScore = totalScore + additionalScore;
        }

        public void Sum()
        {
            sum = 0;
            for (int index = 0; index < 5; index++)
            {
                sum = sum + tempDiceValues[index];
            }
        }

        public void Bonus()
        {
            //FIXME: If you already got a yahtzee, get an extra 50 points
            if (yahtzeeScore == 50)
            {
                bonusScore = 50;
            }
        }


        public void Ones()
        {
            onesScore = quantityOfEachDieNumber[0] * 1;
        }

        public void Twos()
        {
            twosScore = quantityOfEachDieNumber[1] * 2;
        }

        public void Threes()
        {
            threesScore = quantityOfEachDieNumber[2] * 3;
        }

        public void Fours()
        {
            foursScore = quantityOfEachDieNumber[3] * 4;
        }

        public void Fives()
        {
           fivesScore = quantityOfEachDieNumber[4] * 5;
        }

        public void Sixes()
        {
            sixesScore = quantityOfEachDieNumber[5] * 6;
        }


        public void ThreeOfAKind()
        {
            for (int index = 0; index < 6; index++)
            {
                if (quantityOfEachDieNumber[index] == 3)
                {
                    Sum();
                    threeKindScore = sum;
                }
            }
        }

        public void FourOfAKind()
        {
            for (int index = 0; index < 6; index++)
            {
                if (quantityOfEachDieNumber[index] == 4)
                {
                    Sum();
                    fourKindScore = sum;
                }
            }
        }

        public void FullHouse()
        {
            int pairs = 0;
            for (int index = 0; index < 6; index++)
            {
                if (quantityOfEachDieNumber[index] == 3)
                {
                    pairs = pairs + 1;
                }
                else if (quantityOfEachDieNumber[index] == 2)
                {
                    pairs = pairs + 2;
                }
                if (pairs == 3)
                {
                    fullHouseScore = 25;
                }
            }
        }

        public void SmallStraight()
        {
            if ((quantityOfEachDieNumber[0] >= 1 && quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1)
              || (quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1)
              || (quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1 && quantityOfEachDieNumber[5] >= 1))
            {
                smallStraightScore = 30;
            }
        }

        public void LargeStraight()
        {
            if ((quantityOfEachDieNumber[0] >= 1 && quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1)
              || (quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1 && quantityOfEachDieNumber[5] >= 1 && quantityOfEachDieNumber[6] >= 1))
            {
                largeStraightScore = 40;
            }
        }

        public void Chance()
        {
            Sum();
            chanceScore = sum;
        }

        public void YahtzeeCombo()
        {
            for (int index = 0; index < 6; index++)
            {
                if (quantityOfEachDieNumber[index] == 5)
                {
                    yahtzeeScore = 50;
                }
            }
        }

        /*public void CalcScores()
        {
            IterateNumberAmounts();
            Sum();
            Bonus();

            Ones();
            Twos();
            Threes();
            Fours();
            Fives();
            Sixes();
            ThreeOfAKind();
            FourOfAKind();
            FullHouse();
            SmallStraight();
            LargeStraight();
            Chance();
            YahtzeeCombo();
        }*/
    }
}
