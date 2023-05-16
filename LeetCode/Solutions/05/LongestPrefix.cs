using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int counter = 0;
            string temp = strs[0];
            string result = string.Empty;
            while (temp != string.Empty && counter < strs.Length)
            {
                result = string.Empty;
                counter++;
                for (int i = 0; i < Math.Min(temp.Length, strs[counter-1].Length); i++)
                {
                    if (temp[i] != strs[counter-1][i])
                    {
                        break;

                    }
                    result += temp[i];
                }
                temp = result;

            }
            return result;
        }
    }
}
