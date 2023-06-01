using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class SumOfTrheeElements
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            {
                Array.Sort(nums);
                int start = 0, leftPtr, rightPtr;
                int answer = 0; int diff = int.MaxValue;
                while (start < nums.Length - 2)
                {
                    leftPtr = start + 1;
                    rightPtr = nums.Length - 1;
                    while (leftPtr < rightPtr)
                    {
                        int nowDiff = Math.Abs(target - nums[start] - nums[leftPtr] - nums[rightPtr]);
                        int nowAnswer = nums[start] + nums[leftPtr] + nums[rightPtr];
                        if (nowDiff < diff)
                        {
                            diff = nowDiff;
                            answer = nowAnswer;
                        }
                        if (nowAnswer > target)
                        {
                            rightPtr--;
                        }
                        else if (nowAnswer < target)
                        {
                            leftPtr++;
                        }
                        else return nowAnswer;
                    }
                    start++;
                }
                return answer;
            }
        }
    }
}
