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
        [InlineData(19, "XIX")]
        public void GivenANumberBetween10And19_ShouldReturnAnXPlusNumbersBelow10(int input, string expected)
        {
           var roman =  _converter.Convert(input);
        
           roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(30, "XXX")]
        public void GivenA30_ShouldReturnXXX(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(40, "XL")]
        [InlineData(49, "XLIX")]
        public void GivenA4x_ShouldReturnXLx(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(50, "L")]
        [InlineData(54, "LIV")]
        public void GivenA5x_ShouldReturnLx(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(90, "XC")]
        [InlineData(99, "XCIX")]
        public void GivenA9x_ShouldReturnLCx(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(100, "C")]
        [InlineData(149, "CXLIX")]
        public void GivenA1xx_ShouldReturnLx(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(400, "CD")]
        [InlineData(499, "CDXCIX")]
        public void GivenA4xx_ShouldReturnCDx(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(500, "D")]
        [InlineData(849, "DCCCXLIX")]
        public void GivenA5xx_ShouldReturnDxx(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(900, "CM")]
        [InlineData(998, "CMXCVIII")]
        public void GivenA9xx_ShouldReturnCMxx(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(1000, "M")]
        [InlineData(4984, "MMMMCMLXXXIV")]
        public void GivenANumberGreaterOrEqual1000_ShouldReturnMxx(int input, string expected)
        {
            var roman =  _converter.Convert(input);
        
            roman.Should().Be(expected);
        }
        
    }
}
