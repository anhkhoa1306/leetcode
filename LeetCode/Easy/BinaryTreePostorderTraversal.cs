using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-postorder-traversal/
    /// </summary>
    public class BinaryTreePostorderTraversal
    {
        public static IList<int> Solution(TreeNode root)
        {
            if (root is null)
            {
                return new List<int>();
            }

            var rs = new List<int>();
            var leftCollection = Solution(root.left);
            if (leftCollection.Any())
            {
                rs.AddRange(leftCollection);
            }

            var rightCollection = Solution(root.right);
            if (rightCollection.Any())
            {
                rs.AddRange(rightCollection);
            }
            rs.Add(root.val);

            return rs;
        }

        //1
        //2  3
        //4 5 6
        private static IList<int> SolutionWithStack(TreeNode root)
        {
            if (root is null)
            {
                return new List<int>();
            }
            var rs = new List<int>();

            var outPutStack = new Stack<int>();

            var stack = new Stack<TreeNode>();

            stack.Push(root);

            while (stack.TryPeek(out _))
            {
                var node = stack.Pop();
                outPutStack.Push(node.val);
                if (node.left != null)
                {
                    stack.Push(node.left);
                }

                if (node.right != null)
                {
                    stack.Push(node.right);
                }
            }

            while (outPutStack.TryPop(out var value))
            {
                rs.Add(value);
            }

            return rs;
        }
    }
}
