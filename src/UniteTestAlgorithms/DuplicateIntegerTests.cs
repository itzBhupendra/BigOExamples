using AlgoritmsLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniteTestAlgorithms
{
    public class DuplicateIntegerTests
    {
        FindDuplicate findDuplicate;
        List<int> noDuplicateList;
        List<int> duplicateList;
        [SetUp]
        public void Setup()
        {
            findDuplicate = new FindDuplicate();
            noDuplicateList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            duplicateList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15, 16, 17, 18,  2, 3 };
        }

    

        [Test]
        public void findIntegerDuplicatePass()
        {
           
            int? val = findDuplicate.findInteger(duplicateList);
            Assert.AreEqual(2, val);
        }


        [Test]
        public void findIntegerDuplicateFail()
        {
           
            int? val = findDuplicate.findInteger(noDuplicateList);
            Assert.AreEqual(null, val);
        }
    }
}
