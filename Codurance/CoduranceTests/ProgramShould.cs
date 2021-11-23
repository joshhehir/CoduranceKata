using NUnit.Framework;

namespace CoduranceTests
{
    [TestFixture]
    public class StringCalculatorShould
    {
        StringCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [Test]
        public void CheckForEmptySum()
        {
            var result = calc.Add("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ReturnSameNumber()
        {
            var result = calc.Add("4");
            Assert.AreEqual(4, result);
        }

        [Test]
        public void ReturnSumOfTwoNumbers()
        {
            var result = calc.Add("1,2");
            Assert.AreEqual(3, result);
        }
    }
}