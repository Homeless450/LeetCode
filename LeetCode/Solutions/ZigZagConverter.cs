using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class ZigZagConverter
    {
        public string Convert(string s, int numRows)
        {
            char[,] res = new char[numRows, s.Length];
            int counter = 0;
            bool down = true;

            for (int i = 0; i < s.Length; i++)
            {
                res[counter, i] = s[i];

                if (counter == 0 && counter < numRows - 1)
                {
                    counter++;
                    down = true;
                }
                else if (counter < numRows-1 && down)
                {
                    counter++;
                }
                else if (counter > -1 && !down)
                {
                    counter --;
                }
                else if (counter == numRows-1 && counter > 0)
                {
                    counter --;
                    down = false;
                }
            }
            string result = "";
            foreach (char c in res)
            {
                if (c!='\0')
                {
                    result += c;
                }
            }
            return result;
        }
    }
}