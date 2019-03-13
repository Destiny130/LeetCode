namespace Solutions.Array_LC
{
    public class Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i != -1; --i)
            {
                if (digits[i] != 9)
                {
                    ++digits[i];
                    return digits;
                }
                else
                    digits[i] = 0;
            }
            int[] arr = new int[digits.Length + 1];
            arr[0] = 1;
            return arr;
        }
    }
}
