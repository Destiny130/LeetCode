namespace Solutions.DP_LC
{
    public class Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];
            return DP(n, dp);
        }

        private int DP(int n, int[] dp)
        {
            if (n < 2)
                return 1;
            if (dp[n] == 0)
            {
                dp[n] = DP(n - 1, dp) + DP(n - 2, dp);
            }
            return dp[n];
        }

        //Like Fibonacci
        public int ClimbStairs_Fib(int n)
        {
            int a = 1, b = 1;
            while (n-- > 1)
            {
                int temp = b;
                b += a;
                a = temp;
            }
            return b;
        }
    }
}
