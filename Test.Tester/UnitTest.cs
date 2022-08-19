using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using Test.Domain;

namespace Test.Tester
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestIfReturnPairs()
        {
            Predicate pred = new Predicate();

            List<int> ExpectedPairs = new List<int>() {2, 4, 6, 8, 10 };

            List<int> Pairs = pred.GetPairs(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Assert.AreEqual(ExpectedPairs[0], Pairs[0]);
        }
    }
}
