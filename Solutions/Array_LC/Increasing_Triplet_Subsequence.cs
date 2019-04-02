using System;

namespace Solutions.Array_LC
{
    public class Increasing_Triplet_Subsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums == null || nums.Length < 3)
                return false;
            int first = Int32.MaxValue, second = Int32.MaxValue;
            foreach (int i in nums)
            {
                if (i <= first)
                    first = i;
                else if (i <= second)
                    second = i;
                else
                    return true;
            }
            return false;
        }
    }
}
