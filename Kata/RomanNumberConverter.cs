using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class RomanNumberConverter : IRomanNumberConverter
    {
        public string Convert(int i)
        {
            if (i < 0)
            {
                throw new ArgumentException("Romans didn't understand negative numbers");
            }
            
            if (i == 0)
            {
                return "nulla";
            }

            var result = new StringBuilder();

            var numberIncrements = new List<NumberIncrement>
            {
                new(500, "D", null, null),
                new(100, "C", 400, "CD"),
                new(50, "L", 90, "XC"),
                new(10, "X", 40, "XL"),
                new(5, "V", 9, "IX"),
                new(1, "I", 4, "IV")
            };

            foreach (NumberIncrement numberIncrement in numberIncrements)
            {
                string res;
                (i, res) = ConvertNumberIncrement(i, numberIncrement);
                result.Append(res);
            }
            
            return result.ToString();
        }

        private (int, string) ConvertNumberIncrement(int number, NumberIncrement numberIncrement)
        {
            var result = new StringBuilder();
            if (numberIncrement.UpperLimit.HasValue && number >= numberIncrement.UpperLimit)
            {
                number -= numberIncrement.UpperLimit.Value;
                result.Append(numberIncrement.UpperLimitChar);
            }
            while (number >= numberIncrement.Increment)
            {
                result.Append(numberIncrement.IncrementChar);
                number -= numberIncrement.Increment;
            }

            return (number, result.ToString());
        }
    }
}