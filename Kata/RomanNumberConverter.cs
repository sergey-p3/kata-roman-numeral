using System;

namespace Kata
{
    public class RomanNumberConverter : IRomanNumberConverter
    {
        public string Convert(int i)
        {
            if (i <= 0)
            {
                throw new ArgumentException("Romans didn't understand non-positive numbers");
            }

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
                10 => "X",
                _ => throw new System.NotImplementedException()
            };
        }
    }
}