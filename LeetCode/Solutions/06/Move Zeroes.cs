using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int[] copy = new int[nums.Length];
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    copy[counter] = nums[i];
                    counter++;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = copy[i];
            }
        }
    }
}
