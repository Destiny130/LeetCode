namespace Solutions.BinarySearch_LC
{
    public class Search_in_Rotated_Sorted_Array
    {
        /*
        Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
        (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).
        You are given a target value to search. If found in the array return its index, otherwise return -1.
        You may assume no duplicate exists in the array.
        Your algorithm's runtime complexity must be in the order of O(log n).
        */

        public int Search(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < nums[high])
                {
                    if (nums[mid] < target && nums[high] >= target)
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
                else {
                    if (nums[low] <= target && nums[mid] > target)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
            }
            return -1;
        }
    }
}
