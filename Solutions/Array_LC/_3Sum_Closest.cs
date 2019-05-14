using System;

namespace Solutions.Array_LC
{
    public class _3Sum_Closest
    {
        /*
        Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target. Return the sum of the three integers. You may assume that each input would have exactly one solution.
        */

        public int ThreeSumClosest(int[] nums, int target)
        {
            int result = nums[0] + nums[1] + nums[nums.Length - 1];
            Array.Sort(nums);
            for (int i = 0, len = nums.Length; i < len - 2; ++i)
            {
                int low = i + 1, high = len - 1;
                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    if (sum == target)
                        return sum;
                    else if (sum > target)
                        --high;
                    else
                        ++low;
                    if (Math.Abs(target - sum) < Math.Abs(target - result))
                        result = sum;
                }
            }

            return result;
        }
    }
}
