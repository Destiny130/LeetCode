using System;

namespace Solutions.DP_LC
{
    public class House_Robber
    {
        /*
        You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
        Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
        */
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int max = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                if (i > 2)
                    nums[i] += Math.Max(nums[i - 2], nums[i - 3]);
                else if (i == 2)
                    nums[i] += nums[i - 2];
                max = Math.Max(max, nums[i]);
            }
            return max;
        }
    }
}
