using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Reverse_Words_in_a_String_III_ver2
    {
        private void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++) (s[i], s[^(i + 1)]) = (s[^(i + 1)], s[i]);
        }
        public string ReverseWords(string s)
        {
            string[] strings = s.Split(new char[] { ' ' });

            for (int i = 0; i < strings.Length; i++)
            {
                char[] temp = strings[i].ToCharArray();
                Array.Reverse(temp);
                strings[i] = String.Join("", temp);
            }
            string result = String.Join(" ", strings);
            return result;
        }
    }
}
