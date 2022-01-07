using System;
using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class RomanNumberConverterTests
    {   
        private readonly IRomanNumberConverter _converter = new RomanNumberConverter();
        
        [Fact]
        public void GivenA0_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _converter.Convert(0));
        }
        
        [Fact]
        public void GivenANegative_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _converter.Convert(-1));
        }
        
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        public void GivenA1_ShouldReturnAnI(int input, string expected)
        {
           var roman =  _converter.Convert(input);

           roman.Should().Be(expected);
        }
    }
}
