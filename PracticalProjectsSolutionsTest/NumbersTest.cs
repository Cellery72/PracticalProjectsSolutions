using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PracticalProjectsSolutions;

namespace PracticalProjectsSolutionsTest
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void GenerateFibonacciSequenceNthNumberTest()
        {
            // Confirm the 9th number is 21
            Assert.AreEqual(Utility.ListToString(Numbers.GenerateFibonacciSequenceNthNumber(9)), Utility.ListToString(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21 }));
            // Confirm 0 and 1 respectively return the correct values
            Assert.AreEqual(Utility.ListToString(Numbers.GenerateFibonacciSequenceNthNumber(0)), "0");
            Assert.AreEqual(Utility.ListToString(Numbers.GenerateFibonacciSequenceNthNumber(1)), Utility.ListToString(new List<int>() { 0, 1 }));
        }

        [TestMethod]
        public void PrimeFactorizationTest()
        {
            Assert.AreEqual(Utility.ListToString(Numbers.PrimeFactorization(5)), Utility.ListToString(new List<int>() { 1, 2, 3, 5 }));
        }
    }
}
