using System.Collections.Generic;
using System.Linq;

namespace Solutions.Array_LC
{
    public class Top_K_Frequent_Elements
    {
        public IList<int> TopKFrequent_Map(int[] nums, int k)
        {
            IList<int> result = new List<int>();
            if (nums == null || nums.Length == 0 || k > nums.Length)
                return result;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (dic.ContainsKey(i))
                    ++dic[i];
                else
                    dic[i] = 1;
            }
            result = dic.OrderByDescending(d => d.Value).Take(k).Select(d => d.Key).ToList();
            return result;
        }

        public IList<int> TopKFrequent_Bucket(int[] nums, int k)
        {
            List<int> result = new List<int>();
            if (nums == null || nums.Length == 0 || k > nums.Length)
                return result;
            List<int>[] bucket = new List<int>[nums.Length + 1];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (dic.ContainsKey(i))
                    ++dic[i];
                else
                    dic[i] = 1;
            }

            foreach (int i in dic.Keys)
            {
                if (bucket[dic[i]] == null)
                    bucket[dic[i]] = new List<int>();
                bucket[dic[i]].Add(i);
            }

            for (int i = bucket.Length - 1; i != -1 && result.Count < k; --i)
            {
                if (bucket[i] != null)
                {
                    result.AddRange(bucket[i]);
                }
            }

            return result;
        }
    }
}
