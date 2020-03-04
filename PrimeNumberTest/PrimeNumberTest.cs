using Microsoft.VisualStudio.TestTools.UnitTesting;

using PrimeNumbers;
namespace PrimeNumberTest
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void PrimeTest_SmallPrimes()
        {
            Assert.IsTrue(Prime.IsPrime(2));
            Assert.IsTrue(Prime.IsPrime(3));
            Assert.IsTrue(Prime.IsPrime(5));
            Assert.IsTrue(Prime.IsPrime(7));
            Assert.IsTrue(Prime.IsPrime(11));
            Assert.IsTrue(Prime.IsPrime(13));
            Assert.IsTrue(Prime.IsPrime(17));
        }
        [TestMethod]
        public void PrimeTest_SmallNonPrimes()
        {
            Assert.IsFalse(Prime.IsPrime(8));
            Assert.IsFalse(Prime.IsPrime(42));
            Assert.IsFalse(Prime.IsPrime(-3));
            Assert.IsFalse(Prime.IsPrime(0));
            Assert.IsFalse(Prime.IsPrime(125));
        }
        [TestMethod]
        public void PrimeTest_BigNumber()
        {
            Assert.IsTrue(Prime.IsPrime(223051));
        }
        [TestMethod]
        public void PrimeTest_Zero()
        {
            Assert.IsFalse(Prime.IsPrime(0));
        }
        [TestMethod]
        public void PrimeTest_One()
        {
            Assert.IsFalse(Prime.IsPrime(1));
        }
        [TestMethod]
        public void PrimeTest_Negative()
        {
            Assert.IsFalse(Prime.IsPrime(-7));
            Assert.IsFalse(Prime.IsPrime(-1));
        }
        [TestMethod]
        public void PrimeTest_Sums()
        {
            Assert.AreEqual(10, Prime.PrimeSum(3));
            Assert.AreEqual(28, Prime.PrimeSum(5));
            Assert.AreEqual(2, Prime.PrimeSum(1));
        }

    }
}
