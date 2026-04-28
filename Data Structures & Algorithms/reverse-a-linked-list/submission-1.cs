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
    public ListNode ReverseList(ListNode head) {
        var stk = new Stack<ListNode>();

        var current = head;

        if(head == null) return null;
        while(current != null){
            stk.Push(current);
            current = current.next;
        }

        var result = stk.Pop();
        var currentResult = result;
        while(stk.Count > 0){
            currentResult.next = stk.Pop();
            currentResult = currentResult.next;
        }
        currentResult.next = null;

        return result;
    }
}
