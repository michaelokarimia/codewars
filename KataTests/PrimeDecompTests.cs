using System;
using NUnit.Framework;
using Codewars;

namespace KataTests
{


    [TestFixture]
    public class PrimeDecompTests
    {

        [Test]
        public void Test1()
        {

            int lst = 7775460;
            Assert.AreEqual("(2**2)(3**3)(5)(7)(11**2)(17)", PrimeDecomp.factors(lst));

            lst = 2;
            Assert.AreEqual("(2)", PrimeDecomp.factors(lst));
        }
    }

}
