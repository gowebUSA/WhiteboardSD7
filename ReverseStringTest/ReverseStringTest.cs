using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ReverseStringTest
{
    [TestClass]
    public class ReverseStringTest
    {
        //public object ReverseString { get; private set; }
        

        [TestMethod]
        public void GetReverse_ILikeDogs()
        {
            Assert.AreEqual("sgoD ekiL I", ReverseString.ReverseString.GetReverse("I Like Dogs")); //blue ReverseString is the Program that I renamed.
        }
        [TestMethod]
        public void GetReverse_SuperBowl()
        {
            Assert.AreEqual("lwoB repuS", ReverseString.ReverseString.GetReverse("Super Bowl"));
        }
        //Use Test\Run Test and make sure that all TestMethod have Green Check.
    }
}
