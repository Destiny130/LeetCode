namespace Solutions.Array_LC
{
    public class Sort_Colors
    {
        /*
        Given an array with n objects colored red, white or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white and blue.
        Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
        Note: You are not suppose to use the library's sort function for this problem.
        */

        public void SortColors(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            int[] record = new int[3];
            foreach (int i in nums)
                ++record[i];
            for (int i = 0, j = 0; i < record.Length; ++i)
            {
                while (record[i]-- > 0)
                    nums[j++] = i;
            }
        }

        public void SortColors_OnePass(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            for (int low = 0, high = nums.Length - 1, i = 0; i <= high; ++i)
            {
                while (nums[i] == 2 && i < high)
                    Swap(nums, i, high--);
                while (nums[i] == 0 && i > low)
                    Swap(nums, i, low++);
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
