using NUnit.Framework;
using Codewars;

namespace KataTests
{
    class XbonacciTests
    {
        private Xbonacci variabonacci;

        [SetUp]
        public void SetUp()
        {
            variabonacci = new Xbonacci();
        }

        [TearDown]
        public void TearDown()
        {
            variabonacci = null;
        }

        //[Test]
        public void Tests()
        {
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));

            Assert.AreEqual(new double[] { 0 }, variabonacci.Tribonacci(new double[] { 1, 2, 4 }, 0));

            

            Assert.AreEqual(new double[] { 1, 0, 0, 1, 1, 2, 4, 7, 13, 24  }, variabonacci.Tribonacci(new double[] { 1, 0, 0 }, 10));

            Assert.AreEqual(new double[] { 0, 1, 0, 1, 2, 3, 6, 11, 20, 37 }, variabonacci.Tribonacci(new double[] { 0, 1, 0 }, 10));

            Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));

            Assert.AreEqual(new double[] { 1, 0, }, variabonacci.Tribonacci(new double[] { 1, 0, 0 }, 2));


            Assert.AreEqual(new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, variabonacci.Tribonacci(new double[] { 0, 0, 0 }, 10));




        }
    }
}
