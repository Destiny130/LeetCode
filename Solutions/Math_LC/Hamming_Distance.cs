using System;

namespace Solutions.Math_LC
{
    public class Hamming_Distance
    {
        public int HammingDistance(int x, int y)
        {
            int temp = x ^ y, count = 0;
            while (temp != 0)
            {
                temp &= temp - 1;
                ++count;
            }
            return count;
        }

        public int HammingDistance_1(int x, int y)
        {
            string s1 = Convert.ToString(x, 2).PadLeft(31, '0');
            string s2 = Convert.ToString(y, 2).PadLeft(31, '0');
            int count = 0;
            for (int i = 0; i < 31; ++i)
            {
                if (s1[i] != s2[i])
                    ++count;
            }
            return count;
        }
    }
}
