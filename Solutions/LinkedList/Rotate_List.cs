namespace Solutions.LinkedList
{
    public class Rotate_List
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0)
                return head;
            int len = 0;
            ListNode curr = head;
            for (; curr != null; ++len)
                curr = curr.next;
            k %= len;
            if (k == 0)
                return head;
            ListNode fast = head;
            --k;
            for (; k > 0; --k)
                fast = fast.next;

            curr = head;
            ListNode prev = null;
            while (fast.next != null)
            {
                fast = fast.next;
                prev = curr;
                curr = curr.next;
            }
            fast.next = head;
            prev.next = null;
            return curr;
        }
    }
}
