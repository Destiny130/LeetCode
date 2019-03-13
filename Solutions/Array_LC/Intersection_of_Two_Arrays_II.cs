using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Intersection_of_Two_Arrays_II
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in nums1)
            {
                if (dic.ContainsKey(i))
                    ++dic[i];
                else
                    dic[i] = 1;
            }
            foreach (int i in nums2)
            {
                if (dic.ContainsKey(i) && dic[i] > 0)
                {
                    list.Add(i);
                    --dic[i];
                }
            }
            return list.ToArray();
        }
    }
}
