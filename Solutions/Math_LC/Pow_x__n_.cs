using System;

namespace Solutions.Math_LC
{
    public class Pow_x__n_
    {
        /*
        Implement pow(x, n), which calculates x raised to the power n (Math.Pow(x,n)).
        */

        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            if (x == 0)
                return 0;
            if (n == Int32.MinValue)
                return x * x == 1 ? 1 : 0;
            if (n < 0)
                return 1 / MyPow(x, -n);
            return (n & 1) == 0 ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        }
    }
}
