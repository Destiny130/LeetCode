using System;
using TestCases.Array_LC;
using TestCases.DP_LC;

namespace TestCases
{
    class Execute
    {
        static void Main()
        {
            new Two_Sum_Test().Execute();
            new Word_Break_Test().Execute();

            Console.ReadKey();
        }
    }
}
