﻿using System;
using MasterMind.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterMindTesting
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void GenerateRandomNumbersTest()
        {
            Game_M game = new Game_M();
            game.GenerateRandomNumber(5);
            Assert.IsNotNull(game.RandomNumber);           
        }

        [TestMethod]
        public void GetRandomNumberCountTest()
        {
            Game_M game = new Game_M();
            game.GetRandomNumberCount();
            Assert.AreEqual(5, game.RandomNumberCount);
        }



    }
}
