using AlgoritmsLibrary;
using NUnit.Framework;

namespace UniteTestAlgorithms
{
    public class Tests
    {
        Palindrome palindrome;
        [SetUp]
        public void Setup()
        {
            palindrome = new Palindrome();
        }

        [Test]
        public void CheckPalindromeManualPass()
        {
             
            Assert.AreEqual(true, palindrome.CheckPalindromeManual("redivider"));
        }

        [Test]
        public void CheckPalindromeManualFail()
        {
            Assert.AreEqual(false,palindrome.CheckPalindromeManual("saadds"));
        }

        [Test]
        public void CheckPalindromeAutoPass()
        {
            bool resutl = palindrome.CheckPalindromeAuto("redivider");
            Assert.AreEqual(true,resutl);
        }

        [Test]
        public void CheckPalindromeAutoFail()
        {
            Assert.AreEqual(false, palindrome.CheckPalindromeAuto("zxzdvvfxfgfgsfgsfbzfxbfgfgssbervsdfsdbdrgdvDSgsgSDvDSGasgdsvzdgeasgDzsfdsagasg"));
        }
    }
}