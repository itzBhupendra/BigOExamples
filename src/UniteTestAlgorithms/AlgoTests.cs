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

        [Test]
        public void TournamentWinnerShouldPass2()
        {
            List<List<string>> competitions = new List<List<string>>();
            List<string> competition1 = new List<string> {
            "HTML", "C#"
        };
            List<string> competition2 = new List<string> {
            "C#", "Python"
        };
            List<string> competition3 = new List<string> {
            "Python", "HTML"
        };
            competitions.Add(competition1);
            competitions.Add(competition2);
            competitions.Add(competition3);
            List<int> results = new List<int> {
            0, 0, 1
        };
            string expected = "Python";
            Assert.AreEqual(expected, TournamentWinnerClass.TournamentWinner(competitions, results));
        }

        [Test]
        public void NonConstructibleChangeShouldPass()
        {
            int[] input = new int[] { 5, 7, 1, 1, 2, 3, 22 };
            int expected = 20;
            var actual = NonConstructibleChange.fnNonConstructibleChange(input);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void CreateBST()
        {
            var root = new BST(10);
            root.left = new BST(5);
            root.left.left = new BST(2);
            root.left.left.left = new BST(1);
            root.left.right = new BST(5);
            root.right = new BST(15);
            root.right.left = new BST(13);
            root.right.left.right = new BST(14);
            root.right.right = new BST(22);

            root.Insert(12);
            Assert.True(root.right.left.left.value == 12);

            root.Remove(2);
            Assert.True(root.Contains(10) == false);
            Assert.True(root.value == 12);

            Assert.True(root.Contains(15));

        }

        [Test]
        public void FindShortestBST()
        {
            var root = new BST(10);
            root.left = new BST(5);
            root.left.left = new BST(2);
            root.left.left.left = new BST(1);
            root.left.right = new BST(5);
            root.right = new BST(15);
            root.right.left = new BST(13);
            root.right.left.right = new BST(14);
            root.right.right = new BST(22);


            var expected = 13;
            var actual = ClosestValueInBST.findClosestValueInBST(root, 12);




            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidateBST()
        {
            var root = new BST(10);
            root.left = new BST(5);
            root.left.left = new BST(2);
            root.left.left.left = new BST(1);
            root.left.right = new BST(5);
            root.right = new BST(15);
            root.right.left = new BST(13);
            root.right.left.right = new BST(14);
            root.right.right = new BST(22);

            var actual = ValidateBSTs.ValidateBst(root);
            Assert.IsTrue(actual);


        }


    }
}