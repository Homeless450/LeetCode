using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Binary_Search
    {
        public int Search(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length/2; i++)
            {
                if (nums[i] == target) return i;
                else if (nums[^i] > target) return nums.Length-i;
            }
            return -1;
        }

    }
}
