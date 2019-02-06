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
            buttonPushCounter = 0;
            tempTurnResult = 0;
            this.roll = roll;
            this.score = score;
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
            
        }

        private void holdDieB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void holdDieC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void holdDieD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void holdDieE_CheckedChanged(object sender, EventArgs e)
        {

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
        }

        private void TwosCheck_CheckedChanged(object sender, EventArgs e)
        {
            TwosCheck.Enabled = false;
            score.TotalScore(score.twosScore);
        }

        private void ThreesCheck_CheckedChanged(object sender, EventArgs e)
        {
            ThreesCheck.Enabled = false;
            score.TotalScore(score.threesScore);
        }

        private void FoursCheck_CheckedChanged(object sender, EventArgs e)
        {
            FoursCheck.Enabled = false;
            score.TotalScore(score.foursScore);
        }

        private void FivesCheck_CheckedChanged(object sender, EventArgs e)
        {
            FivesCheck.Enabled = false;
            score.TotalScore(score.fivesScore);
        }

        private void SixesCheck_CheckedChanged(object sender, EventArgs e)
        {
            SixesCheck.Enabled = false;
            score.TotalScore(score.sixesScore);
        }

        private void ThreeOfAKindCheck_CheckedChanged(object sender, EventArgs e)
        {
            ThreeOfAKindCheck.Enabled = false;
            score.TotalScore(score.threeKindScore);
        }

        private void FourOfAKindCheck_CheckedChanged(object sender, EventArgs e)
        {
            FourOfAKindCheck.Enabled = false;
            score.TotalScore(score.fourKindScore);
        }

        private void FullHouseCheck_CheckedChanged(object sender, EventArgs e)
        {
            FullHouseCheck.Enabled = false;
            score.TotalScore(score.fullHouseScore);
        }

        private void SmallStraightCheck_CheckedChanged(object sender, EventArgs e)
        {
            SmallStraightCheck.Enabled = false;
            score.TotalScore(score.smallStraightScore);
        }

        private void LargeStraightCheck_CheckedChanged(object sender, EventArgs e)
        {
            LargeStraightCheck.Enabled = false;
            score.TotalScore(score.largeStraightScore);
        }

        private void ChanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            ChanceCheck.Enabled = false;
            score.TotalScore(score.chanceScore);
        }

        private void YahtzeeCheck_CheckedChanged(object sender, EventArgs e)
        {
            YahtzeeCheck.Enabled = false;
            score.TotalScore(score.yahtzeeScore);
        }

        private void BonusCheck_CheckedChanged(object sender, EventArgs e)
        {
            BonusCheck.Enabled = false;
            score.TotalScore(score.bonusScore);
            optionCheckCounter++;
        }


        private void InstructionLabel_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            while (optionCheckCounter > 0)
            {
                if (buttonPushCounter < 3)
                {
                    KeepRolling();
                }
                else
                {
                    GetScores(score);
                }
                optionCheckCounter--;
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

            buttonPushCounter++;
        }

        private void GetScores(Score score)
        {
            RollButton.Text = "Out of rolls! Choose one empty combination on the list.";
            ChooseCombination();
            //FIXME: move? here, it resets to 0 the ones that weren't chosen before

            //Check if scores == to zero, in case it has already been chosen and has an assigned value
            if (score.onesScore == 0)
            {
                score.Ones();
                OnesScore.Text = Convert.ToString(score.onesScore);
            }
            if (score.twosScore == 0)
            {
                score.Twos();
                TwosScore.Text = Convert.ToString(score.twosScore);
            }
            if (score.threesScore == 0)
            {
                score.Threes();
                ThreesScore.Text = Convert.ToString(score.threesScore);
            }
            if (score.foursScore == 0)
            {
                score.Fours();
                FoursScore.Text = Convert.ToString(score.foursScore);
            }
            if (score.fivesScore == 0)
            {
                score.Fives();
                FivesScore.Text = Convert.ToString(score.fivesScore);
            }
            if (score.sixesScore == 0)
            {
                score.Sixes();
                SixesScore.Text = Convert.ToString(score.sixesScore);
            }

            if (score.threeKindScore == 0)
            {
                score.ThreeOfAKind();
                ThreeOfAKindScore.Text = Convert.ToString(score.threeKindScore);
            }
            if (score.fourKindScore == 0)
            {
                score.FourOfAKind();
                FourOfAKindScore.Text = Convert.ToString(score.fourKindScore);
            }
            if (score.fullHouseScore == 0)
            {
                score.FullHouse();
                FullHouseScore.Text = Convert.ToString(score.fullHouseScore);
            }
            if (score.smallStraightScore == 0)
            {
                score.SmallStraight();
                SmallStraightScore.Text = Convert.ToString(score.smallStraightScore);
            }
            if (score.largeStraightScore == 0)
            {
                score.LargeStraight();
                LargeStraightScore.Text = Convert.ToString(score.largeStraightScore);
            }
            if (score.chanceScore == 0)
            {
                score.Chance();
                ChanceScore.Text = Convert.ToString(score.chanceScore);
            }
            if (score.yahtzeeScore == 0)
            {
                score.YahtzeeCombo();
                YahtzeeScore.Text = Convert.ToString(score.yahtzeeScore);
            }
            TotalScoreLabel.Text = "Total Score: " + score.totalScore;
            buttonPushCounter = 0;
        }

        public void ChooseCombination()
        {
            //If the box is not checked, reset its corresponding score to zero
            //If the box IS checked, this is handled in the check functions
            //FIXME: Can i add these to their corresponding action functions?
            if (!OnesCheck.Checked)
            {
                score.onesScore = 0;
            }
            if (!TwosCheck.Checked)
            {
                score.twosScore = 0;
            }            
            if (!ThreesCheck.Checked)
            {
                score.threesScore = 0;
            }
            if (!FoursCheck.Checked)
            {
                score.foursScore = 0;
            }
            if (!FivesCheck.Checked)
            {
                score.fivesScore = 0;
            }
            if (!SixesCheck.Checked)
            {
                score.sixesScore = 0;
            }
            if (!ThreeOfAKindCheck.Checked)
            {
                score.threeKindScore = 0;
            }
            if (!FourOfAKindCheck.Checked)
            {
                score.fourKindScore = 0;
            }
            if (!FullHouseCheck.Checked)
            {
                score.fullHouseScore = 0;
            }
            if (!SmallStraightCheck.Checked)
            {
                score.smallStraightScore = 0;
            }
            if (!LargeStraightCheck.Checked)
            {
                score.largeStraightScore = 0;
            }
            if (!ChanceCheck.Checked)
            {
                score.chanceScore = 0;
            }
            if (!YahtzeeCheck.Checked)
            {
                score.yahtzeeScore = 0;
            }
        }

    }
}
