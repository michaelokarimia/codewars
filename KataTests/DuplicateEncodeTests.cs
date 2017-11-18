
using Codewars;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class DuplicateEncodeTests
    {
        //[Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", DuplicateEncoderKata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", DuplicateEncoderKata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", DuplicateEncoderKata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", DuplicateEncoderKata.DuplicateEncode("(( @"));
        }
    }
}
