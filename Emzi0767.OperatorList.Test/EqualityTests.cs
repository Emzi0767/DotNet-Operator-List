using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emzi0767
{
    [TestClass]
    [TestCategory("Equality")]
    public class EqualityTests
    {
        [TestMethod]
        public void TestEquality1()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list2 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list3 = new OperatorList<int>(new[] { 1, 2, 4 });
            var list4 = new OperatorList<int>();

            Assert.IsTrue(list1 == list2);
            Assert.IsFalse(list1 == list3);
            Assert.IsFalse(list1 == list4);
            Assert.IsFalse(list2 == list3);
            Assert.IsFalse(list3 == list4);
            Assert.IsFalse(list1 == null);
            Assert.IsFalse(list2 == null);
            Assert.IsFalse(list3 == null);
            Assert.IsFalse(list4 == null);
        }

        [TestMethod]
        public void TestEquality2()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list2 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list3 = new OperatorList<int>(new[] { 1, 2, 4 });
            var list4 = new OperatorList<int>();

            Assert.IsFalse(list1 != list2);
            Assert.IsTrue(list1 != list3);
            Assert.IsTrue(list1 != list4);
            Assert.IsTrue(list2 != list3);
            Assert.IsTrue(list3 != list4);
            Assert.IsTrue(list1 != null);
            Assert.IsTrue(list2 != null);
            Assert.IsTrue(list3 != null);
            Assert.IsTrue(list4 != null);
        }
    }
}
