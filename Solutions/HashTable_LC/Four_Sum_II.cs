using System.Collections.Generic;

namespace Solutions.HashTable_LC
{
    public class Four_Sum_II
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int a in A)
            {
                foreach (int b in B)
                {
                    if (dic.ContainsKey(a + b))
                        ++dic[a + b];
                    else
                        dic[a + b] = 1;
                }
            }

            int count = 0;
            foreach (int c in C)
            {
                foreach (int d in D)
                {
                    if (dic.ContainsKey(-c - d))
                    {
                        count += dic[-c - d];
                    }
                }
            }

            return count;
        }
    }
}
