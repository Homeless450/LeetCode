using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            char[] magazineArr = magazine.ToCharArray();


            foreach (char letter in ransomNote)
            {
                if (magazineArr.Contains(letter))
                {
                    magazineArr[Array.IndexOf(magazineArr, letter)] = '1';
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
