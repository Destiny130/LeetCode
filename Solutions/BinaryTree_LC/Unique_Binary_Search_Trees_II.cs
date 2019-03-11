using System.Collections.Generic;

namespace Solutions.BinaryTree_LC
{
    public class Unique_Binary_Search_Trees_II
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n < 1)
                return new List<TreeNode>();
            List<TreeNode>[,] dp = new List<TreeNode>[n + 2, n + 2];
            return Build(1, n, dp);
        }

        private List<TreeNode> Build(int low, int high, List<TreeNode>[,] dp)
        {
            if (dp[low, high] != null)
                return dp[low, high];

            List<TreeNode> list = new List<TreeNode>();
            if (low > high)
            {
                list.Add(null);
                return list;
            }

            for (int i = low; i <= high; ++i)
            {
                List<TreeNode> left = Build(low, i - 1, dp);
                List<TreeNode> right = Build(i + 1, high, dp);
                left.ForEach((l) =>
                {
                    right.ForEach((r) =>
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = l;
                        root.right = r;
                        list.Add(root);
                    });
                });
            }
            dp[low, high] = list;
            return list;
        }
    }
}
