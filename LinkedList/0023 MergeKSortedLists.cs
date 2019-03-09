/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0)
            return null;
        if(lists.Length == 1)
            return lists[0];
        List<int> valList = new List<int>();
        for(int i = 0; i < lists.Length; i++){
            ListNode temp = lists[i];
            while(temp != null){
                valList.Add(temp.val);
                temp = temp.next;
            }
        }
        valList.Sort();
        ListNode dummy = new ListNode(0);
        ListNode handler = dummy;
        for(int i = 0; i < valList.Count; i++){
            handler.next = new ListNode(valList[i]);
            handler = handler.next;
        }
        return dummy.next;
    }
}
