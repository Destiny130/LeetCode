using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                if (dic.ContainsKey(target - nums[i]) && dic[target - nums[i]] != i)
                    return new int[] { dic[target - nums[i]], i };
                dic[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}
