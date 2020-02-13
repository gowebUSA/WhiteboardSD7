using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alphabetize;
namespace AlphabetizedTest
{
    [TestClass]
    public class AlphaTest
    {
        [TestMethod]
        public void TestMethod_MSSA_CAD()
        {
            Assert.AreEqual("acdms", Alpha.AlphabetizedString("MSSA CAD"));
        }
        [TestMethod]
        public void TestMethod_Blank()
        {
            Assert.AreEqual("", Alpha.AlphabetizedString(""));
        }
        [TestMethod]
        public void TestMethod_aaa()
        {
            Assert.AreEqual("a", Alpha.AlphabetizedString("aaaaaaa aaaa"));
        }
        [TestMethod]
        public void TestMethod_WithPunc()
        {
            Assert.AreEqual("acdms", Alpha.AlphabetizedString("MSSA CAD!"));
        }
    }
}
