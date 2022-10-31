using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07_UnitTest_App;

namespace _07_UnitTest_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12, MyMath.Add(5, 7));
        }
    }
}
