using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{

  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void Rochambeau_CreatesInstanceOfRochambeau_Rochambeau()
    {
      Rochambeau theGame = new Rochambeau();
      Assert.AreEqual(typeof(Rochambeau), theGame.GetType());
    }

    [TestMethod]
    public void Rochambeau_CheckDraw_Draw()
    {
      Rochambeau theGame = new Rochambeau();
      string result = Rochambeau.CheckDraw("rock", "rock");
      Assert.AreEqual(result, "draw");
    }
  }
}