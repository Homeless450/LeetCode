using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class StringToInteger
    {
        public int MyAtoi(string s)
        {
            StringBuilder str = new StringBuilder();
            string numbers = "123456789";
            int sign = 1;
            foreach (char c in s)
            {
                if (str.Length == 0 && c == '-')
                {
                    sign = -1;
                }
                else if (str.Length == 0 && c == '+')
                { }
                else if (numbers.Contains(c))
                {
                    str.Append(c);
                }
                else if (c == ' ')
                { }
                else { break; }
            }
            bool cor = int.TryParse(String.Join("", str), out int result);
            if (cor && str.Length>0)
                return result*sign;
            else if (str.Length == 0)
                return 0;
            if (!cor && sign < 0)
                return int.MinValue;
            else
                return int.MaxValue;
        }
    }
}
