using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emzi0767
{
    [TestClass]
    [TestCategory("Greatness")]
    public class GreatnessTests
    {
        [TestMethod]
        public void TestGreatness1()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list2 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list3 = new OperatorList<int>(new[] { 1, 2, 3, 4 });
            var list4 = new OperatorList<int>(new[] { 1, 2 });

            Assert.IsFalse(list1 > list2);
            Assert.IsTrue(list1 >= list2);

            Assert.IsFalse(list1 > list3);
            Assert.IsFalse(list1 >= list3);

            Assert.IsTrue(list1 > list4);
            Assert.IsTrue(list1 >= list4);
        }

        [TestMethod]
        public void TestGreatness2()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list2 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list3 = new OperatorList<int>(new[] { 1, 2, 3, 4 });
            var list4 = new OperatorList<int>(new[] { 1, 2 });

            Assert.IsFalse(list1 < list2);
            Assert.IsTrue(list1 <= list2);

            Assert.IsTrue(list1 < list3);
            Assert.IsTrue(list1 <= list3);

            Assert.IsFalse(list1 < list4);
            Assert.IsFalse(list1 <= list4);
        }
    }
}
