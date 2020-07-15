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
        public void Test_Subtract()
        {
            Assert.AreEqual(0, Calculate.Sum(1, 1));
        }
    }
}
