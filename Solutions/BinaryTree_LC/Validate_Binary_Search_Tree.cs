namespace Solutions.BinaryTree_LC
{
    public class Validate_Binary_Search_Tree
    {
        /*
        Given a binary tree, determine if it is a valid binary search tree (BST).
        Assume a BST is defined as follows:
            The left subtree of a node contains only nodes with keys less than the node's key.
            The right subtree of a node contains only nodes with keys greater than the node's key.
            Both the left and right subtrees must also be binary search trees.
        */

        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, null, null);
        }

        private bool IsValidBST(TreeNode curr, TreeNode minNode, TreeNode maxNode)
        {
            if (curr == null)
                return true;
            if ((minNode != null && curr.val <= minNode.val) || (maxNode != null && curr.val >= maxNode.val))
                return false;
            return IsValidBST(curr.left, minNode, curr) && IsValidBST(curr.right, curr, maxNode);
        }
    }
}
