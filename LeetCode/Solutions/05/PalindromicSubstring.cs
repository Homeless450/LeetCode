using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class PalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            string result = "";
            int counter = 0, temp = 0;
            List<char> substring = new List<char>();
            List<char> resultSubstring = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length - i < counter)
                    break;

                for (int j = i; j < s.Length; j++)
                {
                    substring.Add(s[j]);
                    if (Paly(substring))
                    {
                        resultSubstring = substring.ToList<char>();
                        temp = resultSubstring.Count;

                    }
                }
                
                if (counter < temp)
                {
                    counter = temp;
                    result = String.Join("", resultSubstring);
                }
                substring.Clear();
                temp = 0;

            }
            return result;
        }

        private bool Paly(List<char> s)
        {
            for (int i = 0; i<s.Count/2; i++)
            {
                if (s[i] != s[s.Count - i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
