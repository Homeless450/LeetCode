using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Intersection_of_Two_Arrays_II
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dic.ContainsKey(nums1[i])) dic[nums1[i]]++;
                else dic.Add(nums1[i], 1);
            }

            for (int i = 0;i < nums2.Length; i++)
            {
                if (dic.ContainsKey(nums2[i]) && dic[nums2[i]] > 0)
                {
                    dic[nums2[i]]--;
                    result.Add(nums2[i]);
                }
            }
            return result.ToArray();
        }
    }
}
