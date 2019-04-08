using System.Collections.Generic;
using System.Linq;

namespace Solutions.DP_LC
{
    public class Unique_Paths
    {
        /*
        A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
        The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
        How many possible unique paths are there?
        */

        public int UniquePaths_Dic(int m, int n)
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

        //Start point to end point
        public int UniquePaths_1(int m, int n)
        {
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; ++i)
                matrix[i, 0] = 1;
            for (int i = 0; i < n; ++i)
                matrix[0, i] = 1;
            for (int i = 1; i < m; ++i)
                for (int j = 1; j < n; ++j)
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            return matrix[m - 1, n - 1];
        }

        public int UniquePaths(int m, int n)
        {
            int[,] dp = new int[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == 0)
                        dp[0, j] = 1;
                    else if (j == 0)
                        dp[i, 0] = 1;
                    else
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }
            return dp[m - 1, n - 1];
        }
    }
}
