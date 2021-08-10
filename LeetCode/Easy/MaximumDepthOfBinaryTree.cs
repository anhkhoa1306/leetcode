using System;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    public class MaximumDepthOfBinaryTree
    {
        public static int Solution(TreeNode root)
        {
            var rs = MaxDepth(root);

            return rs;
        }

        private static int MaxDepth(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            if (root.left is null && root.right is null)
            {
                return 1;
            }

            var max = 1;

            var maxLeft = MaxDepth(root.left);
            var maxRight = MaxDepth(root.right);
            max += Math.Max(maxLeft, maxRight);

            return max;
        }
    }
}
