using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        public void FizzBuzz_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(3), "Fizz");
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(6), "Fizz");
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(9), "Fizz");
        }

        [Test]
        public void FizzBuzz_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(5), "Buzz");
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(10), "Buzz");
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(20), "Buzz");
        }

        [Test]
        public void FizzBuzz_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(15), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(30), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(45), "FizzBuzz");
        }

        [Test]
        public void FizzBuzz_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(7), "7");
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(17), "17");
            Assert.AreEqual(FizzBuzz.FizzBuzz.GetOutput(1), "1");
        }
    }
}
