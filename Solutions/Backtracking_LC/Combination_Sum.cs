using System.Collections.Generic;

namespace Solutions.Backtracking_LC
{
    public class Combination_Sum
    {
        /*
        Given a set of candidate numbers (candidates) (without duplicates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.
        The same repeated number may be chosen from candidates unlimited number of times.
        Note:
            All numbers (including target) will be positive integers.
            The solution set must not contain duplicate combinations.
        */

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (candidates == null || candidates.Length == 0)
                return result;
            Recursive(candidates, 0, target, result, new List<int>());
            return result;
        }

        private void Recursive(int[] nums, int p, int target, IList<IList<int>> result, IList<int> list)
        {
            if (target == 0)
            {
                result.Add(new List<int>(list));
            }
            else if (target > 0)
            {
                for (int i = p; i < nums.Length; ++i)
                {
                    list.Add(nums[i]);
                    Recursive(nums, i, target - nums[i], result, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
