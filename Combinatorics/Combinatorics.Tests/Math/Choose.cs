namespace Combinatorics.Tests.Math
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Combinatorics;

    [TestClass]
    public class Choose
    {
        [TestMethod]
        public void Test1()
        {
            const ulong expected = 1;
            var actual = Math.Choose(1,1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2()
        {
            const ulong expected = 0;
            var actual = Math.Choose(1, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {
            const ulong expected = 2300;
            var actual = Math.Choose(25, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4()
        {
            const ulong expected = 203360683733321660;
            var actual = Math.Choose(152, 12);
            Assert.AreEqual(expected, actual);
        }
    }
}
