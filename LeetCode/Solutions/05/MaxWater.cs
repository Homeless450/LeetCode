using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class MaxWater
    {
        public int MaxArea(int[] height)
        {
            int point1 = 0, point2 = height.Length - 1;
            int temp;
            int max = (point2 - point1) * (height[point1] > height[point2] ? height[point2] : height[point1]);
            while (point2 - point1 != 1)
            {
                if (height[point2] > height[point1]) point1++;
                else point2--;

                temp = (point2 - point1) * Math.Min(height[point2], height[point1]);

                max = max > temp ? max : temp;
            }

            return max;

        }
    }
}
