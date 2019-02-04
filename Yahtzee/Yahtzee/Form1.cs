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
        Roll roll;
        Score score;
        public int buttonPushCounter;
        public int tempTurnResult;

        public YahtzeeForm()
        {
            InitializeComponent();
            buttonPushCounter = 0;
            tempTurnResult = 0;
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

        private void OnesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(OnesCheck.Checked)
            {
                //FIXME: change a var in Scores to prohibit Ones from working
                OnesScore.Text = 
            }

        }

        private void TwosCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ThreesCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FoursCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FivesCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SixesCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ThreeOfAKindCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FourOfAKindCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FullHouseCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SmallStraightCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LargeStraightCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChanceCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YahtzeeCheck_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPushCounter++;
            if (buttonPushCounter < 3 && !holdDieA.Checked && !holdDieB.Checked 
                && !holdDieC.Checked && !holdDieD.Checked && !holdDieE.Checked)
            {
                //Bonus.Text?
                //TotalScore.Text
                RollButton.Text = "Roll again!";
            }
            else
            {
                RollButton.Text = "Out of rolls! Choose one empty combination on the list.";
                score.CalcScores(roll);
                displayScores(roll);
                buttonPushCounter = 0;
            }
        }

        private void holdDieA_CheckedChanged(object sender, EventArgs e)
        {
            if (holdDieA.Checked)
            {
                //FIXME: roll.getHolds(0, 1);
                this.DieA.Load("filename.jpg");
            }
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

        private void InstructionLabel_Click(object sender, EventArgs e)
        {

        }

        public void displayScores(Roll roll)
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

        public void ScoreClickedEntry()
        {
            if (OnesCheck.Checked)
            {
                tempTurnResult = score.onesScore;
            }
        }
    }
}
