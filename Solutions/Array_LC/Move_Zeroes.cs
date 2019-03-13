namespace Solutions.Array_LC
{
    public class Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != 0)
                    nums[k++] = nums[i];
            }
            for (; k < nums.Length; ++k)
                nums[k] = 0;
        }
    }
}
