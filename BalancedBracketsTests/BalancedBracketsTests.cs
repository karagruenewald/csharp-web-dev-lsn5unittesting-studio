using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        /*Test Inputs
         * "[]"
         * ""
         * "["
         * "]"
         * "]["
         * "[[]]
         */




        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        //1.
        [TestMethod]
        public void TwoBracketsInCorrectOrder()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[]");
            Assert.IsTrue(actualOutput);
        }
        //2.
        [TestMethod]
        public void EmptyString ()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("");
            Assert.AreEqual(true, actualOutput);
        }
        //3.
        [TestMethod]
        public void OneOpeningBracket()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[");
            Assert.AreEqual(false, actualOutput);
        }
        //4.
        [TestMethod]
        public void OneClosingBracket()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("]");
            Assert.AreEqual(false, actualOutput);
        }
        //5.
        [TestMethod]
        public void TwoBracketsOppositeOrder()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("][");
            Assert.AreEqual(false, actualOutput);
        }
        //6.
        [TestMethod]
        public void ThreeBracketsStartingWithClose()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("][]");
            Assert.AreEqual(false, actualOutput);
        }
        //7.
        [TestMethod]
        public void ThreeBracketsStartingWithOpenAndClose()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[][");
            Assert.AreEqual(false, actualOutput);
        }
        
        //8.
        [TestMethod]
        public void FourBracketsStartingWithOpenOpen()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[[]]");
            Assert.AreEqual(true, actualOutput);
        }
        //9.
        [TestMethod]
        public void FourBracketsStartingWithClosedClosed()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("]][[");
            Assert.AreEqual(false, actualOutput);
        }
        //10.
        [TestMethod]
        public void TwoPairsOfBrackets()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[][]");
            Assert.AreEqual(true, actualOutput);
        }
        //11.
        [TestMethod]
        public void BracketsInCorrectOrderInAWord()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("Launch[Code]");
            Assert.IsTrue(actualOutput);
        }
        //12.
        [TestMethod]
        public void BracketsInWrongOrderInAWord()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("Launch]Code[");
            Assert.IsFalse(actualOutput);
        }
        

    }
}
