using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            char[] chars = s.ToCharArray();
            bool isItWord = false;
            int result = 0;
            for (int i = chars.Length; i > 0; i--)
            {
                if (isItWord == false && chars[i - 1] != ' ')
                {
                    isItWord = true;
                }
                else if (isItWord == true && chars[i - 1] != ' ')
                {
                    result++;
                }
                else if (isItWord == true && chars[i - 1] == ' ')
                {
                    return result;
                }
            }
            return result;
        }
    }
}
