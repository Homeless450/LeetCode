using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class RemoveFromArray
    {
        public int RemoveElement(int[] nums, int val)
        {
            int counter = 0;
            for (int i  = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[counter] = nums[i];
                    counter += 1;
                }
            }
            return counter;

        }

    }
}
