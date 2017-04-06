using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emzi0767.Test
{
    [TestClass]
    public class OperatorListTest
    {
        [TestMethod]
        [TestCategory("Addition")]
        public void TestAddition1()
        {
            var list1 = new OperatorList<int>();

            list1 += 1;
            list1 += 2;
            list1 += 3;
            list1 += 4;
            list1 += 5;

            Assert.AreEqual(5, list1.Count);

            var array1 = new[] { 1, 2, 3, 4, 5 };
            var eq = true;
            for (int i = 0; i < list1.Count; i++)
                eq &= list1[i] == array1[i];

            Assert.IsTrue(eq);
        }

        [TestMethod]
        [TestCategory("Addition")]
        public void TestAddition2()
        {
            var list1 = new OperatorList<int>();
            var list2 = new OperatorList<int>();

            list1 += 1;
            list1 += 2;
            list1 += 3;

            list2 += 4;
            list2 += 5;
            list2 += 6;

            Assert.AreEqual(3, list1.Count);
            Assert.AreEqual(3, list2.Count);
            Assert.IsFalse(list1 == list2);

            list1 += list2;

            Assert.AreEqual(6, list1.Count);

            var array1 = new[] { 1, 2, 3, 4, 5, 6 };
            var eq = true;
            for (int i = 0; i < list1.Count; i++)
                eq &= list1[i] == array1[i];

            Assert.IsTrue(eq);
        }
    }
}
