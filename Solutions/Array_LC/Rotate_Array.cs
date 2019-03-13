namespace Solutions.Array_LC
{
    public class Rotate_Array
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1)
                return;
            int len = nums.Length;
            k %= len;
            if (k == 0)
                return;
            int[] arr = new int[len];
            for (int i = len - k, j = 0; i < len; ++i, ++j)
                arr[j] = nums[i];
            for (int i = 0, j = k; i < len - k; ++i, ++j)
                arr[j] = nums[i];
            for (int i = 0; i < len; ++i)
                nums[i] = arr[i];
        }

        //O(1) space extra space
        public void Rotate_1(int[] nums, int k)
        {
            int len = nums.Length; 
            k %= len;
            if (k == 0)
                return;
            Reverse(nums, 0, len - k - 1);
            Reverse(nums, len - k, len - 1);
            Reverse(nums, 0, len - 1);
        }

        private void Reverse(int[] arr, int low, int high)
        {
            while (low < high)
            {
                arr[low] ^= arr[high];
                arr[high] ^= arr[low];
                arr[low++] ^= arr[high--];
            }
        }
    }
}
