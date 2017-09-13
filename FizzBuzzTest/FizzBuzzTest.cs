using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [TestCase(0, "0")]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        [TestCase(11, "11")]
        [TestCase(13, "13")]
        [TestCase(14, "14")]
        public void Should_return_number_if_not_devided_by_3_5_or_15(int number, string result)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();;
            Assert.AreEqual(result, fizzBuzz.GetResult(number));
        }

        [TestCase(3, "fizz")]
        [TestCase(6, "fizz")]
        [TestCase(9, "fizz")]
        [TestCase(12, "fizz")]
        public void Should_return_fizz_if_devided_by_3(int number, string result)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz(); ;
            Assert.AreEqual(result, fizzBuzz.GetResult(number));
        }

        [TestCase(5, "buzz")]
        [TestCase(10, "buzz")]
        public void Should_return_buzz_if_devided_by_5(int number, string result)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz(); ;
            Assert.AreEqual(result, fizzBuzz.GetResult(number));
        }

        [TestCase(15, "fizzbuzz")]
        [TestCase(30, "fizzbuzz")]
        public void Should_return_fizbuzz_if_devided_by_15(int number, string result)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz(); ;
            Assert.AreEqual(result, fizzBuzz.GetResult(number));
        }
    }
}
