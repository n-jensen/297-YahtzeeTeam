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

        public Score(Roll roll)
        {
            this.roll = new Roll(new RandomWrapper());
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
        }

        public void fillTempDiceValues(Roll roll)
        {
            for (int index = 0; index < 5; index++)
            {
                tempDiceValues[index] = 0;
            }
            for (int index = 0; index < 5; index++)
            {
                tempDiceValues[index] = roll.DiceValues[index];
            }
        }

        public void IterateNumberAmounts()
        {
            for (int index = 0; index < 6; index++)
            {
                quantityOfEachDieNumber[index] = 0;
            }
            for (int index = 0; index < 5; index++)
            {
                //quantityOfEachDieNumber[tempDiceValues[index]]++;
                if (tempDiceValues[index] == 1)
                    quantityOfEachDieNumber[0]++;
                else if (tempDiceValues[index] == 2)
                    quantityOfEachDieNumber[1]++;
                else if (tempDiceValues[index] == 3)
                    quantityOfEachDieNumber[2]++;
                else if (tempDiceValues[index] == 4)
                    quantityOfEachDieNumber[3]++;
                else if (tempDiceValues[index] == 5)
                    quantityOfEachDieNumber[4]++;
                else if (tempDiceValues[index] == 6)
                    quantityOfEachDieNumber[5]++;
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
            onesScore = 0;
            onesScore = quantityOfEachDieNumber[0] * 1;
        }

        public void Twos()
        {
            twosScore = 0;
            twosScore = quantityOfEachDieNumber[1] * 2;
        }

        public void Threes()
        {
            threesScore = 0;
            threesScore = quantityOfEachDieNumber[2] * 3;
        }

        public void Fours()
        {
            foursScore = 0;
            foursScore = quantityOfEachDieNumber[3] * 4;
        }

        public void Fives()
        {
            fivesScore = 0;
            fivesScore = quantityOfEachDieNumber[4] * 5;
        }

        public void Sixes()
        {
            sixesScore = 0;
            sixesScore = quantityOfEachDieNumber[5] * 6;
        }


        public void ThreeOfAKind()
        {
            threeKindScore = 0;
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
            fourKindScore = 0;
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
            fullHouseScore = 0;
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
            smallStraightScore = 0;
            if ((quantityOfEachDieNumber[0] >= 1 && quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1)
              || (quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1)
              || (quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1 && quantityOfEachDieNumber[5] >= 1))
            {
                smallStraightScore = 30;
            }
        }

        public void LargeStraight()
        {
            largeStraightScore = 0;
            if ((quantityOfEachDieNumber[0] >= 1 && quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1)
              || (quantityOfEachDieNumber[1] >= 1 && quantityOfEachDieNumber[2] >= 1 && quantityOfEachDieNumber[3] >= 1 && quantityOfEachDieNumber[4] >= 1 && quantityOfEachDieNumber[5] >= 1 && quantityOfEachDieNumber[6] >= 1))
            {
                largeStraightScore = 40;
            }
        }

        public void Chance()
        {
            chanceScore = 0;
            Sum();
            chanceScore = sum;
        }

        public void YahtzeeCombo()
        {
            yahtzeeScore = 0;
            for (int index = 0; index < 6; index++)
            {
                if (quantityOfEachDieNumber[index] == 5)
                {
                    yahtzeeScore = 50;
                }
            }
        }

        public void CalcScores(Roll roll)
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
        }
    }
}
