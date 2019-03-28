using System;

namespace Solutions.Math_LC
{
    public class Number_of_1_Bits
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            foreach (char c in Convert.ToString(n, 2))
                count += c == '1' ? 1 : 0;
            return count;
        }

        public int HammingWeight_1(uint n)
        {
            uint count = 0;
            while (n != 0)
            {
                count += n & 1;
                n = n >> 1;
            }
            return (int)count;
        }

        public int HammingWeight_2(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                n &= n - 1;
                ++count;
            }
            return count;
        }
    }
}
