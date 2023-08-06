using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Power_of_Two
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n ==  0) return false;
            else if (n == 1) return true;
            return IsPowerOfTwo(n / 2);
        }

    }
}
