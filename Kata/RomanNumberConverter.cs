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

            if (i == 1)
            {
                return "I";
            }
            throw new System.NotImplementedException();
        }
    }
}