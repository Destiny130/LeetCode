using System;
using System.Linq;
using Solutions.Array_LC;

namespace TestCases.Array_LC
{
    public class Two_Sum_Test
    {
        public void Execute()
        {
            int[] arr = { 2, 7, 11, 34, 3, 2 };
            Two_Sum twoSum = new Two_Sum();
            int[] result = twoSum.TwoSum(arr, 9);
            result.ToList().ForEach(i => Console.Write($"{i}\t"));
        }
    }
}
