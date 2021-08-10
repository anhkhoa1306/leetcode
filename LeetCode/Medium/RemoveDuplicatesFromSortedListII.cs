using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
    /// </summary>
    public class RemoveDuplicatesFromSortedListII
    {
        public static ListNode Solution(ListNode head)
        {
            if (head is null)
            {
                return head;
            }

            var current = head;
            Stack<int> stack = null;
            var duplicate = false;
            while (current != null)
            {
                var currentValue = current.Value;
                if (stack is null)
                {
                    stack = new Stack<int>();
                    stack.Push(currentValue);
                }
                else
                {
                    if (stack.TryPeek(out var dummy) && dummy == currentValue)
                    {
                        duplicate = true;
                    }
                    else
                    {
                        if (duplicate)
                        {
                            stack.Pop();
                            duplicate = false;
                        }
                        stack.Push(currentValue);
                    }
                }

                current = current.Next;
            }

            if (duplicate)
            {
                stack.Pop();
            }

            ListNode rs = null;

            while (stack.TryPop(out var number))
            {
                if (rs is null)
                {
                    rs = new ListNode(number);
                }
                else
                {
                    var newNode = new ListNode(number, rs);
                    rs = newNode;
                }
            }

            return rs;
        }
    }
}
