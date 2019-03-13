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

        //One loop
        public void MoveZeroes_1(int[] nums)
        {
            for (int k = 0, i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != 0 && nums[k] == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[k];
                    nums[k++] = temp;
                }
                else if (nums[k] != 0)
                    k = i;
            }
        }
    }
}
