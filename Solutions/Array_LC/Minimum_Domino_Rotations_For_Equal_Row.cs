using System.Collections.Generic;
using System.Linq;

namespace Solutions.Array_LC
{
    public class Minimum_Domino_Rotations_For_Equal_Row
    {
        public int MinDominoRotations(int[] A, int[] B)
        {
            int a = Sub(A, B, A[0]);
            int b = Sub(B, A, A[0]);
            int c = Sub(A, B, B[0]);
            int d = Sub(B, A, B[0]);
            List<int> list = new List<int>() { a, b, c, d };
            list = list.Where(l => l >= 0).ToList();
            if (list.Count == 0)
                return -1;
            return list.OrderBy(l => l).First();
        }

        private int Sub(int[] A, int[] B, int val)
        {
            int count = 0;
            for (int i = 0; i < A.Length; ++i)
            {
                if (A[i] == val)
                    continue;
                if (B[i] == val)
                    count++;
                else
                    return -1;
            }
            return count;
        }
    }
}
