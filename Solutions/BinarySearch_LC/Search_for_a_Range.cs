namespace Solutions.BinarySearch_LC
{
    public class Search_for_a_Range
    {
        /*
        Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
        Your algorithm's runtime complexity must be in the order of O(log n).
        If the target is not found in the array, return [-1, -1].
        */

        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };
            if (nums == null || nums.Length == 0)
                return result;
            int low = 0, high = nums.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] < target)
                    low = mid + 1;
                else
                    high = mid;
            }
            if (nums[low] != target)
                return result;
            result[0] = low;
            high = nums.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] > target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            result[1] = nums[low] == target ? low : low - 1;
            return result;
        }
    }
}
