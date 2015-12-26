using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameofLife;
using NUnit.Framework;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "*.\n..";
            string result = new Game().NextGeneration(input);
            string expected = "..\n..";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);

        }

        [TestMethod]
    public void CellWithTwoLivingNeighboursLives()
    {
        string input = "***";
        string result = new Game().NextGeneration(input);
        string expected = ".*.";
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
    }


        [TestMethod]
        public void CellWithTwoLivingInOneColumnNeighboursLives()
        {
            string input = "*\n*\n*";
            string result = new Game().NextGeneration(input);
            string expected = ".\n*\n.";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void CellWithTwoLivingDiagonallyArrangedNeighboursLives()
        {
            string input = "*..\n.*.\n..*";
            string result = new Game().NextGeneration(input);
            string expected = "...\n.*.\n...";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void CellWithTwoLivingDiagonallyArranged2NeighboursLives()
        {
            string input = "..*\n.*.\n*..";
            string result = new Game().NextGeneration(input);
            string expected = "...\n.*.\n...";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void CellWithThreeLivingNeighboursLives()
        {
            string input = "**\n**";
            string result = new Game().NextGeneration(input);
            string expected = "**\n**";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void CellWithMoreThanThreeIn3x3GridLivingNeighboursDies()
        {
            string input = "***\n.*.\n***";
            string result = new Game().NextGeneration(input);
            string expected = "***\n...\n***";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }


        [TestMethod]
      
        public void DeadCellWithThreeNeighboursIn4x8GridLivingNeighboursLives()
        {
            string input = "........\n....*...\n...**...\n........";
            string result = new Game().NextGeneration(input);
            string expected = "........\n...**...\n...**...\n........";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }

}





    }

