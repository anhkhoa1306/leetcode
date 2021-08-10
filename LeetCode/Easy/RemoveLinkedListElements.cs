using LeetCode.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-linked-list-elements/
    /// </summary>
    public class RemoveLinkedListElements
    {
        public static ListNode Solution(ListNode head, int val)
        {
            var current = head;
            ListNode previous = null;
            while (current != null)
            {
                if (current.Value == val)
                {
                    if (previous is null)
                    {
                        head = head.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                }
                else
                {
                    previous = current;
                }
                current = current.Next;
            }
            return head;
        }
    }
}
