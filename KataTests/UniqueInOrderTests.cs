using System.Collections.Generic;
using Codewars;

namespace KataTests
{
    using NUnit.Framework;

    [TestFixture]
    public class UniqueInOrderTests
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", UniqueInOrderKata.UniqueInOrder(""));
        }
        [Test]
        public void Tests()
        {
            Assert.AreEqual("ABCDAB", UniqueInOrderKata.UniqueInOrder("AAAABBBCCDAABBB"));
            Assert.AreEqual("ABCcAD", UniqueInOrderKata.UniqueInOrder("ABBCcAD"));

            Assert.AreEqual("123", UniqueInOrderKata.UniqueInOrder("12233"));

            Assert.AreEqual(new List<double> { 1.1, 2.2, 3.3 }, UniqueInOrderKata.UniqueInOrder(new List<double> { 1.1, 2.2, 2.2, 3.3 }));




        }
    }
}
