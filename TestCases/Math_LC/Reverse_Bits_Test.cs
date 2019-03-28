using System;
using Solutions.Math_LC;

namespace TestCases.Math_LC
{
    public class Reverse_Bits_Test
    {
        public void Execute()
        {
            uint n = 43261596;
            Console.WriteLine(new Reverse_Bits().reverseBits(n));
        }
    }
}
