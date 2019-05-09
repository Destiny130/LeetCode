using System;
using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Longest_Consecutive_Sequence
    {
        /*
        Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
        Your algorithm should run in O(n) complexity.
        */

        public int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            Dictionary<long, int> dic = new Dictionary<long, int>();
            int count = 0;
            foreach (int i in nums)
            {
                if (dic.ContainsKey(i))
                    continue;
                int leftLen = dic.ContainsKey(i - 1) ? dic[i - 1] : 0;
                int rightLen = dic.ContainsKey(i + 1) ? dic[i + 1] : 0;
                int sum = leftLen + rightLen + 1;
                dic[i] = sum;
                count = Math.Max(count, sum);
                if (leftLen > 0)
                    dic[i - leftLen] = sum;
                if (rightLen > 0)
                    dic[i + rightLen] = sum;
            }
            return count;
        }
    }
}
