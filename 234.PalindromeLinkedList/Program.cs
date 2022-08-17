//Input: head = [1, 2, 2, 1]
//Output: true
ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
Console.WriteLine(new Solution().IsPalindrome(head));

//Input: head = [1, 2]
//Output: false
head = new ListNode(1, new ListNode(2));
Console.WriteLine(new Solution().IsPalindrome(head));


public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        var fast = head;
        var slow = head;

        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        ListNode prev = null;
        ListNode next;

        while(slow != null)
        {
            next = slow.next;
            slow.next = prev;
            prev = slow;
            slow = next;            
        }

        while(prev != null)
        {
            if (head.val != prev.val)
                return false;
            head = head.next;
            prev = prev.next;
        }

        return true;

    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}