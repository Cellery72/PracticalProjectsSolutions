using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticalProjectsSolutions;

namespace PracticalProjectsSolutionsTest
{
    [TestClass]
    public class ClassicAlgorithmsTest
    {
        [TestMethod]
        public void CollatzConjectureTest()
        {
            // n=14 - should take 17 steps
            Assert.AreEqual(ClassicAlgorithms.CollatzConjecture(14), 17);
            Assert.AreNotEqual(ClassicAlgorithms.CollatzConjecture(14), 18);
            Assert.AreNotEqual(ClassicAlgorithms.CollatzConjecture(14), 16);

            // n=6 - should take 8 steps
            Assert.AreNotEqual(ClassicAlgorithms.CollatzConjecture(6), 10);
            Assert.AreNotEqual(ClassicAlgorithms.CollatzConjecture(6), 6);
            Assert.AreEqual(ClassicAlgorithms.CollatzConjecture(6), 8);

            // n=36 - should take 21 steps
            Assert.AreNotEqual(ClassicAlgorithms.CollatzConjecture(36), 22);
            Assert.AreNotEqual(ClassicAlgorithms.CollatzConjecture(36), 20);
            Assert.AreEqual(ClassicAlgorithms.CollatzConjecture(36), 21);

            // n=26 - should take 10 steps
            Assert.AreNotEqual(ClassicAlgorithms.CollatzConjecture(26), 11);
            Assert.AreNotEqual(ClassicAlgorithms.CollatzConjecture(26), 9);
            Assert.AreEqual(ClassicAlgorithms.CollatzConjecture(26), 10);

        }
    }
}
