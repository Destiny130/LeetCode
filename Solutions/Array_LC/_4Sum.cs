using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Array_LC
{
    public class _4Sum
    {
        /*
        Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.

        Note:   The solution set must not contain duplicate quadruplets.
        */

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 4)
            {
                return result;
            }

            Array.Sort(nums);
            int len = nums.Length;
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < len - 3; ++i)
            {
                for (int j = i + 1; j < len - 2; ++j)
                {
                    int low = j + 1, high = len - 1;
                    int temp = target - nums[i] - nums[j];
                    while (low < high)
                    {
                        int sum = nums[low] + nums[high];
                        if (sum == temp)
                        {
                            IList<int> list = new List<int>() { nums[i], nums[j], nums[low], nums[high] };
                            if (set.Add(String.Join(",", list)))
                            {
                                result.Add(list);
                            }

                            while (low < high && nums[low] == nums[low + 1])
                            {
                                ++low;
                            }

                            while (low < high && nums[high - 1] == nums[high])
                            {
                                --high;
                            }

                            ++low;
                            --high;
                        }
                        else if (sum < temp)
                        {
                            ++low;
                        }
                        else
                        {
                            --high;
                        }
                    }
                }
            }
            return result;
        }

        public IList<IList<int>> FourSum_MoreCheck(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 4)
            {
                return result;
            }

            Array.Sort(nums);
            int len = nums.Length;
            for (int i = 0; i < len - 3; ++i)
            {
                if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target)  //Min sum greater than target
                {
                    break;
                }

                if (nums[i] + nums[len - 1] + nums[len - 2] + nums[len - 3] < target)  //Max sum lesser than target
                {
                    continue;
                }

                if (i > 0 && nums[i] == nums[i - 1])  //First number is used in previous loop
                {
                    continue;
                }

                for (int j = i + 1; j < len - 2; ++j)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])  //Second number is used in previous loop
                    {
                        continue;
                    }

                    int low = j + 1, high = len - 1;
                    int temp = target - nums[i] - nums[j];
                    while (low < high)
                    {
                        int sum = nums[low] + nums[high];
                        if (sum == temp)
                        {
                            IList<int> list = new List<int>() { nums[i], nums[j], nums[low], nums[high] };
                            result.Add(list);
                            while (low < high && nums[low] == nums[low + 1])
                            {
                                ++low;
                            }

                            while (low < high && nums[high - 1] == nums[high])
                            {
                                --high;
                            }

                            ++low;
                            --high;
                        }
                        else if (sum < temp)
                        {
                            ++low;
                        }
                        else
                        {
                            --high;
                        }
                    }
                }
            }
            return result;
        }

        //Extension, k sum in an array that equals to target
        int len = 0;

        public IList<IList<int>> KSum(int[] nums, int target, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || (len = nums.Length) < k)
            {
                return result;
            }

            Array.Sort(nums);
            KSumRecursive(nums, target, k, 0, result, new List<int>());
            return result;
        }

        private void KSumRecursive(int[] nums, int target, int k, int p, IList<IList<int>> result, IList<int> list)
        {
            if (k == 2)
            {
                int low = p, high = len - 1;
                while (low < high)
                {
                    int sum = list.Sum() + nums[low] + nums[high];
                    if (sum == target)
                    {
                        IList<int> temp = new List<int>(list);
                        temp.Add(nums[low]);
                        temp.Add(nums[high]);
                        result.Add(temp);
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
            else
            {
                for (int i = p; i < len - k + 1; ++i)
                {
                    if (i > p && nums[i] == nums[i - 1])
                    {
                        continue;
                    }

                    list.Add(nums[i]);
                    KSumRecursive(nums, target, k - 1, i + 1, result, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
