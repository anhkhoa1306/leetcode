using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class MergeTwoSortedLists
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            if (l1 is null && l2 is null)
            {
                return null;
            }
            if (l1 is null)
            {
                return l2;
            }

            if (l2 is null)
            {
                return l1;
            }

            if (l1.Value >= l2.Value)
            {
                var current = l2;
                current.Next = Solution(l1, l2.Next);
                l1 = current;
            }
            else
            {
                l1.Next = Solution(l1.Next, l2);
            }

            return l1;
        }
    }
}
