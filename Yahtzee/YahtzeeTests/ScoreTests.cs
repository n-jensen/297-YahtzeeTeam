using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Tests
{
    [TestClass()]
    public class ScoreTests
    {
      
        [TestMethod()]
        public void sumTest()
        {
            //Arrange
            int[] givenArray = { 1, 6, 1, 4, 6 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedSum = 18;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedSum, score.sum);
        }

        [TestMethod()]
        public void bonusScoreTest()
        {
            //Arrange
            int[] givenArray = { 1, 1, 1, 1, 1 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            score.yahtzeeScore = 50;
            int expectedBonus = 50;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedBonus, score.bonusScore);
        }


        [TestMethod()]
        public void OnesThroughSixesTest()
        {
            //Arrange
            int[] givenArray = { 1, 1, 1, 4, 5 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedOnes = 3;
            int expectedTwos = 0;
            int expectedThrees = 0;
            int expectedFours = 4;
            int expectedFives = 5;
            int expectedSixes = 0;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedOnes, score.onesScore);
            Assert.AreEqual(expectedTwos, score.twosScore);
            Assert.AreEqual(expectedThrees, score.threesScore);
            Assert.AreEqual(expectedFours, score.foursScore);
            Assert.AreEqual(expectedFives, score.fivesScore);
            Assert.AreEqual(expectedSixes, score.sixesScore);
        }

        [TestMethod()]
        public void ThreeOfAKindTest()
        {
            //Arrange
            int[] givenArray = { 1, 1, 1, 4, 5 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedThreeKind = 12;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedThreeKind, score.threeKindScore);
        }

        [TestMethod()]
        public void FourOfAKindTest()
        {
            //Arrange
            int[] givenArray = { 4, 4, 4, 4, 5 }; ;
            int[] givenIteratorArray = { 0, 0, 0, 4, 1, 0 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedFourKind = 21;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedFourKind, score.fourKindScore);
        }

        [TestMethod()]
        public void FullHouseTest()
        {
            //Arrange
            int[] givenArray = { 4, 4, 4, 5, 5 }; ;
            int[] givenIteratorArray = { 0, 0, 0, 3, 2, 0 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedFullHouse = 25;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedFullHouse, score.fullHouseScore);
        }

        [TestMethod()]
        public void SmallStraightTest()
        {
            //Arrange
            int[] givenArray = { 4, 2, 3, 1, 1 };
            int[] givenIteratorArray = { 2, 1, 1, 1, 0, 0 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedSmallStraight = 30;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedSmallStraight, score.smallStraightScore);
        }

        [TestMethod()]
        public void LargeStraightTest()
        {
            //Arrange
            int[] givenArray = { 4, 2, 3, 1, 5 };
            int[] givenIteratorArray = { 1, 1, 1, 1, 1, 1 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedLargeStraight = 40;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedLargeStraight, score.largeStraightScore);
        }

        [TestMethod()]
        public void ChanceTest()
        {
            //Arrange
            int[] givenArray = { 4, 2, 3, 1, 1 };
            int[] givenIteratorArray = { 2, 1, 1, 1, 0, 0 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedChance = 11;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedChance, score.chanceScore);
        }

        [TestMethod()]
        public void YahtzeeComboTest()
        {
            //Arrange
            int[] givenArray = { 1, 1, 1, 1, 1 };
            int[] givenIteratorArray = { 5, 0, 0, 0, 0, 0 };
            AccessRandomInterface random = new AccessRandomInterface(givenArray);
            Roll roll = new Roll(random);
            Score score = new Score(roll);
            int expectedYahtzee = 50;

            //Act
            roll.RollResults();
            score.CalcScores();

            //Assert
            Assert.AreEqual(expectedYahtzee, score.yahtzeeScore);
        }
    }
}