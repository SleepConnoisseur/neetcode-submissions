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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;

        var node = head;
        int count = 0;
        var stk = new Stack<ListNode>();
        var que = new Queue<ListNode>();

        // Store nodes in stack and queue
        while (node != null) {
            count++;
            stk.Push(node);
            que.Enqueue(node);
            node = node.next;
        }

        ListNode current = que.Dequeue();  // Start with the head of the list

        for (int i = 0; i < count / 2; i++) {
            var fromQueue = que.Dequeue();
            var fromStack = stk.Pop();

            // Reordering nodes
            current.next = fromStack;  
            fromStack.next = fromQueue;  
            current = fromQueue;
        }

        // If count is odd, the middle element should point to null
        current.next = null;
    }
}
