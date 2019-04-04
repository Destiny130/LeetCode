namespace Solutions.Array_LC
{
    public class Find_Peak_Element
    {
        /*
        A peak element is an element that is greater than its neighbors.
        Given an input array nums, where nums[i] ≠ nums[i+1], find a peak element and return its index.
        The array may contain multiple peaks, in that case return the index to any one of the peaks is fine.
        You may imagine that nums[-1] = nums[n] = -∞.
        */

        public int FindPeakElement(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            if (nums.Length == 1)
                return 0;
            int low = 0, high = nums.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] < nums[mid + 1])
                    low = mid + 1;
                else
                    high = mid;
            }
            return low;
        }
    }
}
