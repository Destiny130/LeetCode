using System;
using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class _3Sum
    {
        /*
        Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
        */

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            Array.Sort(nums);
            int len = nums.Length;
            for (int i = 0; i < len - 2; ++i)
            {
                if (nums[i] > 0)
                {
                    break;
                }

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int low = i + 1, high = len - 1, target = 0 - nums[i];
                while (low < high)
                {
                    int sum = nums[low] + nums[high];
                    if (sum == target)
                    {
                        result.Add(new List<int>() { nums[i], nums[low], nums[high] });
                        while (low < high && nums[low] == nums[low + 1])
                        {
                            ++low;
                        }

                        while (low < high && nums[high] == nums[high - 1])
                        {
                            --high;
                        }

                        ++low;
                        --high;
                    }
                    else if (sum > target)
                    {
                        --high;
                    }
                    else
                    {
                        ++low;
                    }
                }
            }
            return result;
        }
    }
}
