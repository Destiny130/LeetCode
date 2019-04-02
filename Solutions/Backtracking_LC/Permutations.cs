using System.Collections.Generic;

namespace Solutions.Backtracking_LC
{
    public class Permutations
    {
        public IList<IList<int>> Permute_Iterative(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return result;
            result.Add(new List<int>() { nums[0] });
            for (int i = 1; i < nums.Length; ++i)
            {
                IList<IList<int>> tempResult = new List<IList<int>>();
                for (int j = 0; j <= i; ++j)
                {
                    foreach (var list in result)
                    {
                        IList<int> temp = new List<int>(list);
                        temp.Insert(j, nums[i]);
                        tempResult.Add(temp);
                    }
                }
                result = tempResult;
            }
            return result;
        }

        public IList<IList<int>> Permute_Recursive(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return result;
            DFS(result, 0, nums);
            return result;
        }

        private void DFS(IList<IList<int>> result, int position, int[] nums)
        {
            if (position == nums.Length)
            {
                result.Add(new List<int>(nums));
                return;
            }
            for (int i = position; i < nums.Length; ++i)
            {
                Swap(nums, position, i);
                DFS(result, position + 1, nums);
                Swap(nums, position, i);
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
