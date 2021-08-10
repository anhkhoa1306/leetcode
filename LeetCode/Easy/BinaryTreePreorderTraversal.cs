using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    public class BinaryTreePreorderTraversal
    {
        public static IList<int> Solution(TreeNode root)
        {
            if (root is null)
            {
                return new List<int>();
            }
            var rs = new List<int> { root.val };
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
            return rs;
        }

            //1
           //2  3
        // 4 5 6
        private static IList<int> SolutionWithStack(TreeNode root)
        {
            if (root is null)
            {
                return new List<int>();
            }
            var rs = new List<int>();

            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.TryPeek(out _))
            {
                var node = stack.Pop();
                if (node != null)
                {
                    rs.Add(node.val);
                    stack.Push(node.right);
                    stack.Push(node.left);
                }
            }

            return rs;
        }
    }
}
