using System;
using NUnit.Framework;
using Codewars;

namespace KataTests
{


    [TestFixture]
    public class PrimeDecompTests
    {

        [Test]
        public void PrimeDecompositionTests()
        {

            int lst = 2;
            Assert.AreEqual("(2)", PrimeDecomp.factors(lst));

            

            lst = 3;
            Assert.AreEqual("(3)", PrimeDecomp.factors(lst));

            lst = 17;
            Assert.AreEqual("(17)", PrimeDecomp.factors(lst));


           

       

            lst = 50;
            Assert.AreEqual("(2)(5**2)", PrimeDecomp.factors(lst));

            lst = 7919;

            Assert.AreEqual("(7919)", PrimeDecomp.factors(lst));
            

            lst = 7775460;
            Assert.AreEqual("(2**2)(3**3)(5)(7)(11**2)(17)", PrimeDecomp.factors(lst));

            lst = (int)(int.MaxValue/2);

            Assert.AreEqual("(3**2)(7)(11)(31)(151)(331)", PrimeDecomp.factors(lst));

            lst = (int)(int.MaxValue * 0.99d);

            Assert.AreEqual("(2)(5)(47)(4523423)", PrimeDecomp.factors(lst));

            
            lst = 933555431;

            Assert.AreEqual("(7537)(123863)", PrimeDecomp.factors(lst));

            lst = 987654321;

            Assert.AreEqual("(3**2)(17**2)(379721)", PrimeDecomp.factors(lst));

            

        }
    }

}
