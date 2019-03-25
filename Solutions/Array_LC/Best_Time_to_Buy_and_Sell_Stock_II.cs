using System;
using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Best_Time_to_Buy_and_Sell_Stock_II
    {
        /*
        Say you have an array for which the ith element is the price of a given stock on day i.
        Design an algorithm to find the maximum profit. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
        Note: You may not engage in multiple transactions at the same time (i.e., you must sell the stock before you buy again).
        */

        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; ++i)
            {
                profit += Math.Max(0, prices[i] - prices[i - 1]);
            }
            return profit;
        }

        //Less buy and sell count
        public int MaxProfit_1(int[] prices)
        {
            int profit = 0, i = 0, len = prices.Length - 1;
            while (i < len)
            {
                while (i < len && prices[i + 1] <= prices[i])
                    ++i;
                int buy = prices[i];
                while (i < len && prices[i + 1] > prices[i])
                    ++i;
                int sell = prices[i];
                profit += sell - buy;
            }
            return profit;
        }

        //Record every buy and sell date pair
        public Tuple<IList<Tuple<int, int>>, int> MaxProfit_2(int[] prices)
        {
            int profit = 0, i = 0, len = prices.Length - 1;
            IList<Tuple<int, int>> list = new List<Tuple<int, int>>();
            while (i < len)
            {
                while (i < len && prices[i + 1] <= prices[i])
                    ++i;
                int buy = prices[i];
                while (i < len && prices[i + 1] > prices[i])
                    ++i;
                int sell = prices[i];
                profit += sell - buy;
                list.Add(new Tuple<int, int>(buy, sell));
            }
            return new Tuple<IList<Tuple<int, int>>, int>(list, profit);
        }
    }
}
