using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars;

namespace KataTests
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class DuplicateCountTest
    {
        [Test]
        public void DuplicateCountTests()
        {
            Assert.AreEqual(0, DuplicateCounter.DuplicateCount(""));
            Assert.AreEqual(0, DuplicateCounter.DuplicateCount("abcde"));
            Assert.AreEqual(2, DuplicateCounter.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, DuplicateCounter.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, DuplicateCounter.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, DuplicateCounter.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}
