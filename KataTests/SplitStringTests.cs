using NUnit.Framework;
using Codewars;

namespace KataTests
{
    [TestFixture]
    public class SplitStringTests
    {
        //[Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, SplitString.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
        }
    }
}
