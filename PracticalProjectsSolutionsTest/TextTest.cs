using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticalProjectsSolutionsTest
{
    [TestClass]
    public class TextTest
    {
        [TestMethod]
        public void FizzBuzzTest()
        {
            string[] expectedOutput = new string[] {"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz", "Buzz", "11","Fizz","13","14","FizzBuzz" };
            string[] output = PracticalProjectsSolutions.Text.FizzBuzz(15);

            CollectionAssert.AreEqual(output,expectedOutput);
        }

        [TestMethod]
        public void ReverseStringTest()
        {
            string expectedOutput = "otnorot";
            string input = "toronto";

            Assert.AreEqual(PracticalProjectsSolutions.Text.ReverseString(input),expectedOutput);
        }

        [TestMethod]
        public void CountVowelsTest()
        {
            string input = "octopus";
            int expectedOutput = 3;

            Assert.AreEqual(PracticalProjectsSolutions.Text.CountVowels(input),expectedOutput);
        }

        [TestMethod]
        public void CheckForPalindromeTest()
        {
            string input = "racecar";
            
            Assert.IsTrue(PracticalProjectsSolutions.Text.CheckForPalindrome(input));
        }

        [TestMethod]
        public void CountWordsInStringTest()
        {
            string input = "These are some words I wrote while typing on my keyboard";
            int expectedOutput = 11;

            Assert.AreEqual(PracticalProjectsSolutions.Text.CountWordsInString(input),expectedOutput);
        }
    }
}
