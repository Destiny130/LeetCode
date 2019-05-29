using System.Collections.Generic;

namespace Solutions.BinaryTree_LC
{
    public class Same_Tree
    {
        public bool IsSameTree_Recursive(TreeNode p, TreeNode q)
        {
            if (p == null || q == null)
                return p == q;
            if (p.val != q.val)
                return false;
            return IsSameTree_Recursive(p.left, q.left) && IsSameTree_Recursive(p.right, q.right);
        }

        public bool IsSameTree_Iterative(TreeNode p, TreeNode q)
        {
            if (!SameTree(p, q))
                return false;
            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            queue1.Enqueue(p);
            queue2.Enqueue(q);
            while (queue1.Count != 0 && queue2.Count != 0)
            {
                TreeNode curr1 = queue1.Dequeue();
                TreeNode curr2 = queue2.Dequeue();
                if (!SameTree(curr1, curr2))
                    return false;
                if (curr1 != null)
                {
                    queue1.Enqueue(curr1.left);
                    queue1.Enqueue(curr1.right);
                }
                if (curr2 != null)
                {
                    queue2.Enqueue(curr2.left);
                    queue2.Enqueue(curr2.right);
                }
            }
            return queue1.Count == queue2.Count;
        }

        private bool SameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null)
                return p == q;
            return p.val == q.val;
        }
    }
}
