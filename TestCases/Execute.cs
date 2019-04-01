using System;
using TestCases.Array_LC;
using TestCases.DP_LC;
using TestCases.Math_LC;

namespace TestCases
{
    class Execute
    {
        static void Main()
        {
            #region Array

            //new Two_Sum_Test().Execute();
            new _3Sum_Test().Execute();

            #endregion

            #region DP

            //new Word_Break_Test().Execute();

            #endregion

            #region Math

            //new Reverse_Bits_Test().Execute();

            #endregion

          
            Console.ReadKey();
        }
    }
}
