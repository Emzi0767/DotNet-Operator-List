using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emzi0767
{
    [TestClass]
    [TestCategory("Multiplication")]
    public class MultiplicationTests
    {
        [TestMethod]
        public void TestMultiplication1()
        {
            var array1 = new[] { 1, 2, 3 };
            var array2 = new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };

            var list1 = new OperatorList<int>(array1);

            Assert.AreEqual(3, list1.Count);

            list1 *= 3;

            Assert.AreEqual(9, list1.Count);

            var eq = true;
            for (var i = 0; i < list1.Count; i++)
                eq &= list1[i] == array2[i];

            Assert.IsTrue(eq);
        }

        [TestMethod]
        public void TestMultiplication2()
        {
            var list1 = new OperatorList<string>(new[] { "Emzi", "is" });
            var list2 = new OperatorList<string>(new[] { "smart." });
            var list3 = new OperatorList<string>(new[] { "very" });

            var str1 = "Emzi is very very smart.";

            Assert.AreEqual(2, list1.Count);
            Assert.AreEqual(1, list2.Count);

            list1 = list1 + list3 * 2 + list2;

            Assert.AreEqual(5, list1.Count);

            var str2 = string.Join(" ", list1);

            Assert.AreEqual(str1, str2);
        }
    }
}
