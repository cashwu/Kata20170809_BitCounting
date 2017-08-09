using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170809_BitCounting
{
    [TestClass]
    public class BitCountingTests
    {
        [TestMethod]
        public void input_0_should_reutrn_0()
        {
            CountBetsShouldBe(0, 0);
        }

        private static void CountBetsShouldBe(int expected, int number)
        {
            var kata = new Kata();
            var actual = kata.CountBits(number);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int CountBits(int n)
        {
            return 0;
        }
    }
}
