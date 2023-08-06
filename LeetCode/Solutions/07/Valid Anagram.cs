using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic1.ContainsKey(s[i]))
                {
                    dic1.Add(s[i], 1);
                }
                else dic1[s[i]] += 1;
                if (!dic2.ContainsKey(s[i]))
                {
                    dic2.Add(s[i], 1);
                }
                else dic2[s[i]] += 1;
            }
            foreach (char c in dic1.Keys)
            {
                if (dic2.ContainsKey(c) || dic2[c] != dic1[c]) return false;
            }
            return true;
        }
    }
}
