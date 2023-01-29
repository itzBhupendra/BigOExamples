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
        [Test]
        public void SortedSquaredArrayShouldPass()
        {
            var array = new int[] { 1,2,3,4,5,6,7,8,9 };
            var result= new int[] { 1, 4, 9, 16, 25, 36, 49, 64, 81 };
            Assert.AreEqual(result, SortedSquaredArrayClass.SortedSquaredArray(array));
        }

        [Test]
        public void SortedSquaredArrayShouldPass2()
        {
            var array = new int[] { -10, -5, 0, 5, 10 };
            var result = new int[] { 0, 25, 25,100, 100 };
            Assert.AreEqual(result, SortedSquaredArrayClass.SortedSquaredArray(array));
        }

    }
}