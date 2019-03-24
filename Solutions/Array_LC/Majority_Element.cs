using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Majority_Element
    {
        /*
        Given an array of size n, find the majority element. The majority element is the element that appears more than [ n/2 ] times.
        You may assume that the array is non-empty and the majority element always exist in the array.
        */

        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int len = nums.Length;
            foreach (int i in nums)
            {
                if (dic.ContainsKey(i))
                {
                    ++dic[i];
                    if (dic[i] > len / 2)
                        return i;
                }
                else
                    dic[i] = 1;
            }
            return nums[0];
        }

        //Boyer-Moore voting algorithm
        public int MajorityElement_BM(int[] nums)
        {
            int major = nums[0], count = 1;
            for (int i = 1; i < nums.Length; ++i)
            {
                if (count == 0)
                {
                    major = nums[i];
                    ++count;
                }
                else if (nums[i] == major)
                {
                    ++count;
                }
                else
                {
                    --count;
                }
            }
            return major;
        }
    }
}
