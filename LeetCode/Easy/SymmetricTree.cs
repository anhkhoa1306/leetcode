using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree/
    /// </summary>
    public class SymmetricTree
    {
        public static bool Solution(TreeNode root)
        {
            if (root is null)
            {
                return true;
            }
            var rs = Recursive(root.left, root.right);
            return rs;
        }

        private static bool Recursive(TreeNode left, TreeNode right)
        {
            if (left is null && right is null)
            {
                return true;
            }
            else if (left is null && right != null)
            {
                return false;
            }
            else if (left != null && right is null)
            {
                return false;
            }
            var current = left.val == right.val;
            var leftCorrect = Recursive(left.left, right.right);
            var rightCorrect = Recursive(left.right, right.left);
            return current && leftCorrect && rightCorrect;
        }
    }
}
