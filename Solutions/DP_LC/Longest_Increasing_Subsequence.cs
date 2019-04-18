using System;

namespace Solutions.DP_LC
{
    public class Longest_Increasing_Subsequence
    {
        /*
        Given an unsorted array of integers, find the length of longest increasing subsequence.
        */

        public int LengthOfLIS(int[] nums)
        {
            if (nums == null)
                return 0;
            int len = nums.Length, max = 0;
            if (len < 2)
                return len;
            int[] dp = new int[len];
            dp[0] = 1;
            for (int i = 1; i < len; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (nums[j] < nums[i])
                        dp[i] = Math.Max(dp[i], dp[j]);
                }
                max = Math.Max(max, ++dp[i]);
            }
            return max;
        }

        public int LengthOfLIS_1(int[] nums)
        {
            if (nums == null)
                return 0;
            int len = nums.Length, result = 0;
            if (len < 2)
                return len;
            int[] dp = new int[len];
            foreach (int i in nums)
            {
                int low = 0, high = result;
                while (low < high)
                {
                    int mid = low + (high - low) / 2;
                    if (dp[mid] < i)
                        low = mid + 1;
                    else
                        high = mid;
                }
                dp[low] = i;
                if (low == result)
                    ++result;
            }
            return result;
        }
    }
}
