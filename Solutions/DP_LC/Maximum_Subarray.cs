using System;

namespace Solutions.DP_LC
{
    public class Maximum_Subarray
    {
        /*
        Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
        */

        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int maxSum = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                nums[i] += nums[i - 1] > 0 ? nums[i - 1] : 0;
                maxSum = Math.Max(maxSum, nums[i]);
            }
            return maxSum;
        }
    }
}
