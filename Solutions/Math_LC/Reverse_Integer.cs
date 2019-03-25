namespace Solutions.Math_LC
{
    public class Reverse_Integer
    {
        /*
        Given a 32-bit signed integer, reverse digits of an integer.
        Note: Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
        */

        public int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int mod = x % 10;
                int temp = result * 10 + mod;
                if ((temp - mod) / 10 != result)
                    return 0;
                result = temp;
                x /= 10;
            }
            return result;
        }

        //Using check
        public int Reverse_Check(int x)
        {
            try
            {
                int result = 0;
                while (x != 0)
                {
                    result = checked(result * 10 + x % 10);
                    x /= 10;
                }
                return result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
