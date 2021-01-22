using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGameLibrary;
namespace PlayerTest
{
    [TestClass]
    public class PlayerTest
    {
        
        Player player;
        [TestInitialize]

        [TestMethod]
        public void CreateInstance_NewPlayer_Name()
        {
            var player = new Player("Sanu");

            Assert.AreEqual("Sanu", player.Name);
        }

        [TestMethod]
        public void CreateInstance_NewPlayer_Score()
        {
            var player = new Player("Sanu");

            Assert.AreEqual(0, player.GameScore.GetScore());
        }
    }   
}
