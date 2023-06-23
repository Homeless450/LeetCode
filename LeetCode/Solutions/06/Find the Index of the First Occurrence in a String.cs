using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public int StrStr(string haystack, string needle)
        {
            int result = -1;
            int temp;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && needle.Length <= haystack.Length - i)
                {
                    temp = i;
                    if (result == -1)
                    {
                        for (int j = 0; j < needle.Length; i++, j++)
                        {
                            if (haystack[i] != needle[j] && result == -1)
                            {
                                i = temp + 1; temp = -1; break;
                            }
                        }
                        result = temp;
                    }
                }
            }
            return result;
        }
    }
}
