using System;

namespace Solutions.DP_LC
{
    public class Best_Time_to_Buy_and_Sell_Stock
    {
        //Brute force
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int start = 0;
            while (start < prices.Length - 1 && prices[start] >= prices[start + 1])
                ++start;
            for (int i = start; i < prices.Length - 1; ++i)
            {
                for (int j = i + 1; j < prices.Length; ++j)
                {
                    profit = Math.Max(profit, prices[j] - prices[i]);
                }
            }
            return profit;
        }

        //One loop, trace min value
        public int MaxProfit_1(int[] prices)
        {
            int profit = 0;
            int minVal = Int32.MaxValue;
            for (int i = 0; i < prices.Length; ++i)
            {
                minVal = Math.Min(minVal, prices[i]);
                profit = Math.Max(profit, prices[i] - minVal);
            }
            return profit;
        }
    }
}
