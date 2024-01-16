using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
  }
}