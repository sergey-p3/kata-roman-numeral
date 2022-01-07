using System;

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

            if (i < 10)
                return SingleDigitConvert(i);

            return "X";
        }

        private static string SingleDigitConvert(int i)
        {
            return i switch
            {
                1 => "I",
                2 => "II",
                3 => "III",
                4 => "IV",
                5 => "V",
                6 => "VI",
                7 => "VII",
                8 => "VIII",
                9 => "IX",
                _ => throw new NotSupportedException()
            };
        }
    }
}