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
            List<int> list = new List<int>();
            list[0] = nums[0];
            for (int i = 1; i < nums.Length-1; i++)
            {
                if (nums[i] > nums[i-1])
                {
                    list[i] = nums[i];
                    result += 1;
                }
            }
            nums = list.ToArray();
            return result;
        }
    }
}
