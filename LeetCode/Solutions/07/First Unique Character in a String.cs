using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class First_Unique_Character_in_a_String
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                else
                {
                    dic[s[i]] = s.Length;
                }
            }
            foreach (int value in dic.Values) if (value < s.Length) return value;
            return -1;
        }
    }
}
