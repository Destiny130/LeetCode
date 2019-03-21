using System.Collections.Generic;
using System.Linq;

namespace Solutions.DP_LC
{
    public class Unique_Paths_II
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int n = obstacleGrid.GetLength(0);
            int m = obstacleGrid.GetLength(1);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Find(obstacleGrid, m, n, dic);
            return obstacleGrid[0, 0] == 1 ? 0 : dic.Last().Value;
        }

        private int Find(int[,] matrix, int m, int n, Dictionary<string, int> dic)
        {
            string key = m.ToString() + "," + n.ToString();
            if (!dic.ContainsKey(key))
            {
                if (m < 1 || n < 1)
                    dic[key] = 0;
                else if (m == 1 && n == 1)
                    dic[key] = matrix[n - 1, m - 1] == 1 ? 0 : 1;
                else if (matrix[n - 1, m - 1] == 1)
                    dic[key] = 0;
                else if ((m == 1 && n == 2) || (n == 1 && m == 2))
                    dic[key] = 1;
                else
                    dic[key] = Find(matrix, m - 1, n, dic) + Find(matrix, m, n - 1, dic);
            }
            return dic[key];
        }
    }
}
