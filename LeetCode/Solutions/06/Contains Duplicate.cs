using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i <= nums.Length; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            
            return false;
        }

    }
}
