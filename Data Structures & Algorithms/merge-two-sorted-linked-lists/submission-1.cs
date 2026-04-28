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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = null;
        ListNode current = null;
        var head1 = list1;
        var head2 = list2;
        
        if(head1 == null && head2 == null) return null;

        if(head1 == null){
            head = head2;
            current = head2;
            head2 = head2.next;
        }
        else if( head2 == null){
            head = head1;
            current = head1;
            head1 = head1.next;
        }
        else{
            if(head1.val <= head2.val){
                head = head1;
                current = head1;
                head1 = head1.next;
            }
            else{
                head = head2;
                current = head2;
                head2 = head2.next;
            }
        }

        while(head1 != null || head2 != null){
            if(head1 == null){
                current.next = head2;
                current = current.next;
                head2 = head2.next;
            }
            else if(head2 == null){
                current.next = head1;
                current = current.next;
                head1 = head1.next;
            }
            else{
                if(head1.val <= head2.val){
                    current.next = head1;
                    current = current.next;
                    head1 = head1.next;
                }
                else{
                    current.next = head2;
                    current = current.next;
                    head2 = head2.next;
                }
            }
        }

        return head;
    }
}