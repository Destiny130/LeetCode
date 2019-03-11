namespace Solutions.BinaryTree_LC
{
    public class Construct_Binary_Search_Tree_from_Preorder_Traversal
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            return Build(preorder, 0, preorder.Length - 1);
        }

        private TreeNode Build(int[] arr, int low, int high)
        {
            if (low > high)
                return null;
            if (low == high)
                return new TreeNode(arr[low]);
            TreeNode node = new TreeNode(arr[low]);
            if (arr[high] < arr[low])
            {
                node.right = null;
                node.left = Build(arr, low + 1, high);
            }
            else if (arr[low + 1] > arr[low])
            {
                node.left = null;
                node.right = Build(arr, low + 1, high);
            }
            else
            {
                int mid = low + 1;
                while (arr[mid] < arr[low])
                    mid++;
                node.left = Build(arr, low + 1, mid - 1);
                node.right = Build(arr, mid, high);
            }
            return node;
        }
    }
}
