using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Reverse_String
    {
        public void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length/2; i++) (s[i], s[^(i+1)]) = (s[^(i + 1)], s[i]);
        }

    }
}
