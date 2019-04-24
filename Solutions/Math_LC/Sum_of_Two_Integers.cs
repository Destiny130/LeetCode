namespace Solutions.Math_LC
{
    class Sum_of_Two_Integers
    {
        /*
        Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -.
        */

        public int GetSum(int a, int b)
        {
            if (a == 0)
                return b;
            while (b != 0)
            {
                int c = a & b;
                a = a ^ b;
                b = c << 1;
            }
            return a;
        }

        public int GetSum_Recursive(int a, int b)
        {
            return b == 0 ? a : GetSum_Recursive(a ^ b, (a & b) << 1);
        }
    }
}
