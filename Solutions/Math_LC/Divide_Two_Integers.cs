using System;

namespace Solutions.Math_LC
{
    public class Divide_Two_Integers
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0)
                return 0;
            else if (dividend == Int32.MinValue && divisor == -1)
                return Int32.MaxValue;
            bool factor = (dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0);
            int result = 0;
            long did = Math.Abs((long)dividend), div = Math.Abs((long)divisor);
            while (did >= div)
            {
                int cnt = 1;
                long temp = div;
                while (did >= temp << 1)
                {
                    temp <<= 1;
                    cnt <<= 1;
                }
                did -= temp;
                result += cnt;
            }
            return factor ? -result : result;
        }
    }
}
