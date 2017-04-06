using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emzi0767
{
    [TestClass]
    [TestCategory("Subtraction")]
    public class SubtractionTests
    {
        [TestMethod]
        public void TestSubtraction1()
        {
            var array1 = new[] { 1, 2, 3 };
            var array2 = new[] { 1, 3 };

            var list1 = new OperatorList<int>(array1);

            Assert.AreEqual(3, list1.Count);

            list1 -= 2;

            Assert.AreEqual(2, list1.Count);

            var eq = true;
            for (var i = 0; i < list1.Count; i++)
                eq &= list1[i] == array2[i];

            Assert.IsTrue(eq);
        }

        [TestMethod]
        public void TestSubtraction2()
        {
            var array1 = new[] { 1, 2, 3 };
            var array2 = new[] { 1, 3 };
            var array3 = new[] { 2 };

            var list1 = new OperatorList<int>(array1);

            Assert.AreEqual(3, list1.Count);

            list1 -= array2;

            Assert.AreEqual(1, list1.Count);

            var eq = true;
            for (var i = 0; i < list1.Count; i++)
                eq &= list1[i] == array3[i];

            Assert.IsTrue(eq);
        }

        [TestMethod]
        public void TestSubtraction3()
        {
            var str1 = "Quick brown fox jumped over the lazy dog.";
            var str2 = "Quick fox jumped over the dog.";

            var list1 = new OperatorList<string>(str1.Split(' '));

            Assert.AreEqual(8, list1.Count);

            list1 -= "brown";
            list1 -= "lazy";

            Assert.AreEqual(6, list1.Count);

            str1 = string.Join(" ", list1);

            Assert.AreEqual(str2, str1);
        }
    }
}
