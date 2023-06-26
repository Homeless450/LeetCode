using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Reverse_Words_in_a_String_III
    {
        public string ReverseWords(string s)
        {
            char[] chars = s.ToCharArray();
            int counter = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (counter != 0)
                {
                    int temp = i;
                    while (counter != 0)
                    {
                        (chars[i], chars[counter]) = (chars[counter], chars[i++]);
                        counter--;
                    }
                    i = temp;
                }
                else if (chars[i] != 0)
                {
                    int temp = i;
                    while (chars[i] == ' ')
                    {
                        i++;
                        counter++;
                    }
                    i = temp;
                }
            }
            string result = String.Join("", chars);
            return result;
        }
    }
}
