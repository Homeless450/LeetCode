using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Permutation_in_String
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            double hashS1 = 0.0, hashS2 = 0.0;

            for (int i = 0; i < s1.Length; i++)
            {
                hashS1 += (int)s1[i] * Math.Pow(2, (int)s1[i]);
                hashS2 += (int)s2[i] * Math.Pow(2, (int)s2[i]);
            }

            int l = 0, r = s1.Length;

            while (r < s2.Length)
            {
                if (hashS1 == hashS2)
                    return true;
                hashS2 -= (int)s2[l] * Math.Pow(2, (int)s2[l]);
                hashS2 += (int)s2[r] * Math.Pow(2, (int)s2[r]);
                l++; r++;
            }

            if (hashS1 == hashS2)
                return true;
            return false;
        }
    }
}
