using System.Collections.Generic;

namespace Solutions.BinaryTree
{
    public class Binary_Tree_Inorder_Traversal
    {
        //Iterative
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> ans = new List<int>();
            if (root != null)
            {
                Stack<TreeNode> stack = new Stack<TreeNode>();
                TreeNode temp = root;
                while (temp != null || stack.Count > 0)
                {
                    while (temp != null)
                    {
                        stack.Push(temp);
                        temp = temp.left;
                    }
                    temp = stack.Pop();
                    ans.Add(temp.val);
                    temp = temp.right;
                }
            }
            return ans;
        }

        //Recursive
        public IList<int> InorderTraversal_Recursive(TreeNode root)
        {
            IList<int> list = new List<int>();
            Recursive(root, list);
            return list;
        }

        private void Recursive(TreeNode node, IList<int> list)
        {
            if (node != null)
            {
                Recursive(node.left, list);
                list.Add(node.val);
                Recursive(node.right, list);
            }
        }
    }
}
