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

            var l = new Dictionary<int, (int, string)>
            {
                [10] = (1, "X"),
                [5] = (1, "V"),
                [1] = (1, "I")
            };

            var result = new StringBuilder();

            KeyValuePair<int, (int, string)> ?prev = null;
            foreach (KeyValuePair<int, (int, string)> x in l)
            {
                if (prev != null)
                {
                    var prevBarrier = prev.Value.Key - prev.Value.Value.Item1;
                    if (i >= prevBarrier)
                    {
                        i -= prevBarrier;
                        result.Append(l[prev.Value.Value.Item1].Item2);
                        result.Append(prev.Value.Value.Item2);
                    }
                }

                while (i >= x.Key)
                {
                    result.Append(x.Value.Item2);
                    i -= x.Key;
                }
                prev = x;
            }

            return result.ToString();
        }
    }
}