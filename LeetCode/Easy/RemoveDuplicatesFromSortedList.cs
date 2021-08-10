using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    /// </summary>
    public class RemoveDuplicatesFromSortedList
    {
        public static ListNode Solution(ListNode head)
        {
            var current = head;
            var previous = head;

            while (current != null)
            {
                var currentValue = current.Value;
                if (previous.Value != currentValue)
                {
                    previous.Next = current;
                    previous = previous.Next;
                }
                current = current.Next;
                if (previous.Value == currentValue)
                {
                    previous.Next = null;
                }
            }
            return head;
        }
    }
}
