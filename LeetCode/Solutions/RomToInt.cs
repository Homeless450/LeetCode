using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{

    public class RomToInt
    {
        public int RomanToInt(string s)
        {
            var result = 0;
            var prevValue = 0;
            var currentValue = 0;
            var NUMBERS_DICTIONARY = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V' , 5},
                {'X' , 10},
                {'L' , 50},
                {'C' , 100},
                {'D' , 500 },
                {'M' , 1000}
            };

            for (var i = s.Length - 1; i >= 0; i--)
            {
                var symbol = s[i];
                prevValue = currentValue;
                currentValue = NUMBERS_DICTIONARY[symbol];

                if (currentValue >= prevValue)
                {
                    result += currentValue;
                }
                else
                {
                    result -= currentValue;
                }

            }

            return result;
        }
    }
}
