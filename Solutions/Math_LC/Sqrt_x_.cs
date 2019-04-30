namespace Solutions.Math_LC
{
    public class Sqrt_x_
    {
        public int MySqrt_Binary(int x)
        {
            int low = 1, high = x;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (mid == x / mid)
                    return mid;
                else if (mid > x / mid)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return high;
        }
    }
}