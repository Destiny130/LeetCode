using System;
using System.Linq;
using Solutions.Array_LC;

namespace TestCases.Array_LC
{
    public class Two_Sum_Test
    {
        public void Execute()
        {
            Console.WriteLine($"\n{nameof(Two_Sum_Test)}");
            int[] arr = { 2, 7, 11, 34, 3, 2 };
            int target = 9;
            int[] result = new Two_Sum().TwoSum(arr, target);
            Console.WriteLine($"Input array: {String.Join(", ", arr)}, target: {target.ToString()}\nResult: {String.Join(", ", result)}");
        }
    }
}
