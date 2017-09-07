namespace Combinatorics.Tests.Math
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Combinatorics;

    [TestClass]
    public class GreatesCommonDivisor
    {
        [TestMethod]
        public void Test1()
        {
            const ulong expected = 1;
            var actual = Math.GreatesCommonDivisor(1, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2()
        {
            const ulong expected = 1;
            var actual = Math.GreatesCommonDivisor(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {
            const ulong expected = 0;
            var actual = Math.GreatesCommonDivisor(0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4()
        {
            const ulong expected = 12548;
            var actual = Math.GreatesCommonDivisor(0, 12548);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5()
        {
            const ulong expected = ulong.MaxValue;
            var actual = Math.GreatesCommonDivisor(0, ulong.MaxValue);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6()
        {
            const ulong expected = 37644;
            var actual = Math.GreatesCommonDivisor(19424304, 9900372);
            Assert.AreEqual(expected, actual);
        }
    }
}
