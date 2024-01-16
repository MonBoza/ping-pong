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
      Game newGame = new Game(5);
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

  [TestMethod]
  public void GetUserNumber_ReturnInt_Int()
  {
    int userNumber = 5;
    Game newGame = new Game(userNumber);
    int result = newGame.Number;
    Assert.AreEqual(userNumber, result);
  }

  }
}