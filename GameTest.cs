using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGameLibrary;
using System.Collections.Generic;
namespace GameTest
{
    [TestClass]
    public class GameTest
    {
        
          Game game;
       
        public GameTest()
        {
            List<string> names = new List<string> { "Sanu", "Nandu" };
            game = new Game(names);
        }
        
        [TestMethod]
        public void RollStrike_ChangeActivePlayer()
        {
            game.Roll(10);

            Assert.AreEqual("Nandu", game._activePlayer.Name);
        }
        [TestMethod]
        public void RollOne_NotChangeActivePlayer()
        {
            game.Roll(1);

            Assert.AreEqual("Sanu", game._activePlayer.Name);
        }
        [TestMethod]
        public void RollTwoTimes_ChangeActivePlayer()
        {
            game.Roll(1);
            game.Roll(2);

            Assert.AreEqual("Nandu", game._activePlayer.Name);
        }

    }
}

