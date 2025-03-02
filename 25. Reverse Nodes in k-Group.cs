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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k == 1) return head;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prevGroupEnd = dummy;
        ListNode current = head;
        while(true){
            ListNode kthNode = prevGroupEnd;
            for(int i=0;i<k && kthNode != null; i++){
                kthNode = kthNode.next;
            }
            if(kthNode == null) break;
            ListNode groupStart = prevGroupEnd.next;
            ListNode nextGroupStart = kthNode.next;
            ListNode prev = nextGroupStart;
            ListNode curr = groupStart;

            for (int i = 0; i < k; i++) {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            prevGroupEnd.next = prev;
            prevGroupEnd = groupStart;
        }
        return dummy.next; 
        
    }
}
