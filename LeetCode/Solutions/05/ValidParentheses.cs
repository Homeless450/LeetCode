using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {
            int a = 0, b = 0, d = 0;
                foreach (char c in s)
            {
                if (c == '(')
                {
                    a++;
                }
                if (c == ')')
                {
                    if (b != 0 || d != 0) return false;
                    a--;
                }
                if (c == '[')
                {
                    b++;
                }
                if (c == ']')
                {
                    if (a != 0 || d != 0) return false;
                    b--;
                }
                if (c == '{')
                {
                    d++;
                }
                if (c ==  '}')
                {
                    if (b != 0 || a != 0) return false;
                    d--;
                }
            }

            if (a == 0 && b == 0 && d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
