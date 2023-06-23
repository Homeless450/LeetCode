using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class First_Bad_Version
    {
        bool IsBadVersion(int version)
        {
            if (version < 1)
            {
                return false;
            }
            else return true;
        }

        public int FirstBadVersion1(int n)
        {
            while (true)
            {
                if (IsBadVersion(n))
                {
                    n /= 2;
                }
                else if (n / 2 > 1)
                {
                    n = n + n / 2;
                }
                else
                {
                    n++;
                    if (!IsBadVersion(n)) return n;

                }
            }
        }
        public int FirstBadVersion(int n)
        {
            if (n / 2 > 0)
                n /= 2;
            else return n;
             n++;
            if (IsBadVersion(n))
            {
                while (IsBadVersion(n))
                {
                    n--;
                }
            }
            else
            {
                while (!IsBadVersion(n))
                {
                    n++;
                }
            }
            return n;
        }
    }
}