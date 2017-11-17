using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Assert.AreEqual("ABBCcAD", UniqueInOrderKata.UniqueInOrder("ABCcAD"));

            Assert.AreEqual("12233", UniqueInOrderKata.UniqueInOrder("123"));

            Assert.AreEqual(new List<double> { 1.1, 2.2, 2.2, 3.3 }, UniqueInOrderKata.UniqueInOrder(new List<double> { 1.1, 2.2, 3.3 }));




        }
    }
}
