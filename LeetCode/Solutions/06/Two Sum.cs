using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Two_Sum
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(target - numbers[0], 0);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (dic.ContainsKey(numbers[i])) return new int[] { i, dic[numbers[i]] };
                else if (dic.ContainsKey(target - numbers[i])) { }
                else dic.Add(target - numbers[i], i);
            }
            return null;

        }

    }
}
