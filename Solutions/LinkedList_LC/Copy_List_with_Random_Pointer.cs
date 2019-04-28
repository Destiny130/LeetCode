namespace Solutions.LinkedList_LC
{
    class Copy_List_with_Random_Pointer
    {
        /*
        A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.
        Return a deep copy of the list.
        */

        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;
            Node curr = head;
            while (curr != null)
            {
                Node node = new Node(curr.val, curr.next, null);
                curr.next = node;
                curr = node.next;
            }

            curr = head;
            while (curr != null)
            {
                if (curr.random != null)
                    curr.next.random = curr.random.next;
                curr = curr.next.next;
            }

            curr = head;
            Node ans = curr.next;
            Node temp = ans;
            while (curr != null)
            {
                curr.next = temp.next;
                curr = curr.next;
                if (curr == null)
                    break;
                temp.next = curr.next;
                temp = temp.next;
            }
            return ans;
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node()
        {

        }

        public Node(int _val, Node _next, Node _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }
}
