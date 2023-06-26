using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Two_Sum_II___Input_Array_Is_Sorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int min = 0, max = numbers.Length - 1;
            while ((numbers[min] + numbers[max]) != target)
                if ((numbers[min] + numbers[max]) > target) max++;
                else min++;
            return new int[] { min + 1, max + 1 };
        }
    }
}
