using System;
using System.Collections.Generic;

namespace Solutions.Backtracking_LC
{
    public class Combination_Sum_II
    {
        /*
        Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.
        Each number in candidates may only be used once in the combination.
        Note:
            All numbers (including target) will be positive integers.
            The solution set must not contain duplicate combinations.
        */

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (candidates == null || candidates.Length == 0)
                return result;
            Array.Sort(candidates);
            Recursive(candidates, 0, target, result, new List<int>());
            return result;
        }

        private void Recursive(int[] nums, int p, int target, IList<IList<int>> result, List<int> list)
        {
            if (target == 0)
            {
                result.Add(new List<int>(list));
            }
            for (int i = p; i < nums.Length; ++i)
            {
                if (i > p && nums[i] == nums[i - 1] || nums[i] > target)
                    continue;
                list.Add(nums[i]);
                Recursive(nums, i + 1, target - nums[i], result, list);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
