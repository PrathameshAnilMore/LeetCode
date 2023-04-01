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
    public bool IsPalindrome(ListNode head) {
      
        ListNode clone = head;
        ListNode reversed = null;
		//reverse the linked list using a clone of the head 
        while(clone != null){
            ListNode temp = new ListNode(clone.val);
            temp.next = reversed;
            clone = clone.next;
            reversed = temp;
        }
		//compare the original LL with the reversed LL 
        while(head != null && reversed != null){
            if(head.val != reversed.val)
                return false;
            head = head.next;
            reversed = reversed.next;
        }
        return true;
    
        
    }
}