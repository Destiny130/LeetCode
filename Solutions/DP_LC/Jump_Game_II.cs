using System;

namespace Solutions.DP_LC
{
    public class Jump_Game_II
    {
        /*
        Given an array of non-negative integers, you are initially positioned at the first index of the array.
        Each element in the array represents your maximum jump length at that position.
        Your goal is to reach the last index in the minimum number of jumps.
        */

        public int Jump(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return 0;
            int len = nums.Length;
            int[] dp = new int[len];
            for (int i = 0; i < len; ++i)
            {
                if (i > 0 && nums[i - 1] > 1 && nums[i] < nums[i - 1])
                    continue;
                int step = nums[i];
                for (int j = i + 1; j < i + step + 1 && j < len; ++j)
                {
                    if (j == len - 1)
                        return dp[i] + 1;
                    dp[j] = dp[j] == 0 ? dp[i] + 1 : Math.Min(dp[j], dp[i] + 1);
                }
            }
            return dp[len - 1];
        }

        public int Jump_DP(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return 0;
            int len = nums.Length, count = 0;
            for (int i = 0, reach = 0, prev = 0; i < len - 1; ++i)
            {
                reach = Math.Max(reach, i + nums[i]);
                if (i == prev)
                {
                    ++count;
                    prev = reach;
                }
            }
            return count;
        }
    }
}
