using System;
using System.Reflection.Emit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoisonRoulette;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDrinkAntidote()
        {
            Antidote a = new Antidote();
            Player p = new Player();
            Assert.AreEqual(false, p.Invincible);
            a.DrinkAntidote(p);
            Assert.AreEqual(true, p.Invincible);
        }

        [TestMethod]
        public void TestToggleInvincible()
        {
            Player p = new Player();
            p.ToggleInvincible();
            Assert.AreEqual(true, p.Invincible);
            p.ToggleInvincible();
            Assert.AreEqual(false, p.Invincible);
        }

        [TestMethod]
        public void TestWin()
        {
            Player p = new Player();
            p.Wins = 5;
            p.Win();
            Assert.AreEqual(6, p.Wins);
        }

        [TestMethod]
        public void TestLose()
        {
            Player p = new Player();
            p.Losses = 5;
            p.Lose();
            Assert.AreEqual(6, p.Losses);
        }
    }
}
