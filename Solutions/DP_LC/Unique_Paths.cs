using System.Collections.Generic;
using System.Linq;

namespace Solutions.DP_LC
{
    public class Unique_Paths
    {
        public int UniquePaths(int m, int n)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Find(m, n, dic);
            return dic.Count == 0 ? 1 : dic.Last().Value;
        }

        private int Find(int m, int n, Dictionary<string, int> dic)
        {
            if (m == 1 && n == 1 || m < 1 || n < 1)
                return 0;
            else if ((m == 1 && n == 2) || (n == 1 && m == 2))
                return 1;
            string key = m.ToString() + "," + n.ToString();
            if (!dic.ContainsKey(key))
            {
                dic[key] = Find(m - 1, n, dic) + Find(m, n - 1, dic);
            }
            return dic[key];
        }
    }
}
