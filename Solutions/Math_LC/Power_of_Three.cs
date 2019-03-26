using System;
using System.Collections.Generic;

namespace Solutions.Math_LC
{
    public class Power_of_Three
    {
        /*
        Given an integer, write a function to determine if it is a power of three.
        */

        public bool IsPowerOfThree(int n)
        {
            HashSet<int> set = new HashSet<int>();
            int i = 1;
            set.Add(1);
            while (Int32.MaxValue / 3 > i)
                set.Add(i *= 3);
            return set.Contains(n);
        }

        public bool IsPowerOfThree_Iterative(int n)
        {
            if (n < 1)
                return false;
            while (n % 3 == 0)
                n /= 3;
            return n == 1;
        }
    }
}
