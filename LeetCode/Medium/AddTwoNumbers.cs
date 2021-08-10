using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            var remainder = 0;

            var result = new ListNode(0);

            var currentNode = result;

            while (l1 != null || l2 != null)
            {
                var sum = (l1 is null ? 0 : l1.Value) + (l2 is null ? 0 : l2.Value) + remainder;

                currentNode.Next = new ListNode(sum % 10);
                currentNode = currentNode.Next;
                remainder = sum / 10;

                if (l1 != null)
                {
                    l1 = l1.Next;
                }
                if (l2 != null)
                {
                    l2 = l2.Next;
                }
            }

            if (remainder > 0)
            {
                currentNode.Next = new ListNode(remainder);
            }

            return result.Next;
        }
    }
}
