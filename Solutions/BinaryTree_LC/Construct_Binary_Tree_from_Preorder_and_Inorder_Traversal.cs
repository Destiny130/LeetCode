namespace Solutions.BinaryTree_LC
{
    public class Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            int inStart = 0, inEnd = inorder.Length - 1, preP = 0;
            return Build(preorder, inorder, inStart, inEnd, preP);
        }

        private TreeNode Build(int[] preA, int[] inA, int inStart, int inEnd, int preP)
        {
            if (inStart > inEnd)
                return null;
            TreeNode node = new TreeNode(preA[preP]);
            int i = inStart;
            while (inA[i] != preA[preP])
                ++i;
            node.left = Build(preA, inA, inStart, i - 1, preP + 1);
            node.right = Build(preA, inA, i + 1, inEnd, preP + i - inStart + 1);
            return node;
        }
    }
}
