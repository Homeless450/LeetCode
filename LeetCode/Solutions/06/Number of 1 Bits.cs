using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Number_of_1_Bits
    {
        public int HammingWeight(uint n)
        {
            int result = 0;

            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    result++;

                }

                n /= 2;

            }
            return result;
        }
    }
}
