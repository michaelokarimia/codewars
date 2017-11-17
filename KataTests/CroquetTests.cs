using System;
using Codewars;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class CroquetTests
    {
        [Test]
        public void CroquetTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, Croquet.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, Croquet.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, Croquet.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
        }
    }
}
