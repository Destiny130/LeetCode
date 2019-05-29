using System.Collections.Generic;
using System.Linq;

namespace Solutions.Backtracking_LC
{
    public class Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int[] arr = Enumerable.Range(1, n).ToArray();
            Backtracing(arr, 0, k, new List<int>(), result);
            return result;
        }

        private void Backtracing(int[] arr, int p, int k, IList<int> list, IList<IList<int>> result)
        {
            if (list.Count == k)
            {
                result.Add(new List<int>(list));
                return;
            }
            for (int i = p; i < arr.Length; ++i)
            {
                list.Add(arr[i]);
                Backtracing(arr, i + 1, k, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
