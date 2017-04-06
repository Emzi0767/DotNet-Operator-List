using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emzi0767
{
    [TestClass]
    [TestCategory("Bitwise")]
    public class BitwiseTests
    {
        [TestMethod]
        public void TestBitwise1()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list2 = new OperatorList<int>(new[] { 3, 4, 5 });

            var array1 = new[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(3, list1.Count);
            Assert.AreEqual(3, list2.Count);

            list1 = list1 | list2;

            Assert.AreEqual(5, list1.Count);

            var eq = true;
            for (var i = 0; i < list1.Count; i++)
                eq &= list1[i] == array1[i];

            Assert.IsTrue(eq);
        }

        [TestMethod]
        public void TestBitwise2()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });

            var array1 = new[] { 1, 2, 3, 4 };
            var array2 = new[] { 1, 2, 3 };

            Assert.AreEqual(3, list1.Count);

            var list2 = list1 | 4;
            var list3 = list1 | 3;

            Assert.AreEqual(4, list2.Count);
            Assert.AreEqual(3, list3.Count);

            var eq1 = true;
            for (var i = 0; i < list2.Count; i++)
                eq1 &= list2[i] == array1[i];

            var eq2 = true;
            for (var i = 0; i < list3.Count; i++)
                eq2 &= list3[i] == array2[i];

            Assert.IsTrue(eq1);
            Assert.IsTrue(eq2);
        }

        [TestMethod]
        public void TestBitwise3()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3, 4 });
            var list2 = new OperatorList<int>(new[] { 3, 4, 5 });

            var array1 = new[] { 3, 4 };

            Assert.AreEqual(4, list1.Count);
            Assert.AreEqual(3, list2.Count);

            list1 = list1 & list2;

            Assert.AreEqual(2, list1.Count);

            var eq = true;
            for (var i = 0; i < list1.Count; i++)
                eq &= list1[i] == array1[i];

            Assert.IsTrue(eq);
        }

        [TestMethod]
        public void TestBitwise4()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list2 = new OperatorList<string>(new[] { "one", "two", "three" });

            var int1 = 4;
            var int2 = 3;

            var str1 = "four";
            var str2 = "three";

            Assert.AreEqual(3, list1.Count);
            Assert.AreEqual(3, list2.Count);

            var int3 = list1 & int1;
            var int4 = list1 & int2;

            Assert.AreEqual(0, int3);
            Assert.AreEqual(int2, int4);

            var str3 = list2 & str1;
            var str4 = list2 & str2;

            Assert.AreEqual(null, str3);
            Assert.AreEqual(str2, str4);
        }

        [TestMethod]
        public void TestBitwise5()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list2 = new OperatorList<int>(new[] { 3, 4, 5 });

            var array1 = new[] { 1, 2, 4, 5 };

            Assert.AreEqual(3, list1.Count);
            Assert.AreEqual(3, list2.Count);

            list1 = list1 ^ list2;

            Assert.AreEqual(4, list1.Count);

            var eq = true;
            for (var i = 0; i < list1.Count; i++)
                eq &= list1[i] == array1[i];

            Assert.IsTrue(eq);
        }

        [TestMethod]
        public void TestBitwise6()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });

            var array1 = new[] { 1, 2, 3, 4 };
            var array2 = new[] { 1, 2 };

            Assert.AreEqual(3, list1.Count);

            var list2 = list1 ^ 4;
            var list3 = list1 ^ 3;

            Assert.AreEqual(4, list2.Count);
            Assert.AreEqual(2, list3.Count);

            var eq1 = true;
            for (var i = 0; i < list2.Count; i++)
                eq1 &= list2[i] == array1[i];

            var eq2 = true;
            for (var i = 0; i < list3.Count; i++)
                eq2 &= list3[i] == array2[i];

            Assert.IsTrue(eq1);
            Assert.IsTrue(eq2);
        }
    }
}
