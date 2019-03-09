using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions.Array;

namespace TestCases.Array
{
    public class Two_Sum_Test
    {
        public static void Execute()
        {
            int[] arr = { 2, 7, 11, 34, 3, 2 };
            Two_Sum twoSum = new Two_Sum();
            int[] result = twoSum.TwoSum(arr, 9);
            result.ToList().ForEach(i => Console.Write($"{i}\t"));
        }
    }
}
