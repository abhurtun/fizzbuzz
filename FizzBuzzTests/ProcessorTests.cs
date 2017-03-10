using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class ProcessorTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(14)]
        public void FizzBuzz_Processor_When_Not_Multiples_Of_3_or_5_ReturnsInput(int input)
        {
            var sut = new Processor();

            var result = sut.GetValue(input);

            Assert.Equal(input.ToString(), result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void FizzBuzz_Processor_When_Divisible_By3_ReturnsFizz(int input)
        {
            var sut = new Processor();

            var result = sut.GetValue(input);

            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(10)]
        public void FizzBuzz_Processor_When_Divisible_By5_ReturnsBuzz(int input)
        {
            var sut = new Processor();

            var result = sut.GetValue(input);

            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        public void FizzBuzz_Processor_When_Divisible_By3_And5_ReturnsFizzBuzz(int input)
        {
            var sut = new Processor();

            var result = sut.GetValue(input);

            Assert.Equal("FizzBuzz", result);
        }
    }
}