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
        ListNode newHead = null;
        if(list1 == null && list2 == null) return null;
        else if(list1 == null && list2 != null){
            newHead = list2;
            list2 = list2.next;
        }
        else if(list2 == null && list1 != null){
            newHead = list1;
            list1 = list1.next;
        }
        else if(list1.val <= list2.val){
            newHead = list1;
            list1 = list1.next;
        }
        else if(list1.val > list2.val){
            newHead = list2;
            list2 = list2.next;
        }
   

        var result = newHead;

        while(list1 != null || list2 != null){
            if(list1 == null){
                newHead.next = list2;
                list2 = list2.next;
                newHead = newHead.next;
            }
            else if(list2 == null){
                newHead.next = list1;
                list1 = list1.next;
                newHead = newHead.next;
            }
            else if(list1.val <= list2.val){
                newHead.next = list1;
                list1 = list1.next;
                newHead = newHead.next;
            }
            else if(list1.val > list2.val){
                newHead.next = list2;
                list2 = list2.next;
                newHead = newHead.next;
            }
        }
        return result;
    }
}