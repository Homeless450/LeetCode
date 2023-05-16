using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int result = 1;
            for (int i = 1; i < nums.Length-1; i++)
            {
                if (nums[i] > nums[i-1])
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}
