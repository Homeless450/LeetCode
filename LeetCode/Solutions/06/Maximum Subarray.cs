using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Maximum_Subarray
    {
        public int MaxSubArray(int[] nums)
        {
            int result = nums[0], sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(nums[i], nums[i] + sum);
                result = Math.Max(result, sum);
            }
            return result;
        }
    }
}
