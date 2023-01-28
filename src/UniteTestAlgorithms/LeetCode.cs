using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmsLibrary.LeetCode;

namespace UniteTestAlgorithms
{
    internal class LeetCode
    {
        [Test]
        public void CheckPalindromeManualPass()
        {
            findLongestPalindrome  findLongestPalindrome = new findLongestPalindrome();

            Assert.AreEqual("bacab", findLongestPalindrome.LongestPalindrome("abacab"));
        }

        [Test]
        public void TestTwoSum()
        {
            

            TwoSumProblem.TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);

        }
    }
}
