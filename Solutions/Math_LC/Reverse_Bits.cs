using System;
using System.Linq;

namespace Solutions.Math_LC
{
    public class Reverse_Bits
    {
        public uint reverseBits(uint n)
        {
            string str = Convert.ToString(n, 2).PadLeft(32, '0');
            uint result = 0;
            Enumerable.Range(0, 32).Select(i => result += (uint)(Math.Pow(2, i) * (str.ElementAt(i) - 48))).ToList();
            return result;
        }
    }
}
