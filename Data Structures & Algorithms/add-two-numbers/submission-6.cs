public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // build strings from linked lists (already reversed, so just read them)
        string s1 = "", s2 = "";
        while (l1 != null) { s1 += l1.val; l1 = l1.next; }
        while (l2 != null) { s2 += l2.val; l2 = l2.next; }

        // s1 and s2 are now the numbers in reverse order as strings
        // add digit by digit with carry
        int i = 0, carry = 0;
        ListNode dummy = new ListNode();
        var temp = dummy;

        while (i < s1.Length || i < s2.Length || carry != 0) {
            int d1 = i < s1.Length ? (s1[i] - '0') : 0;
            int d2 = i < s2.Length ? (s2[i] - '0') : 0;
            int sum = d1 + d2 + carry;
            carry = sum / 10;
            temp.next = new ListNode(sum % 10);
            temp = temp.next;
            i++;
        }

        return dummy.next;
    }
}
