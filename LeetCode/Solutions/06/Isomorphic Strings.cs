using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Isomorphic_Strings
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], t[i]);
                }
                else if (dic.GetValueOrDefault(s[i]) != t[i])
                {
                    return false;
                }
            }
            dic.Clear();
            for (int i = 0; i < t.Length; i++)
            {
                if (!dic.ContainsKey(t[i]))
                {
                    dic.Add(t[i], s[i]);
                }
                else if (dic.GetValueOrDefault(t[i]) != s[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
