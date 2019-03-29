using System;
using Solutions.Math_LC;

namespace TestCases.Math_LC
{
    public class Reverse_Bits_Test
    {
        public void Execute()
        {
            Console.WriteLine($"\n{nameof(Reverse_Bits_Test)}");
            uint n = 43261596;
            uint k = new Reverse_Bits().reverseBits(n);
            Console.WriteLine($"Input nint: {n.ToString()}\nAfter reverse bits: {k}");
            Console.WriteLine($"Input bits:\t{Convert.ToString(n, 2).PadLeft(32, '0')}\nReverse bits:\t{Convert.ToString(k, 2).PadLeft(32, '0')}");
        }
    }
}
