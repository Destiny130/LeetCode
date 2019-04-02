namespace Solutions.BinaryTree_LC
{
    public class Populating_Next_Right_Pointers_in_Each_Node
    {
        public Node Connect(Node root)
        {
            if (root != null)
                Recursive(root.left, root.right);
            return root;
        }

        private void Recursive(Node left, Node right)
        {
            if (left != null)
            {
                left.next = right;
                Recursive(left.left, left.right);
                Recursive(left.right, right.left);
                Recursive(right.left, right.right);
            }
        }

        public Node Connect_Iterative(Node root)
        {
            if (root == null || root.left == null)
                return root;
            Node temp = root;
            while (temp != null && temp.left != null)
            {
                Node store = temp.left;
                while (temp != null)
                {
                    temp.left.next = temp.right;
                    if (temp.next != null)
                        temp.right.next = temp.next.left;
                    temp = temp.next;
                }
                temp = store;
            }
            return root;
        }
    }
}
