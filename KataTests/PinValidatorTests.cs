using NUnit.Framework;
using Codewars;

namespace KataTests
{
    //[TestFixture]
    public class PinValidatorTests
    {
        //[Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        public void LengthTest()
        {
            Assert.AreEqual(false, PinValidator.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, PinValidator.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, PinValidator.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, PinValidator.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, PinValidator.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, PinValidator.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, PinValidator.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, PinValidator.ValidatePin("00000000"), "Wrong output for \"00000000\"");
        }

        //[Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, PinValidator.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, PinValidator.ValidatePin(".234"), "Wrong output for \".234\"");

            Assert.AreEqual(false, PinValidator.ValidatePin("3976I2"), "Wrong output for \"3976I2\"");
            Assert.AreEqual(false, PinValidator.ValidatePin("7f7796"), "Wrong output for \"7f7796\"");

            Assert.AreEqual(false, PinValidator.ValidatePin("+63000"), "Wrong output for \"+63000\"");
            
        }

        //[Test, Description("ValidatePin should return true for valid pins")]
        public void ValidTest()
        {
            Assert.AreEqual(true, PinValidator.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, PinValidator.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, PinValidator.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, PinValidator.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, PinValidator.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, PinValidator.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, PinValidator.ValidatePin("090909"), "Wrong output for \"090909\"");
        }
    }
}
