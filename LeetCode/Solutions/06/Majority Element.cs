using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length/2];
        }
    }
}
