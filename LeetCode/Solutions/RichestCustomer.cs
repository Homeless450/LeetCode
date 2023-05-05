using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class RichestCustomer
    {
        public int MaximumWealth(int[][] accounts)
        {
            int count = 0, temp;
            for (int i  = 0; i < accounts.Length; i++)
            {
                temp = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    temp += accounts[i][j];
                }
                if (count < temp)
                {
                    count = temp;
                }
            }
            return count;
        }

    }
}
