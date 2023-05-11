using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._1105
{
    internal class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var NUMBERS_DICTIONARY = new Dictionary<int, char>()
            {
                {1, 'I'},
                {5, 'V'},
                {10, 'X'},
                {50, 'L'},
                {100, 'C'},
                {500, 'D' },
                {1000, 'M'}
            };

            2345
                1000
                1000
                100
                100
                100
                

            string answer = "";
            int n = 10;
            while(num%n != 0)
            {
                n *= 10;
                if (num%10 == 0)
                {
                    answer.Insert(0, )
                }
            }

        }

    }
}
