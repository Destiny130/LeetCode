﻿namespace Solutions.LinkedList_LC
{
    public class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyNode = new ListNode(0);
            ListNode temp = dummyNode;
            int factor = 0;
            while (l1 != null || l2 != null)
            {
                int v1 = l1 == null ? 0 : l1.val;
                int v2 = l2 == null ? 0 : l2.val;
                int sum = v1 + v2 + factor;
                temp.next = new ListNode(sum % 10);
                temp = temp.next;
                factor = sum / 10;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            if (factor == 1)
            {
                temp.next = new ListNode(1);
            }
            return dummyNode.next;
        }
    }
}
