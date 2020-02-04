using Microsoft.VisualStudio.TestTools.UnitTesting;

using PalindromeLib;
namespace PalindromeTest
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void IsPalindrome_dogs()
        {
            Assert.IsFalse(Palindrome.IsPalindrome("dogs"));
        }
        [TestMethod]
        public void IsPalindrome_racecar()
        {
            Assert.IsTrue(Palindrome.IsPalindrome("racecar"));
        }
        [TestMethod]
        public void IsPalindrome_mom_mom()
        {
            Assert.IsTrue(Palindrome.IsPalindrome("mom mom"));
        }
        [TestMethod]
        public void IsPalindrome_Racecar()
        {
            Assert.IsTrue(Palindrome.IsPalindrome("Racecar"));
        }
        [TestMethod]
        public void IsPalindrome_20200202()
        {
            Assert.IsTrue(Palindrome.IsPalindrome("20200202"));
        }
    }
}
