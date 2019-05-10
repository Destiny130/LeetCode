using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Sliding_Window_Maximum
    {
        /*
        Given an array nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position. Return the max sliding window.
        */

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (k < 2)
                return nums;
            int[] res = new int[nums.Length - k + 1];
            List<int> window = new List<int>();
            for (int i = 0; i < k; ++i)
                BinaryInsert(window, nums[i]);
            res[0] = window[k - 1];
            for (int i = k; i < nums.Length; ++i)
            {
                if (nums[i - k] != nums[i])
                {
                    window.Remove(nums[i - k]);
                    BinaryInsert(window, nums[i]);
                }
                res[i - k + 1] = window[k - 1];
            }
            return res;
        }

        private void BinaryInsert(List<int> list, int num)
        {
            int low = 0, high = list.Count - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (list[mid] == num)
                    break;
                else if (list[mid] > num)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            list.Insert(low, num);
        }
    }
}
