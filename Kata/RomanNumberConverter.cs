using System;

namespace Kata
{
    public class RomanNumberConverter : IRomanNumberConverter
    {
        public string Convert(int i)
        {
            if (i == 0)
            {
                throw new ArgumentException("Number should not be equal to 0");
            }
            throw new System.NotImplementedException();
        }
    }
}