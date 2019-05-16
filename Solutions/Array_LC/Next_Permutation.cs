namespace Solutions.Array_LC
{
    public class Next_Permutation
    {
        /*
        Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
        If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
        The replacement must be in-place and use only constant extra memory.
        */

        public void NextPermutation(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return;
            int len = nums.Length;
            int i = len - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
                --i;
            if (i >= 0)
            {
                int j = len - 1;
                while (nums[j] <= nums[i])
                    --j;
                Swap(nums, i, j);
            }
            Reverse(nums, i + 1, len - 1);
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private void Reverse(int[] nums, int i, int j)
        {
            while (i < j)
            {
                Swap(nums, i++, j--);
            }
        }
    }
}
