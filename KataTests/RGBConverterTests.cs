using Codewars;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class RGBConverterTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("000000", RGBConverter.Rgb(0, 0, 0));
            Assert.AreEqual("FFFFFF", RGBConverter.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", RGBConverter.Rgb(255, 255, 300));
            Assert.AreEqual("9400D3", RGBConverter.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", RGBConverter.Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", RGBConverter.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", RGBConverter.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}
