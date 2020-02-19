using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwapValue;
namespace SwapValueTest
{
    [TestClass]
    public class SwapTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1, y = 3;
            int X = 3, Y = 1;

            Swap.SwapValue(ref x, ref y);
            Assert.AreEqual(x, X);
            Assert.AreEqual(y, Y);
        }
    }
}
