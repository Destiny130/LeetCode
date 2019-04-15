using System;

namespace Solutions.DP_LC
{
    public class Coin_Change
    {
        /*
        You are given coins of different denominations and a total amount of money amount. Write a function to compute the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.
        */

        public int CoinChange_Recur(int[] coins, int amount)
        {
            if (amount < 1)
                return 0;
            return DFS(coins, amount, new int[amount]);
        }

        private int DFS(int[] coins, int rem, int[] dp)
        {
            if (rem < 0)
                return -1;
            if (rem == 0)
                return 0;
            if (dp[rem - 1] != 0)
                return dp[rem - 1];
            int min = Int32.MaxValue;
            foreach (int i in coins)
            {
                int temp = DFS(coins, rem - i, dp);
                if (temp >= 0 && temp < min)
                    min = 1 + temp;
            }
            dp[rem - 1] = min == Int32.MaxValue ? -1 : min;
            return dp[rem - 1];
        }

        public int CoinChange_Iter(int[] coins, int amount)
        {
            if (amount < 1)
                return 0;
            int[] dp = new int[amount + 1];
            dp[0] = 0;
            for (int i = 1; i <= amount; ++i)
                dp[i] = amount + 1;
            foreach (int c in coins)
            {
                for (int i = c; i <= amount; ++i)
                {
                    dp[i] = Math.Min(dp[i], dp[i - c] + 1);
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}
