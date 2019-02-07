using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class YahtzeeForm : Form
    {
        //FIXME: Why are all these null? How do I assign these objects/instances
        Roll roll;
        Score score;
        

        public int tempTurnResult;
        public int buttonPushCounter;
        public int optionCheckCounter = 13; //14 with a bonus

        public YahtzeeForm()
        {
            InitializeComponent();
            buttonPushCounter = 3;
            tempTurnResult = 0;
            roll = new Roll(new RandomWrapper());
            score = new Score(roll);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TotalScoreLabel_Click(object sender, EventArgs e)
        {

        }

        
        private void YahtzeeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void DieA_Click(object sender, EventArgs e)
        {

        }

        private void DieB_Click(object sender, EventArgs e)
        {

        }

        private void DieC_Click(object sender, EventArgs e)
        {

        }

        private void DieE_Click(object sender, EventArgs e)
        {

        }

       
        private void holdDieA_CheckedChanged(object sender, EventArgs e)
        {
            roll.HoldDice[0] = 1;
        }

        private void holdDieB_CheckedChanged(object sender, EventArgs e)
        {
            roll.HoldDice[1] = 1;
        }

        private void holdDieC_CheckedChanged(object sender, EventArgs e)
        {
            roll.HoldDice[2] = 1;
        }

        private void holdDieD_CheckedChanged(object sender, EventArgs e)
        {
            roll.HoldDice[3] = 1;
        }

        private void holdDieE_CheckedChanged(object sender, EventArgs e)
        {
            roll.HoldDice[4] = 1;
        }



        private void OnesScore_Click(object sender, EventArgs e)
        {
            
        }

        private void TwosScore_Click(object sender, EventArgs e)
        {

        }

        private void ThreesScore_Click(object sender, EventArgs e)
        {

        }

        private void FoursScore_Click(object sender, EventArgs e)
        {

        }

        private void FivesScores_Click(object sender, EventArgs e)
        {

        }

        private void SixesScore_Click(object sender, EventArgs e)
        {

        }

        private void ThreeOfAKindScore_Click(object sender, EventArgs e)
        {

        }

        private void FourOfAKindScore_Click(object sender, EventArgs e)
        {

        }

        private void FullHouseScore_Click(object sender, EventArgs e)
        {

        }

        private void SmallStraightScore_Click(object sender, EventArgs e)
        {

        }

        private void LargeStraightScore_Click(object sender, EventArgs e)
        {

        }

        private void ChanceScore_Click(object sender, EventArgs e)
        {

        }

        private void YahtzeeScore_Click(object sender, EventArgs e)
        {

        }


        private void OnesCheck_CheckedChanged(object sender, EventArgs e)
        {
            OnesCheck.Enabled = false;
            score.TotalScore(score.onesScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
            optionCheckCounter--;
        }

        private void TwosCheck_CheckedChanged(object sender, EventArgs e)
        {
            TwosCheck.Enabled = false;
            score.TotalScore(score.twosScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void ThreesCheck_CheckedChanged(object sender, EventArgs e)
        {
            ThreesCheck.Enabled = false;
            score.TotalScore(score.threesScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void FoursCheck_CheckedChanged(object sender, EventArgs e)
        {
            FoursCheck.Enabled = false;
            score.TotalScore(score.foursScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void FivesCheck_CheckedChanged(object sender, EventArgs e)
        {
            FivesCheck.Enabled = false;
            score.TotalScore(score.fivesScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void SixesCheck_CheckedChanged(object sender, EventArgs e)
        {
            SixesCheck.Enabled = false;
            score.TotalScore(score.sixesScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void ThreeOfAKindCheck_CheckedChanged(object sender, EventArgs e)
        {
            ThreeOfAKindCheck.Enabled = false;
            score.TotalScore(score.threeKindScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void FourOfAKindCheck_CheckedChanged(object sender, EventArgs e)
        {
            FourOfAKindCheck.Enabled = false;
            score.TotalScore(score.fourKindScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void FullHouseCheck_CheckedChanged(object sender, EventArgs e)
        {
            FullHouseCheck.Enabled = false;
            score.TotalScore(score.fullHouseScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void SmallStraightCheck_CheckedChanged(object sender, EventArgs e)
        {
            SmallStraightCheck.Enabled = false;
            score.TotalScore(score.smallStraightScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void LargeStraightCheck_CheckedChanged(object sender, EventArgs e)
        {
            LargeStraightCheck.Enabled = false;
            score.TotalScore(score.largeStraightScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void ChanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            ChanceCheck.Enabled = false;
            score.TotalScore(score.chanceScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void YahtzeeCheck_CheckedChanged(object sender, EventArgs e)
        {
            YahtzeeCheck.Enabled = false;
            score.TotalScore(score.yahtzeeScore);
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }

        private void BonusCheck_CheckedChanged(object sender, EventArgs e)
        {
            BonusCheck.Enabled = false;
            score.TotalScore(score.bonusScore);
            optionCheckCounter++;
            TotalScoreLabel.Text = "Total Score: " + Convert.ToString(score.totalScore);
        }


        private void InstructionLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void DicePictureAssignments(int dieValue, PictureBox DieX)
        {
            if (dieValue == 1)
                DieX.Load(@"C:\Users\Noel\source\VS17Projects\Yahtzee\Dice1.jpg");
            else if (dieValue == 2)
                DieX.Load(@"C:\Users\Noel\source\VS17Projects\Yahtzee\Dice2.jpg");
            else if (dieValue == 3)
                DieX.Load(@"C:\Users\Noel\source\VS17Projects\Yahtzee\Dice3.jpg");
            else if (dieValue == 4)
                DieX.Load(@"C:\Users\Noel\source\VS17Projects\Yahtzee\Dice4.jpg");
            else if (dieValue == 5)
                DieX.Load(@"C:\Users\Noel\source\VS17Projects\Yahtzee\Dice5.jpg");
            else if (dieValue == 6)
                DieX.Load(@"C:\Users\Noel\source\VS17Projects\Yahtzee\Dice6.jpg");

        }

        private bool checkAllHolds()
        {
            int howManyHolds = 0;
            for(int index = 0; index < 5; index++)
            {
                if(roll.HoldDice[index] == 1)
                {
                    howManyHolds++;
                }
            }
            if (howManyHolds == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (optionCheckCounter > 0)
            {
                if (buttonPushCounter > 0)
                {
                    KeepRolling();
                    buttonPushCounter--;

                    score.fillTempDiceValues(roll);
                    score.CalcScores(roll);
                    GetScoreNums(score);

                    SumLabel.Text = "Sum: " + score.sum;
                    RollButton.Text = "Roll again!\nRolls remaining: " + (buttonPushCounter);
                }
                else if (buttonPushCounter == 0)
                {
                    RollButton.Text = "Out of rolls! Choose one empty combination on the list.";

                    score.fillTempDiceValues(roll);
                    score.CalcScores(roll);
                    GetScoreNums(score);

                    TotalScoreLabel.Text = "Total Score: " + score.totalScore;
                    SumLabel.Text = "Sum: " + score.sum;
                    buttonPushCounter = 3;
                }
            }
            if(optionCheckCounter == 0)
            {
                InstructionLabel.Text = "";
                InstructionLabel2.Text = "";
                RollButton.Text = "Thanks for playing!\nTotal Score is: " + score.totalScore;
                RollButton.Enabled = false;
            }
        }

        private void KeepRolling()
        {
            
            RollButton.Text = "Roll again!";
            roll.RollResults();  //FIXME:Fix roll functions

            DicePictureAssignments(roll.DiceValues[0], DieA);
            DicePictureAssignments(roll.DiceValues[1], DieB);
            DicePictureAssignments(roll.DiceValues[2], DieC);
            DicePictureAssignments(roll.DiceValues[3], DieD);
            DicePictureAssignments(roll.DiceValues[4], DieE);
        }

        private void GetScoreNums(Score score)
        {
            OnesScore.Text = Convert.ToString(score.onesScore);
            TwosScore.Text = Convert.ToString(score.twosScore);
            ThreesScore.Text = Convert.ToString(score.threesScore);
            FoursScore.Text = Convert.ToString(score.foursScore);
            FivesScore.Text = Convert.ToString(score.fivesScore);
            SixesScore.Text = Convert.ToString(score.sixesScore);

            ThreeOfAKindScore.Text = Convert.ToString(score.threeKindScore);
            FourOfAKindScore.Text = Convert.ToString(score.fourKindScore);
            FullHouseScore.Text = Convert.ToString(score.fullHouseScore);
            SmallStraightScore.Text = Convert.ToString(score.smallStraightScore);
            LargeStraightScore.Text = Convert.ToString(score.largeStraightScore);
            ChanceScore.Text = Convert.ToString(score.chanceScore);
            YahtzeeScore.Text = Convert.ToString(score.yahtzeeScore);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InstructionLabel.Text = "";
            InstructionLabel2.Text = "";
            RollButton.Text = "Thanks for playing!\nTotal Score is: " + score.totalScore;
            RollButton.Enabled = false;
            EndButton.Enabled = false;
        }
    }
}
