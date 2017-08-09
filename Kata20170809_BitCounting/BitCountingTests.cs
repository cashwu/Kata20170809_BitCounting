using System;
using System.Collections;
using System.Linq;
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

        [TestMethod]
        public void input_2_should_reutrn_1()
        {
            CountBetsShouldBe(1, 2);
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
            return Convert.ToString(n, 2).ToCharArray().Count(a => a == '1');
        }
    }
}
