using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.BinaryTree_LC
{
    public class Increasing_Order_Search_Tree
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
                return null;
            List<int> list = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                list.Add(root.val);
                root = root.right;
            }
            root = new TreeNode(list[0]);
            TreeNode temp = root;
            for (int i = 1; i < list.Count; ++i)
            {
                temp.right = new TreeNode(list[i]);
                temp = temp.right;
            }
            return root;
        }
    }
}
