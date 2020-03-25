using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterCounts;

namespace CharacterCountsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_UpperCase()
        {
            Assert.AreEqual(4, CharCount.CountUpper("The San Diego Zoo"));
            Assert.AreEqual(3, CharCount.CountUpper("onceUponATime"));
            Assert.AreEqual(2, CharCount.CountUpper("You and Me"));
        }
    }
}
