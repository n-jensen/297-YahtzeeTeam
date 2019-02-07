namespace Yahtzee
{
    partial class YahtzeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YahtzeeForm));
            this.OnesCheck = new System.Windows.Forms.CheckBox();
            this.TwosCheck = new System.Windows.Forms.CheckBox();
            this.ThreesCheck = new System.Windows.Forms.CheckBox();
            this.FoursCheck = new System.Windows.Forms.CheckBox();
            this.FivesCheck = new System.Windows.Forms.CheckBox();
            this.SixesCheck = new System.Windows.Forms.CheckBox();
            this.ThreeOfAKindCheck = new System.Windows.Forms.CheckBox();
            this.FourOfAKindCheck = new System.Windows.Forms.CheckBox();
            this.FullHouseCheck = new System.Windows.Forms.CheckBox();
            this.SmallStraightCheck = new System.Windows.Forms.CheckBox();
            this.LargeStraightCheck = new System.Windows.Forms.CheckBox();
            this.ChanceCheck = new System.Windows.Forms.CheckBox();
            this.YahtzeeCheck = new System.Windows.Forms.CheckBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.TotalScoreLabel = new System.Windows.Forms.Label();
            this.OnesScore = new System.Windows.Forms.Label();
            this.TwosScore = new System.Windows.Forms.Label();
            this.ThreesScore = new System.Windows.Forms.Label();
            this.FoursScore = new System.Windows.Forms.Label();
            this.FivesScore = new System.Windows.Forms.Label();
            this.SixesScore = new System.Windows.Forms.Label();
            this.ThreeOfAKindScore = new System.Windows.Forms.Label();
            this.FourOfAKindScore = new System.Windows.Forms.Label();
            this.FullHouseScore = new System.Windows.Forms.Label();
            this.SmallStraightScore = new System.Windows.Forms.Label();
            this.LargeStraightScore = new System.Windows.Forms.Label();
            this.ChanceScore = new System.Windows.Forms.Label();
            this.YahtzeeScore = new System.Windows.Forms.Label();
            this.DieA = new System.Windows.Forms.PictureBox();
            this.DieB = new System.Windows.Forms.PictureBox();
            this.DieE = new System.Windows.Forms.PictureBox();
            this.DieD = new System.Windows.Forms.PictureBox();
            this.DieC = new System.Windows.Forms.PictureBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.holdDieA = new System.Windows.Forms.CheckBox();
            this.holdDieB = new System.Windows.Forms.CheckBox();
            this.holdDieC = new System.Windows.Forms.CheckBox();
            this.holdDieD = new System.Windows.Forms.CheckBox();
            this.holdDieE = new System.Windows.Forms.CheckBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.BonusCheck = new System.Windows.Forms.CheckBox();
            this.BonusScore = new System.Windows.Forms.Label();
            this.InstructionLabel2 = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DieA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieC)).BeginInit();
            this.SuspendLayout();
            // 
            // OnesCheck
            // 
            this.OnesCheck.AutoSize = true;
            this.OnesCheck.Location = new System.Drawing.Point(558, 33);
            this.OnesCheck.Name = "OnesCheck";
            this.OnesCheck.Size = new System.Drawing.Size(51, 17);
            this.OnesCheck.TabIndex = 0;
            this.OnesCheck.Text = "Ones";
            this.OnesCheck.UseVisualStyleBackColor = true;
            this.OnesCheck.CheckedChanged += new System.EventHandler(this.OnesCheck_CheckedChanged);
            // 
            // TwosCheck
            // 
            this.TwosCheck.AutoSize = true;
            this.TwosCheck.Location = new System.Drawing.Point(558, 52);
            this.TwosCheck.Name = "TwosCheck";
            this.TwosCheck.Size = new System.Drawing.Size(47, 17);
            this.TwosCheck.TabIndex = 1;
            this.TwosCheck.Text = "Two";
            this.TwosCheck.UseVisualStyleBackColor = true;
            this.TwosCheck.CheckedChanged += new System.EventHandler(this.TwosCheck_CheckedChanged);
            // 
            // ThreesCheck
            // 
            this.ThreesCheck.AutoSize = true;
            this.ThreesCheck.Location = new System.Drawing.Point(558, 75);
            this.ThreesCheck.Name = "ThreesCheck";
            this.ThreesCheck.Size = new System.Drawing.Size(59, 17);
            this.ThreesCheck.TabIndex = 2;
            this.ThreesCheck.Text = "Threes";
            this.ThreesCheck.UseVisualStyleBackColor = true;
            this.ThreesCheck.CheckedChanged += new System.EventHandler(this.ThreesCheck_CheckedChanged);
            // 
            // FoursCheck
            // 
            this.FoursCheck.AutoSize = true;
            this.FoursCheck.Location = new System.Drawing.Point(558, 98);
            this.FoursCheck.Name = "FoursCheck";
            this.FoursCheck.Size = new System.Drawing.Size(52, 17);
            this.FoursCheck.TabIndex = 3;
            this.FoursCheck.Text = "Fours";
            this.FoursCheck.UseVisualStyleBackColor = true;
            this.FoursCheck.CheckedChanged += new System.EventHandler(this.FoursCheck_CheckedChanged);
            // 
            // FivesCheck
            // 
            this.FivesCheck.AutoSize = true;
            this.FivesCheck.Location = new System.Drawing.Point(558, 121);
            this.FivesCheck.Name = "FivesCheck";
            this.FivesCheck.Size = new System.Drawing.Size(51, 17);
            this.FivesCheck.TabIndex = 4;
            this.FivesCheck.Text = "Fives";
            this.FivesCheck.UseVisualStyleBackColor = true;
            this.FivesCheck.CheckedChanged += new System.EventHandler(this.FivesCheck_CheckedChanged);
            // 
            // SixesCheck
            // 
            this.SixesCheck.AutoSize = true;
            this.SixesCheck.Location = new System.Drawing.Point(558, 144);
            this.SixesCheck.Name = "SixesCheck";
            this.SixesCheck.Size = new System.Drawing.Size(51, 17);
            this.SixesCheck.TabIndex = 5;
            this.SixesCheck.Text = "Sixes";
            this.SixesCheck.UseVisualStyleBackColor = true;
            this.SixesCheck.CheckedChanged += new System.EventHandler(this.SixesCheck_CheckedChanged);
            // 
            // ThreeOfAKindCheck
            // 
            this.ThreeOfAKindCheck.AutoSize = true;
            this.ThreeOfAKindCheck.Location = new System.Drawing.Point(558, 167);
            this.ThreeOfAKindCheck.Name = "ThreeOfAKindCheck";
            this.ThreeOfAKindCheck.Size = new System.Drawing.Size(99, 17);
            this.ThreeOfAKindCheck.TabIndex = 6;
            this.ThreeOfAKindCheck.Text = "Three of a Kind";
            this.ThreeOfAKindCheck.UseVisualStyleBackColor = true;
            this.ThreeOfAKindCheck.CheckedChanged += new System.EventHandler(this.ThreeOfAKindCheck_CheckedChanged);
            // 
            // FourOfAKindCheck
            // 
            this.FourOfAKindCheck.AutoSize = true;
            this.FourOfAKindCheck.Location = new System.Drawing.Point(558, 190);
            this.FourOfAKindCheck.Name = "FourOfAKindCheck";
            this.FourOfAKindCheck.Size = new System.Drawing.Size(92, 17);
            this.FourOfAKindCheck.TabIndex = 7;
            this.FourOfAKindCheck.Text = "Four of a Kind";
            this.FourOfAKindCheck.UseVisualStyleBackColor = true;
            this.FourOfAKindCheck.CheckedChanged += new System.EventHandler(this.FourOfAKindCheck_CheckedChanged);
            // 
            // FullHouseCheck
            // 
            this.FullHouseCheck.AutoSize = true;
            this.FullHouseCheck.Location = new System.Drawing.Point(558, 213);
            this.FullHouseCheck.Name = "FullHouseCheck";
            this.FullHouseCheck.Size = new System.Drawing.Size(76, 17);
            this.FullHouseCheck.TabIndex = 8;
            this.FullHouseCheck.Text = "Full House";
            this.FullHouseCheck.UseVisualStyleBackColor = true;
            this.FullHouseCheck.CheckedChanged += new System.EventHandler(this.FullHouseCheck_CheckedChanged);
            // 
            // SmallStraightCheck
            // 
            this.SmallStraightCheck.AutoSize = true;
            this.SmallStraightCheck.Location = new System.Drawing.Point(558, 236);
            this.SmallStraightCheck.Name = "SmallStraightCheck";
            this.SmallStraightCheck.Size = new System.Drawing.Size(90, 17);
            this.SmallStraightCheck.TabIndex = 9;
            this.SmallStraightCheck.Text = "Small Straight";
            this.SmallStraightCheck.UseVisualStyleBackColor = true;
            this.SmallStraightCheck.CheckedChanged += new System.EventHandler(this.SmallStraightCheck_CheckedChanged);
            // 
            // LargeStraightCheck
            // 
            this.LargeStraightCheck.AutoSize = true;
            this.LargeStraightCheck.Location = new System.Drawing.Point(558, 259);
            this.LargeStraightCheck.Name = "LargeStraightCheck";
            this.LargeStraightCheck.Size = new System.Drawing.Size(92, 17);
            this.LargeStraightCheck.TabIndex = 10;
            this.LargeStraightCheck.Text = "Large Straight";
            this.LargeStraightCheck.UseVisualStyleBackColor = true;
            this.LargeStraightCheck.CheckedChanged += new System.EventHandler(this.LargeStraightCheck_CheckedChanged);
            // 
            // ChanceCheck
            // 
            this.ChanceCheck.AutoSize = true;
            this.ChanceCheck.Location = new System.Drawing.Point(558, 282);
            this.ChanceCheck.Name = "ChanceCheck";
            this.ChanceCheck.Size = new System.Drawing.Size(63, 17);
            this.ChanceCheck.TabIndex = 11;
            this.ChanceCheck.Text = "Chance";
            this.ChanceCheck.UseVisualStyleBackColor = true;
            this.ChanceCheck.CheckedChanged += new System.EventHandler(this.ChanceCheck_CheckedChanged);
            // 
            // YahtzeeCheck
            // 
            this.YahtzeeCheck.AutoSize = true;
            this.YahtzeeCheck.Location = new System.Drawing.Point(558, 305);
            this.YahtzeeCheck.Name = "YahtzeeCheck";
            this.YahtzeeCheck.Size = new System.Drawing.Size(65, 17);
            this.YahtzeeCheck.TabIndex = 12;
            this.YahtzeeCheck.Text = "Yahztee";
            this.YahtzeeCheck.UseVisualStyleBackColor = true;
            this.YahtzeeCheck.CheckedChanged += new System.EventHandler(this.YahtzeeCheck_CheckedChanged);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(636, 37);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(34, 13);
            this.SumLabel.TabIndex = 14;
            this.SumLabel.Text = "Sum: ";
            this.SumLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalScoreLabel
            // 
            this.TotalScoreLabel.AutoSize = true;
            this.TotalScoreLabel.Location = new System.Drawing.Point(636, 70);
            this.TotalScoreLabel.Name = "TotalScoreLabel";
            this.TotalScoreLabel.Size = new System.Drawing.Size(85, 13);
            this.TotalScoreLabel.TabIndex = 16;
            this.TotalScoreLabel.Text = "TOTAL SCORE:";
            this.TotalScoreLabel.Click += new System.EventHandler(this.TotalScoreLabel_Click);
            // 
            // OnesScore
            // 
            this.OnesScore.AutoSize = true;
            this.OnesScore.Location = new System.Drawing.Point(539, 34);
            this.OnesScore.Name = "OnesScore";
            this.OnesScore.Size = new System.Drawing.Size(13, 13);
            this.OnesScore.TabIndex = 17;
            this.OnesScore.Text = "0";
            this.OnesScore.Click += new System.EventHandler(this.OnesScore_Click);
            // 
            // TwosScore
            // 
            this.TwosScore.AutoSize = true;
            this.TwosScore.Location = new System.Drawing.Point(539, 53);
            this.TwosScore.Name = "TwosScore";
            this.TwosScore.Size = new System.Drawing.Size(13, 13);
            this.TwosScore.TabIndex = 18;
            this.TwosScore.Text = "0";
            this.TwosScore.Click += new System.EventHandler(this.TwosScore_Click);
            // 
            // ThreesScore
            // 
            this.ThreesScore.AutoSize = true;
            this.ThreesScore.Location = new System.Drawing.Point(539, 76);
            this.ThreesScore.Name = "ThreesScore";
            this.ThreesScore.Size = new System.Drawing.Size(13, 13);
            this.ThreesScore.TabIndex = 19;
            this.ThreesScore.Text = "0";
            this.ThreesScore.Click += new System.EventHandler(this.ThreesScore_Click);
            // 
            // FoursScore
            // 
            this.FoursScore.AutoSize = true;
            this.FoursScore.Location = new System.Drawing.Point(539, 99);
            this.FoursScore.Name = "FoursScore";
            this.FoursScore.Size = new System.Drawing.Size(13, 13);
            this.FoursScore.TabIndex = 20;
            this.FoursScore.Text = "0";
            this.FoursScore.Click += new System.EventHandler(this.FoursScore_Click);
            // 
            // FivesScore
            // 
            this.FivesScore.AutoSize = true;
            this.FivesScore.Location = new System.Drawing.Point(539, 122);
            this.FivesScore.Name = "FivesScore";
            this.FivesScore.Size = new System.Drawing.Size(13, 13);
            this.FivesScore.TabIndex = 21;
            this.FivesScore.Text = "0";
            this.FivesScore.Click += new System.EventHandler(this.FivesScores_Click);
            // 
            // SixesScore
            // 
            this.SixesScore.AutoSize = true;
            this.SixesScore.Location = new System.Drawing.Point(539, 145);
            this.SixesScore.Name = "SixesScore";
            this.SixesScore.Size = new System.Drawing.Size(13, 13);
            this.SixesScore.TabIndex = 22;
            this.SixesScore.Text = "0";
            this.SixesScore.Click += new System.EventHandler(this.SixesScore_Click);
            // 
            // ThreeOfAKindScore
            // 
            this.ThreeOfAKindScore.AutoSize = true;
            this.ThreeOfAKindScore.Location = new System.Drawing.Point(539, 167);
            this.ThreeOfAKindScore.Name = "ThreeOfAKindScore";
            this.ThreeOfAKindScore.Size = new System.Drawing.Size(13, 13);
            this.ThreeOfAKindScore.TabIndex = 23;
            this.ThreeOfAKindScore.Text = "0";
            this.ThreeOfAKindScore.Click += new System.EventHandler(this.ThreeOfAKindScore_Click);
            // 
            // FourOfAKindScore
            // 
            this.FourOfAKindScore.AutoSize = true;
            this.FourOfAKindScore.Location = new System.Drawing.Point(539, 190);
            this.FourOfAKindScore.Name = "FourOfAKindScore";
            this.FourOfAKindScore.Size = new System.Drawing.Size(13, 13);
            this.FourOfAKindScore.TabIndex = 24;
            this.FourOfAKindScore.Text = "0";
            this.FourOfAKindScore.Click += new System.EventHandler(this.FourOfAKindScore_Click);
            // 
            // FullHouseScore
            // 
            this.FullHouseScore.AutoSize = true;
            this.FullHouseScore.Location = new System.Drawing.Point(539, 213);
            this.FullHouseScore.Name = "FullHouseScore";
            this.FullHouseScore.Size = new System.Drawing.Size(13, 13);
            this.FullHouseScore.TabIndex = 25;
            this.FullHouseScore.Text = "0";
            this.FullHouseScore.Click += new System.EventHandler(this.FullHouseScore_Click);
            // 
            // SmallStraightScore
            // 
            this.SmallStraightScore.AutoSize = true;
            this.SmallStraightScore.Location = new System.Drawing.Point(539, 237);
            this.SmallStraightScore.Name = "SmallStraightScore";
            this.SmallStraightScore.Size = new System.Drawing.Size(13, 13);
            this.SmallStraightScore.TabIndex = 26;
            this.SmallStraightScore.Text = "0";
            this.SmallStraightScore.Click += new System.EventHandler(this.SmallStraightScore_Click);
            // 
            // LargeStraightScore
            // 
            this.LargeStraightScore.AutoSize = true;
            this.LargeStraightScore.Location = new System.Drawing.Point(539, 260);
            this.LargeStraightScore.Name = "LargeStraightScore";
            this.LargeStraightScore.Size = new System.Drawing.Size(13, 13);
            this.LargeStraightScore.TabIndex = 27;
            this.LargeStraightScore.Text = "0";
            this.LargeStraightScore.Click += new System.EventHandler(this.LargeStraightScore_Click);
            // 
            // ChanceScore
            // 
            this.ChanceScore.AutoSize = true;
            this.ChanceScore.Location = new System.Drawing.Point(539, 283);
            this.ChanceScore.Name = "ChanceScore";
            this.ChanceScore.Size = new System.Drawing.Size(13, 13);
            this.ChanceScore.TabIndex = 28;
            this.ChanceScore.Text = "0";
            this.ChanceScore.Click += new System.EventHandler(this.ChanceScore_Click);
            // 
            // YahtzeeScore
            // 
            this.YahtzeeScore.AutoSize = true;
            this.YahtzeeScore.Location = new System.Drawing.Point(539, 306);
            this.YahtzeeScore.Name = "YahtzeeScore";
            this.YahtzeeScore.Size = new System.Drawing.Size(13, 13);
            this.YahtzeeScore.TabIndex = 29;
            this.YahtzeeScore.Text = "0";
            this.YahtzeeScore.Click += new System.EventHandler(this.YahtzeeScore_Click);
            // 
            // DieA
            // 
            this.DieA.Image = ((System.Drawing.Image)(resources.GetObject("DieA.Image")));
            this.DieA.Location = new System.Drawing.Point(12, 31);
            this.DieA.Name = "DieA";
            this.DieA.Size = new System.Drawing.Size(100, 101);
            this.DieA.TabIndex = 30;
            this.DieA.TabStop = false;
            this.DieA.Click += new System.EventHandler(this.DieA_Click);
            // 
            // DieB
            // 
            this.DieB.Image = ((System.Drawing.Image)(resources.GetObject("DieB.Image")));
            this.DieB.Location = new System.Drawing.Point(118, 31);
            this.DieB.Name = "DieB";
            this.DieB.Size = new System.Drawing.Size(96, 100);
            this.DieB.TabIndex = 31;
            this.DieB.TabStop = false;
            this.DieB.Click += new System.EventHandler(this.DieB_Click);
            // 
            // DieE
            // 
            this.DieE.Image = ((System.Drawing.Image)(resources.GetObject("DieE.Image")));
            this.DieE.Location = new System.Drawing.Point(424, 31);
            this.DieE.Name = "DieE";
            this.DieE.Size = new System.Drawing.Size(96, 100);
            this.DieE.TabIndex = 32;
            this.DieE.TabStop = false;
            this.DieE.Click += new System.EventHandler(this.DieE_Click);
            // 
            // DieD
            // 
            this.DieD.Image = ((System.Drawing.Image)(resources.GetObject("DieD.Image")));
            this.DieD.Location = new System.Drawing.Point(322, 31);
            this.DieD.Name = "DieD";
            this.DieD.Size = new System.Drawing.Size(96, 100);
            this.DieD.TabIndex = 33;
            this.DieD.TabStop = false;
            this.DieD.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // DieC
            // 
            this.DieC.Image = ((System.Drawing.Image)(resources.GetObject("DieC.Image")));
            this.DieC.Location = new System.Drawing.Point(220, 31);
            this.DieC.Name = "DieC";
            this.DieC.Size = new System.Drawing.Size(96, 100);
            this.DieC.TabIndex = 35;
            this.DieC.TabStop = false;
            this.DieC.Click += new System.EventHandler(this.DieC_Click);
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(118, 200);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(300, 99);
            this.RollButton.TabIndex = 36;
            this.RollButton.Text = "Roll to Start!";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // holdDieA
            // 
            this.holdDieA.AutoSize = true;
            this.holdDieA.Location = new System.Drawing.Point(54, 138);
            this.holdDieA.Name = "holdDieA";
            this.holdDieA.Size = new System.Drawing.Size(15, 14);
            this.holdDieA.TabIndex = 37;
            this.holdDieA.UseVisualStyleBackColor = true;
            this.holdDieA.CheckedChanged += new System.EventHandler(this.holdDieA_CheckedChanged);
            // 
            // holdDieB
            // 
            this.holdDieB.AutoSize = true;
            this.holdDieB.Location = new System.Drawing.Point(161, 137);
            this.holdDieB.Name = "holdDieB";
            this.holdDieB.Size = new System.Drawing.Size(15, 14);
            this.holdDieB.TabIndex = 38;
            this.holdDieB.UseVisualStyleBackColor = true;
            this.holdDieB.CheckedChanged += new System.EventHandler(this.holdDieB_CheckedChanged);
            // 
            // holdDieC
            // 
            this.holdDieC.AutoSize = true;
            this.holdDieC.Location = new System.Drawing.Point(264, 137);
            this.holdDieC.Name = "holdDieC";
            this.holdDieC.Size = new System.Drawing.Size(15, 14);
            this.holdDieC.TabIndex = 39;
            this.holdDieC.UseVisualStyleBackColor = true;
            this.holdDieC.CheckedChanged += new System.EventHandler(this.holdDieC_CheckedChanged);
            // 
            // holdDieD
            // 
            this.holdDieD.AutoSize = true;
            this.holdDieD.Location = new System.Drawing.Point(366, 137);
            this.holdDieD.Name = "holdDieD";
            this.holdDieD.Size = new System.Drawing.Size(15, 14);
            this.holdDieD.TabIndex = 40;
            this.holdDieD.UseVisualStyleBackColor = true;
            this.holdDieD.CheckedChanged += new System.EventHandler(this.holdDieD_CheckedChanged);
            // 
            // holdDieE
            // 
            this.holdDieE.AutoSize = true;
            this.holdDieE.Location = new System.Drawing.Point(467, 137);
            this.holdDieE.Name = "holdDieE";
            this.holdDieE.Size = new System.Drawing.Size(15, 14);
            this.holdDieE.TabIndex = 41;
            this.holdDieE.UseVisualStyleBackColor = true;
            this.holdDieE.CheckedChanged += new System.EventHandler(this.holdDieE_CheckedChanged);
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(22, 349);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(291, 13);
            this.InstructionLabel.TabIndex = 42;
            this.InstructionLabel.Text = "Press the button to roll! You get a max of three rolls per turn. ";
            this.InstructionLabel.Click += new System.EventHandler(this.InstructionLabel_Click);
            // 
            // BonusCheck
            // 
            this.BonusCheck.AutoSize = true;
            this.BonusCheck.Location = new System.Drawing.Point(558, 328);
            this.BonusCheck.Name = "BonusCheck";
            this.BonusCheck.Size = new System.Drawing.Size(56, 17);
            this.BonusCheck.TabIndex = 43;
            this.BonusCheck.Text = "Bonus";
            this.BonusCheck.UseVisualStyleBackColor = true;
            this.BonusCheck.CheckedChanged += new System.EventHandler(this.BonusCheck_CheckedChanged);
            // 
            // BonusScore
            // 
            this.BonusScore.AutoSize = true;
            this.BonusScore.Location = new System.Drawing.Point(539, 329);
            this.BonusScore.Name = "BonusScore";
            this.BonusScore.Size = new System.Drawing.Size(13, 13);
            this.BonusScore.TabIndex = 44;
            this.BonusScore.Text = "0";
            // 
            // InstructionLabel2
            // 
            this.InstructionLabel2.AutoSize = true;
            this.InstructionLabel2.Location = new System.Drawing.Point(22, 371);
            this.InstructionLabel2.Name = "InstructionLabel2";
            this.InstructionLabel2.Size = new System.Drawing.Size(393, 13);
            this.InstructionLabel2.TabIndex = 45;
            this.InstructionLabel2.Text = "Check the boxes to hold a dice. Check all dice and press the button to end a turn" +
    ".";
            this.InstructionLabel2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(528, 351);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(168, 43);
            this.EndButton.TabIndex = 46;
            this.EndButton.Text = "Press to end game if no moves are left. :(";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // YahtzeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.InstructionLabel2);
            this.Controls.Add(this.BonusScore);
            this.Controls.Add(this.BonusCheck);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.holdDieE);
            this.Controls.Add(this.holdDieD);
            this.Controls.Add(this.holdDieC);
            this.Controls.Add(this.holdDieB);
            this.Controls.Add(this.holdDieA);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.DieC);
            this.Controls.Add(this.DieD);
            this.Controls.Add(this.DieE);
            this.Controls.Add(this.DieB);
            this.Controls.Add(this.DieA);
            this.Controls.Add(this.YahtzeeScore);
            this.Controls.Add(this.ChanceScore);
            this.Controls.Add(this.LargeStraightScore);
            this.Controls.Add(this.SmallStraightScore);
            this.Controls.Add(this.FullHouseScore);
            this.Controls.Add(this.FourOfAKindScore);
            this.Controls.Add(this.ThreeOfAKindScore);
            this.Controls.Add(this.SixesScore);
            this.Controls.Add(this.FivesScore);
            this.Controls.Add(this.FoursScore);
            this.Controls.Add(this.ThreesScore);
            this.Controls.Add(this.TwosScore);
            this.Controls.Add(this.OnesScore);
            this.Controls.Add(this.TotalScoreLabel);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.YahtzeeCheck);
            this.Controls.Add(this.ChanceCheck);
            this.Controls.Add(this.LargeStraightCheck);
            this.Controls.Add(this.SmallStraightCheck);
            this.Controls.Add(this.FullHouseCheck);
            this.Controls.Add(this.FourOfAKindCheck);
            this.Controls.Add(this.ThreeOfAKindCheck);
            this.Controls.Add(this.SixesCheck);
            this.Controls.Add(this.FivesCheck);
            this.Controls.Add(this.FoursCheck);
            this.Controls.Add(this.ThreesCheck);
            this.Controls.Add(this.TwosCheck);
            this.Controls.Add(this.OnesCheck);
            this.Name = "YahtzeeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.YahtzeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DieA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox OnesCheck;
        private System.Windows.Forms.CheckBox TwosCheck;
        private System.Windows.Forms.CheckBox ThreesCheck;
        private System.Windows.Forms.CheckBox FoursCheck;
        private System.Windows.Forms.CheckBox FivesCheck;
        private System.Windows.Forms.CheckBox SixesCheck;
        private System.Windows.Forms.CheckBox ThreeOfAKindCheck;
        private System.Windows.Forms.CheckBox FourOfAKindCheck;
        private System.Windows.Forms.CheckBox FullHouseCheck;
        private System.Windows.Forms.CheckBox SmallStraightCheck;
        private System.Windows.Forms.CheckBox LargeStraightCheck;
        private System.Windows.Forms.CheckBox ChanceCheck;
        private System.Windows.Forms.CheckBox YahtzeeCheck;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label TotalScoreLabel;
        private System.Windows.Forms.Label OnesScore;
        private System.Windows.Forms.Label TwosScore;
        private System.Windows.Forms.Label ThreesScore;
        private System.Windows.Forms.Label FoursScore;
        private System.Windows.Forms.Label FivesScore;
        private System.Windows.Forms.Label SixesScore;
        private System.Windows.Forms.Label ThreeOfAKindScore;
        private System.Windows.Forms.Label FourOfAKindScore;
        private System.Windows.Forms.Label FullHouseScore;
        private System.Windows.Forms.Label SmallStraightScore;
        private System.Windows.Forms.Label LargeStraightScore;
        private System.Windows.Forms.Label ChanceScore;
        private System.Windows.Forms.Label YahtzeeScore;
        private System.Windows.Forms.PictureBox DieA;
        private System.Windows.Forms.PictureBox DieB;
        private System.Windows.Forms.PictureBox DieE;
        private System.Windows.Forms.PictureBox DieD;
        private System.Windows.Forms.PictureBox DieC;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.CheckBox holdDieA;
        private System.Windows.Forms.CheckBox holdDieB;
        private System.Windows.Forms.CheckBox holdDieC;
        private System.Windows.Forms.CheckBox holdDieD;
        private System.Windows.Forms.CheckBox holdDieE;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.CheckBox BonusCheck;
        private System.Windows.Forms.Label BonusScore;
        private System.Windows.Forms.Label InstructionLabel2;
        private System.Windows.Forms.Button EndButton;
    }
}

