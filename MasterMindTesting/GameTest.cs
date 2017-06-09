using System;
using MasterMind.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterMindTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerateRandomNumbersTest()
        {
            Game_M game = new Game_M();
            game.GenerateRandomNumber();
            Assert.IsNotNull(game.RandomNumber);
        }
    }
}
