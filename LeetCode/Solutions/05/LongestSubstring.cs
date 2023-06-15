using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int counter = 0, temp =1;
            string substring = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length-1; j++)
                {
                    substring += s[j];
                    if (!substring.Contains(s[j + 1]))
                    {
                        temp++;
                    }
                    else
                    {
                        break;
                    }
                }
                substring = "";
                if (counter < temp)
                {
                    counter = temp;
                }
                temp = 1;
                
            }
            return counter;
        }

    }
}
