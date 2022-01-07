using System;
using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class RomanNumberConverterTests
    {   
        private readonly IRomanNumberConverter _converter = new RomanNumberConverter();
        
        [Fact]
        public void GivenA0_ShouldReturnNulla()
        {
            var result = _converter.Convert(0);
            result.Should().Be("nulla");
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
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        public void GivenALessOrEqualTo10_ShouldReturnAnI(int input, string expected)
        {
           var roman =  _converter.Convert(input);

           roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(17, "XVII")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        public void GivenANumberBetween10And19_ShouldReturnAnXPlusNumbersBelow10(int input, string expected)
        {
           var roman =  _converter.Convert(input);
        
           roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(20, "XX")]
        [InlineData(21, "XXI")]
        [InlineData(22, "XXII")]
        [InlineData(23, "XXIII")]
        [InlineData(24, "XXIV")]
        [InlineData(25, "XXV")]
        [InlineData(26, "XXVI")]
        [InlineData(27, "XXVII")]
        [InlineData(28, "XXVIII")]
        [InlineData(29, "XXIX")]
        public void GivenANumberBetween20And29_ShouldReturnAXXPlusNumbersBelow10(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
    }
}
