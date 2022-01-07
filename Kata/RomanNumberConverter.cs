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

            var result = "";

            if (i >= 10)
            {
                result += "X";
                i -= 10;
            }
            
            result += SingleDigitConvert(i);

            return result;
        }

        private static string SingleDigitConvert(int i)
        {
            return i switch
            {
                0 => "",
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