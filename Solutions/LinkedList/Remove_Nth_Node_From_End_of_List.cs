namespace Solutions.LinkedList
{
    public class Remove_Nth_Node_From_End_of_List
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode fast = dummy.next;
            for (int i = 0; i < n; ++i)
                fast = fast.next;
            ListNode slow = dummy;
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            slow.next = slow.next.next;
            return dummy.next;
        }
    }
}
