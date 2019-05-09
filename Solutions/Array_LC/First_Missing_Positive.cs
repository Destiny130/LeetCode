namespace Solutions.Array_LC
{
    public class First_Missing_Positive
    {
        /*
        Given an unsorted integer array, find the smallest missing positive integer.
        */

        public int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 1;
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] <= 0 || nums[i] > nums.Length)
                    ++i;
                else if (nums[i] != i + 1 && nums[i] != nums[nums[i] - 1])
                    Swap(nums, i, nums[i] - 1);
                else
                    ++i;
            }

            i = 0;
            while (i < nums.Length && nums[i] == i + 1)
                ++i;
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
