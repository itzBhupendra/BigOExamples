using AlgoritmsLibrary;
using NUnit.Framework;

namespace UniteTestAlgorithms
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckPalindromeManualPass()
        {
            Palindrome palindrome = new Palindrome();
            Assert.AreEqual(true, palindrome.CheckPalindromeManual("redivider"));
        }

        [Test]
        public void CheckPalindromeManualFail()
        {
            Palindrome palindrome = new Palindrome();
            Assert.AreEqual(false,palindrome.CheckPalindromeManual("saadds"));
        }

        [Test]
        public void CheckPalindromeAutoPass()
        {
            Palindrome palindrome = new Palindrome();
            bool resutl = palindrome.CheckPalindromeAuto("redivider");
            Assert.AreEqual(true,resutl);
        }

        [Test]
        public void CheckPalindromeAutoFail()
        {
            Palindrome palindrome = new Palindrome();
            Assert.AreEqual(false, palindrome.CheckPalindromeAuto("saadds"));
        }
    }
}