using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountCapsLetter;

namespace CountCaps_LetterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Special_Char()
        {
            Assert.AreEqual(4, CountCaps.CountCapsLetter("Welcome To The Jungle!"));
        }
    }
}
