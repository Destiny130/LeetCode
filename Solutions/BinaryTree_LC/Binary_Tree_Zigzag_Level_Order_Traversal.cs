using System.Collections.Generic;
using System.Linq;

namespace Solutions.BinaryTree_LC
{
    public class Binary_Tree_Zigzag_Level_Order_Traversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool flag = false;
            while (queue.Count != 0)
            {
                int cnt = queue.Count;
                IList<int> list = new List<int>();
                for (int i = 0; i < cnt; ++i)
                {
                    TreeNode curr = queue.Dequeue();
                    list.Add(curr.val);
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                }
                if (!flag)
                    list = list.Reverse().ToList();
                flag = !flag;
                result.Add(list);
            }
            return result;
        }
    }
}
