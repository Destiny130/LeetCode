using System.Collections.Generic;

namespace Solutions.Backtracking_LC
{
    public class Subsets_I
    {
        /*
        Given a set of distinct integers, nums, return all possible subsets (the power set).
        Note: The solution set must not contain duplicate subsets.
        */

        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            DFS(result, new List<int>(), nums, 0);
            return result;
        }

        private void DFS(IList<IList<int>> result, IList<int> list, int[] nums, int position)
        {
            result.Add(new List<int>(list));
            for (int i = position; i < nums.Length; ++i)
            {
                list.Add(nums[i]);
                DFS(result, list, nums, i + 1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
