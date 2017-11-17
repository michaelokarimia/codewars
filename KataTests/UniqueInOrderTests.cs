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

        [Test]
        public void ListTest()
        {
            Assert.AreEqual(new List<int> { 1, 2, 3 },UniqueInOrderKata.UniqueInOrder(new List<int> { 1, 2, 3, 3 }));
            Assert.AreEqual(new List<double> { 1, 2, 3 },UniqueInOrderKata.UniqueInOrder(new List<double> { 1, 2, 3, 3 }));
            Assert.AreEqual(new List<char> { '1', '2', '3' },UniqueInOrderKata.UniqueInOrder(new List<char> { '1', '2', '3', '3' }));
            Assert.AreEqual(new List<string> { "1", "2", "3" },UniqueInOrderKata.UniqueInOrder(new List<string> { "1", "2", "3", "3" }));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB",UniqueInOrderKata.UniqueInOrder("AAAABBBCCDAABBB"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("aA",UniqueInOrderKata.UniqueInOrder("aA"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("AD",UniqueInOrderKata.UniqueInOrder("ADD"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual("DA",UniqueInOrderKata.UniqueInOrder("DDA"));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual("1232456",UniqueInOrderKata.UniqueInOrder("112332444566"));
        }
    }
}
