using System;

namespace Solutions.DP_LC
{
    public class Jump_Game
    {
        /*
        Given an array of non-negative integers, you are initially positioned at the first index of the array.
        Each element in the array represents your maximum jump length at that position.
        Determine if you are able to reach the last index.
        */

        public bool CanJump_BF(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return true;
            int len = nums.Length;
            bool[] dp = new bool[len];
            dp[0] = true;
            for (int i = 0; i < len; ++i)
            {
                if (dp[i])
                {
                    for (int j = i + 1, k = nums[i]; j < len && k > 0; ++j, --k)
                        dp[j] = true;
                }
            }
            return dp[len - 1];
        }

        public bool CanJump(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return true;
            int i = 0, reach = 0;
            for (; i < nums.Length && i <= reach; ++i)
                reach = Math.Max(reach, i + nums[i]);
            return reach + 1 >= nums.Length;
        }

        public bool CanJump_1(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return true;
            int i = 0, reach = 0;
            for (; i < nums.Length && i <= reach && reach + 1 < nums.Length; ++i)
                reach = Math.Max(reach, i + nums[i]);
            return reach + 1 >= nums.Length;
        }
    }
}
