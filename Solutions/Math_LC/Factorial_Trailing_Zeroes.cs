namespace Solutions.Math_LC
{
    public class Factorial_Trailing_Zeroes
    {
        public int TrailingZeroes(int n)
        {
            return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
        }
    }
}
