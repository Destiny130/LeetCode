namespace Solutions.DFS_LC
{
    public class Number_of_Islands
    {
        /*
        Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
        */

        int m = 0, n = 0;

        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;
            m = grid.Length;
            n = grid[0].Length;
            int count = 0;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == '1')
                    {
                        ++count;
                        DFS(grid, i, j);
                    }
                }
            }
            return count;
        }

        private void DFS(char[][] grid, int i, int j)
        {
            if (i == -1 || j == -1 || i >= m || j >= n || grid[i][j] != '1')
                return;
            grid[i][j] = '0';
            DFS(grid, i + 1, j);
            DFS(grid, i, j + 1);
            DFS(grid, i - 1, j);
            DFS(grid, i, j - 1);
        }
    }
}
