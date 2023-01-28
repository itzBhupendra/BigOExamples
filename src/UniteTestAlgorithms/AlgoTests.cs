using AlgoritmsLibrary;
using AlgoritmsLibrary.AlgoExpert;
using NUnit.Framework;
using System.Collections.Generic;

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

        [Test]
        public void CheckValidSubsequenceShouldPass()
        {
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 1, 6, -1, 10 };
            Assert.AreEqual(true, SubSequenceArray.IsValidSubsequence(array, sequence));
        }
        [Test]
        public void CheckValidSubsequenceShouldFail()
        {
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 1, 6, 10, -1 };
            Assert.AreEqual(false, SubSequenceArray.IsValidSubsequence(array, sequence));
        }
    }
}