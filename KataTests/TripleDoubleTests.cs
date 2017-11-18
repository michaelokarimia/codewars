using NUnit.Framework;

namespace KataTests
{


    [TestFixture]
    public class TripleDoubleTests
    {
        [Test]
        [TestCase(451999277, 41177722899, ExpectedResult = 1)]
        [TestCase(1222345, 12345, ExpectedResult = 0)]
        [TestCase(12345, 12345, ExpectedResult = 0)]
        [TestCase(666789, 12345667, ExpectedResult = 1)]
        [TestCase(10560002, 100, ExpectedResult = 1)]
        public static int FixedTest(long s1, long s2)
        {
            return Codewars.TripleDoubler.TripleDouble(s1, s2);
        }
    }
}
