

using LABA;
using NUnit.Framework.Interfaces;

namespace Tests
{
    public class Tests
    {
        private toTest obj;
        [SetUp]
        public void Setup()
        {
            obj = new toTest();
        }

        [TestCase(new int[] { 1, 0, 3, 4 }, new int[] { 0, 1, 3, 4 })]
        [TestCase(new int[] { -1, 0, -3, 4 }, new int[] { -3, -1, 0, 4 })]
        [TestCase(new int[] { 1, 0, 4, 2 }, new int[] { 0, 1, 2, 4 })]
        [TestCase(new int[] { }, new int[] { -1 })]
        public void Sort(int[] n, int[] res)
        {
            Assert.AreEqual(res, obj.Sort(n));
        }

        [TestCase("1111", true)]
        [TestCase("abab", false)]
        [TestCase("a", true)]
        [TestCase("", false)]
        public void Palindrom(string n, bool res)
        {
            Assert.AreEqual(res, obj.Palindrom(n));
        }
        [TestCase(-123, -1)]
        [TestCase(100, -1)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]
        public void Factorial(int n, int res)
        {
            Assert.AreEqual(res, obj.Factorial(n));
        }
        [TestCase(0, 0)]
        [TestCase(-123, -1)]
        [TestCase(123, -1)]
        [TestCase(3, 2)]
        public void Fibonachi(int n, int res)
        {
            Assert.AreEqual(res, obj.Fibonachi(n));
        }
        [TestCase("", "", true)]
        [TestCase("abcdefg", "a", true)]
        [TestCase("", "c", false)]
        [TestCase("abcdefg", "", false)]
        public void Includes(string s, string sub, bool res)
        {
            Assert.AreEqual(res, obj.Includes(s, sub));
        }
        [TestCase(-1, false)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(64, false)]
        public void simpleNumber(int n, bool res)
        {
            Assert.AreEqual(res, obj.simpleNumber(n));
        }
        [TestCase(-12, -21)]
        [TestCase(-1, -1)]
        [TestCase(200, 2)]
        [TestCase(2147483647, 0)]
        [TestCase(0, 0)]
        public void Reverse(int n, int res)
        {
            Assert.AreEqual(res, obj.Reverse(n));
        }
        [TestCase(1, "I")]
        [TestCase(100, "C")]
        [TestCase(1010, "MX")]
        [TestCase(0, "N")]
        [TestCase(-1, "error")]
        [TestCase(4000, "error")]
        public void toRoman(int n, string res)
        {
            Assert.AreEqual(res, obj.toRoman(n));
        }

    }
}