public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0 ) return null;
        if(lists.Length == 1 ) return lists[0];

        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        foreach(var x in lists){
            var tail = x;
            while(tail != null){
                queue.Enqueue(tail.val, tail.val);
                tail = tail.next;
            }
        }
        var result = new ListNode(0);
        var resultTail = result;
        while(queue.Count > 0){
            resultTail.next = new ListNode(queue.Dequeue());
            resultTail = resultTail.next;
        }

        return result.next;
    }
}
