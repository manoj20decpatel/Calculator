using Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Validator
    {
        [TestMethod]
        public void Test_Sum()
        {
            Assert.AreEqual(8, Calculate.Sum(5, 3));
        }

        [TestMethod]
        public void Test_Subtract_Zero()
        {
            Assert.AreEqual(0, Calculate.Subtract(1, 1));
        }

        [TestMethod]
        public void Test_Subtract_Negative()
        {
            Assert.AreEqual(-1, Calculate.Subtract(1, 2));
        }
    }
}
