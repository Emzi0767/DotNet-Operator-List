using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emzi0767
{
    [TestClass]
    [TestCategory("Logic")]
    public class LogicTests
    {
        [TestMethod]
        public void TestLogic1()
        {
            var list1 = new OperatorList<int>(new[] { 1, 2, 3 });
            var list2 = new OperatorList<int>();
            var list3 = (OperatorList<int>)null;

            if (list1) { }
            else
                Assert.Fail();
            if (list2)
                Assert.Fail();
            if (list3)
                Assert.Fail();
        }
    }
}
