using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Search_Insert_Position
    {
        public int SearchInsert(int[] nums, int target)
        {
            int n = nums.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (nums[i] >= target) return i;
                else if (nums[^(i + 1)] < target) return n - i;
                else if (nums[^(i + 1)] == target) return n - i - 1;
            }
            if (nums[0] < target) return 1;
            else return 0;
        }

    }
}
