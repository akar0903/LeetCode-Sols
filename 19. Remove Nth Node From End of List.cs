/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
     public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head == null || n < 1) return head; 

        ListNode dummy = new ListNode(0, head); 
        ListNode first = dummy, second = dummy;

        for (int i = 0; i <= n; i++) {
            if (first == null) return head; 
            first = first.next;
        }
        while (first != null) {
            first = first.next;
            second = second.next;
        }
        second.next = second.next.next;

        return dummy.next; 
    }
}
