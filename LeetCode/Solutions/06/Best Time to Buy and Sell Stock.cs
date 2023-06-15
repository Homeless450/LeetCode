using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            int profit = 0; int min = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                int todaysProfit = prices[i] - prices[min];
                if (todaysProfit > profit)
                {
                    profit = todaysProfit;
                    result = i;
                }

                if (prices[min] > prices[i])
                {
                    min = i;
                }
            }
            if (profit < 0)
                return 0;
            else return result+1;

        }
    }
}
