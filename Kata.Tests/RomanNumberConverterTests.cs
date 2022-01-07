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
    }
}
