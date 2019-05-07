namespace Solutions.Array_LC
{
    public class Product_of_Array_Except_Self
    {
        /*
        Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].
        */

        public int[] ProductExceptSelf(int[] nums)
        {
            long product = 1;
            int zeroCount = 0;
            int zeroIndex = -1;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] == 0)
                {
                    ++zeroCount;
                    zeroIndex = i;
                }
                else
                    product *= nums[i];
            }

            int[] result = new int[nums.Length];
            if (zeroCount > 1)
            {
                return result;
            }
            else if (zeroCount == 1)
            {
                result[zeroIndex] = (int)product;
                return result;
            }

            for (int i = 0; i < result.Length; ++i)
            {
                result[i] = nums[i] == 0 ? (int)product : (int)(product / nums[i]);
            }
            return result;
        }

        public int[] ProductExceptSelf_WithoutDivision(int[] nums)
        {
            int[] result = new int[nums.Length];
            int a = 1;
            for (int i = 0; i < nums.Length; ++i)
            {
                result[i] = a;
                a *= nums[i];
            }
            a = 1;
            for (int i = nums.Length - 1; i != -1; --i)
            {
                result[i] *= a;
                a *= nums[i];
            }
            return result;
        }
    }
}
