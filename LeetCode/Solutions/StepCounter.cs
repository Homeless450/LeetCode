using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class StepCounter
    {
        public int NumberOfSteps(int num)
        {
            int step = 0;

            while (num !=0)
            {
                if (num%2==0) 
                {
                    num = num / 2;
                    step++;
                }
                else if (num%2!=0) 
                {
                    num = num - 1;
                    step++;
                }
            }
            return step;
        }

    }
}
