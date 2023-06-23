using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Rotate_Array
    {
        public void Rotate(int[] nums, int k)
        {
            while (k >= nums.Length)
                k = k - nums.Length;

            if (nums.Length > 1)
            {
                int[] copy = new int[nums.Length];
                nums.CopyTo(copy, 0);

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i < k)
                    {
                        nums[i] = copy[^(k - i)];
                    }
                    else
                    {
                        nums[i] = copy[i - k];
                    }
                }
            }

        }

    }
}
