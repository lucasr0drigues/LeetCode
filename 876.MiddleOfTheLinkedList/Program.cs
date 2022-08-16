//Input: head = [1, 2, 3, 4, 5]
//Output: [3,4,5]
ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
ListNode solution = new Solution().MiddleNode(head);

while (solution != null)
{
    Console.WriteLine(solution.val);
    solution = solution.next;
};

Console.WriteLine("");

//Input: head = [1, 2, 3, 4, 5, 6]
//Output: [4,5,6]
ListNode head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
ListNode solution2 = new Solution().MiddleNode(head2);

while (solution2 != null)
{
    Console.WriteLine(solution2.val);
    solution2 = solution2.next;
} ;

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode[] answer = new ListNode[100];
        int i = 0;
        while (head != null)
        {
            answer[i++] = head;
            head = head.next;
        }
        return answer[i / 2];
        //ListNode slow = head, fast = head;
        //while (fast != null && fast.next != null)
        //{
        //    slow = slow.next;
        //    fast = fast.next.next;
        //}
        //return slow;
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