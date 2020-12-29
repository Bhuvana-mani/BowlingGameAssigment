using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGameLibrary;

namespace BowlingTest
{
    [TestClass]
    public class GameScoreTest
    {
        GameScore game;
        [TestInitialize]
        public void CreateGame()
        {
             game = new GameScore();

        }
        private void RepeatSameRoll(int pins, int count)
        {
            for(int i=0;i<count;i++)
            {
                game.Roll(pins);
            }
        }
        [TestMethod]
        public void AllZero()
        {
            RepeatSameRoll(pins: 0, count: 20);
            int score = game.GetScore();
            Assert.AreEqual(0, score);

        }
        [TestMethod]
        public void Allones()
        {
            RepeatSameRoll(pins: 1, count: 20);
            int score = game.GetScore();
            Assert.AreEqual(20, score);

        }
        [TestMethod]
        public void OneSpare()
        {
            game.Roll(8);
            game.Roll(2);
            game.Roll(9);
            game.Roll(0);
            RepeatSameRoll(pins: 0, count: 16);
            int score = game.GetScore();
            Assert.AreEqual(8 + 2 + 9 * 2, score);
        }
        [TestMethod]
        public void OneStrike()
        {
            game.Roll(10);
            game.Roll(6);
            game.Roll(2);
            game.Roll(0);
            RepeatSameRoll(pins: 0, count: 16);
            int score = game.GetScore();
            Assert.AreEqual(10 + 6 * 2 + 2 * 2, score);
        }
        [TestMethod]
        public void PerfectGame()
        {
           
            RepeatSameRoll(pins:10, count: 12);
            int score = game.GetScore();
            Assert.AreEqual(300, score);
        }



    }

}
