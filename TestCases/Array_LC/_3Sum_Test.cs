using System;
using System.Collections.Generic;
using System.Linq;
using Solutions.Array_LC;

namespace TestCases.Array_LC
{
    public class _3Sum_Test
    {
        public void Execute()
        {
            Console.WriteLine($"\n{nameof(_3Sum_Test)}");
            int[] arr = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result = new _3Sum().ThreeSum(arr);
            Console.WriteLine($"Input array: {String.Join(", ", arr)}");
            Console.WriteLine($"Result: {String.Join("\t", result.Select(r => String.Join(", ", r)))}");
        }
    }
}
