using System;
using FizzBuzzKata;
using Xunit;

namespace FizzBuzUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(1, "1")]
        public void WorkCorrectly(int inputValue, string outputValue)
        {
            //Arrange
            var result = FizzBuzz.Calculator(inputValue);
            
            //Act
            
            //Assert
            Assert.Equal(outputValue, result);
            
        }
    }
}
