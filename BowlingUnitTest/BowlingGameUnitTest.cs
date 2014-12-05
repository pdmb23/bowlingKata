using System;
using BowlingKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingUnitTest
{
    [TestClass]
    public class BowlingGameUnitTest
    {
        [TestMethod]
        public void OpenFrame_Scores_SumOfPinsKnockedDown()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame(); 
            //ACT
            bowlingGame.Roll(5);
            bowlingGame.Roll(2);
            //ASSERT
            var expectedResult = 7;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void Spare_Scores_10PlusPinsKnockedDownOnNextRoll()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(6);
            bowlingGame.Roll(4);
            bowlingGame.Roll(3);
            bowlingGame.Roll(0);
            //ASSERT
            var expectedResult = 16;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void Strike_Scores_10PlusPinsKnockedDownOnNext2Rolls()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(10);
            bowlingGame.Roll(2);
            bowlingGame.Roll(4);
            //ASSERT
            var expectedResult = 22;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void AllRollsDidNotKnockDownAnyPins_Scores_Zero()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            //ASSERT
            var expectedResult = 0;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void AllRollsOnlyKnockDownOnePin_Scores_Ten()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            //ASSERT
            var expectedResult = 10;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void RandomGame1_Scores_168()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(10);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(2);
            bowlingGame.Roll(9);
            bowlingGame.Roll(1);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(2);
            bowlingGame.Roll(3);
            bowlingGame.Roll(6);
            bowlingGame.Roll(4);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(3);
            //ASSERT
            var expectedResult = 168;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void RandomGame2_Scores_133()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(1);
            bowlingGame.Roll(4);
            bowlingGame.Roll(4);
            bowlingGame.Roll(5);
            bowlingGame.Roll(6);
            bowlingGame.Roll(4);
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
            bowlingGame.Roll(10);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(6);
            bowlingGame.Roll(4);
            bowlingGame.Roll(10);
            bowlingGame.Roll(2);
            bowlingGame.Roll(8);
            bowlingGame.Roll(6);
            //ASSERT
            var expectedResult = 133;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void PerfectGame_Scores_300()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);

            //ASSERT
            var expectedResult = 300;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void RandomGame3_Scores_97()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(9);
            bowlingGame.Roll(0);
            bowlingGame.Roll(9);
            bowlingGame.Roll(1);
            bowlingGame.Roll(8);
            bowlingGame.Roll(0);
            bowlingGame.Roll(9);
            bowlingGame.Roll(0);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(8);
            bowlingGame.Roll(0);
            bowlingGame.Roll(0);
            bowlingGame.Roll(8);
            bowlingGame.Roll(9);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(8);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);

            //ASSERT
            var expectedResult = 97;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void RandomGame4_Scores_101()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(9);
            bowlingGame.Roll(0);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(8);
            bowlingGame.Roll(0);
            bowlingGame.Roll(9);
            bowlingGame.Roll(0);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(8);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(6);
            bowlingGame.Roll(0);
            bowlingGame.Roll(8);
            bowlingGame.Roll(0);

            //ASSERT   
            var expectedResult = 101;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void RandomGame5_Scores_121()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(7);
            bowlingGame.Roll(1);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(1);
            bowlingGame.Roll(0);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(8);
            bowlingGame.Roll(0);
            bowlingGame.Roll(9);
            bowlingGame.Roll(0);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(2);
            bowlingGame.Roll(8);
            bowlingGame.Roll(3);

            //ASSERT
            var expectedResult = 121;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void RandomGame6_Scores_167()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(10);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(9);
            bowlingGame.Roll(0);
            bowlingGame.Roll(10);
            bowlingGame.Roll(0);
            bowlingGame.Roll(8);
            bowlingGame.Roll(8);
            bowlingGame.Roll(2);
            bowlingGame.Roll(0);
            bowlingGame.Roll(6);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(8);
            bowlingGame.Roll(1);

            //ASSERT
            var expectedResult = 167;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void RandomGame7_Scores_145()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(10);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(9);
            bowlingGame.Roll(0);
            bowlingGame.Roll(10);
            bowlingGame.Roll(0);
            bowlingGame.Roll(8);
            bowlingGame.Roll(8);
            bowlingGame.Roll(2);
            bowlingGame.Roll(0);
            bowlingGame.Roll(6);
            bowlingGame.Roll(10);
            bowlingGame.Roll(10);
            bowlingGame.Roll(7);
            bowlingGame.Roll(2);

            //ASSERT
            var expectedResult = 145;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        public void AllRollsAreSpares_Scores_146()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();
            //ACT
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
            bowlingGame.Roll(6);
            bowlingGame.Roll(4);
            bowlingGame.Roll(2);
            bowlingGame.Roll(8);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
            bowlingGame.Roll(1);
            bowlingGame.Roll(9);
            bowlingGame.Roll(9);
            bowlingGame.Roll(1);
            bowlingGame.Roll(8);
            bowlingGame.Roll(2);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(4);
            bowlingGame.Roll(6);
            bowlingGame.Roll(1);

            //ASSERT
            var expectedResult = 146;
            Assert.AreEqual(expectedResult, bowlingGame.GetCurrentScore());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Excessive_Rolls_More_Than_Frames_Of_One_Game_Should_Throw()
        {
            //ARRANGE
            BowlingGame bowlingGame = new BowlingGame();

            //ACT
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
            bowlingGame.Roll(6);
            bowlingGame.Roll(4);
            bowlingGame.Roll(2);
            bowlingGame.Roll(8);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
            bowlingGame.Roll(1);
            bowlingGame.Roll(9);
            bowlingGame.Roll(9);
            bowlingGame.Roll(1);
            bowlingGame.Roll(8);
            bowlingGame.Roll(2);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(4);
            bowlingGame.Roll(6);
            bowlingGame.Roll(1);
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
            bowlingGame.Roll(6);
            bowlingGame.Roll(4);
            bowlingGame.Roll(2);
            bowlingGame.Roll(8);
            bowlingGame.Roll(3);
            bowlingGame.Roll(7);
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
            bowlingGame.Roll(1);
            bowlingGame.Roll(9);
            bowlingGame.Roll(9);
            bowlingGame.Roll(1);
            bowlingGame.Roll(8);
            bowlingGame.Roll(2);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(4);
            bowlingGame.Roll(6);
            bowlingGame.Roll(1);
        }
    }
}
