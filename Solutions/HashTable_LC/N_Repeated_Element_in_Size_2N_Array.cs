using System.Collections.Generic;
using System.Linq;

namespace Solutions.HashTable_LC
{
    public class N_Repeated_Element_in_Size_2N_Array
    {
        public int RepeatedNTimes(int[] A)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in A)
            {
                if (dic.ContainsKey(i))
                    dic[i] += 1;
                else
                    dic.Add(i, 1);
            }
            return dic.Where(d => d.Value == (A.Length / 2)).First().Key;
        }

        //Compare
        public int RepeatedNTimes_Compare(int[] A)
        {
            for (int i = 2; i < A.Length; ++i)
                if (A[i] == A[i - 1] || A[i] == A[i - 2])
                    return A[i];
            return A[0];
        }
    }
}
