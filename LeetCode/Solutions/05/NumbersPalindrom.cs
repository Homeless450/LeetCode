using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class NumbersPalindrom
    {
        public bool IsPalindrome(int x)
        {
            int[] arr = new int[10];
            int counter = 0;
            int MAX_NUMBER = 2147483647;
            if ( x<0 )
            {
                return false;
            }
            else
            {
                while (x > 0)
                {
                    arr[counter] = x % 10;
                    x = x / 10;
                    counter += 1;

                }
            }


            for (int i = 0; i < counter/2; i++)
            {
                if (arr[i] != arr[counter - 1 - i])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
