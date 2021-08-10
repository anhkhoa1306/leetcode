using System.Collections.Generic;
using System.Linq;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-inorder-traversal/
    /// </summary>
    public class BinaryTreeInorderTraversal
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

            rs.Add(root.val);

            var rightCollection = Solution(root.right);

            if (rightCollection.Any())
            {
                rs.AddRange(rightCollection);
            }

            return rs;
        }

            //1
          //2 3
        //4 5 6

        private static IList<int> SolutionWithStack(TreeNode root)
        {
            if (root is null)
            {
                return new List<int>();
            }
            var rs = new List<int>();

            var stack = new Stack<TreeNode>();

            var currentNode = root;

            while (currentNode != null || !stack.Any())
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.left;
                }

                currentNode = stack.Pop();
                rs.Add(currentNode.val);
                currentNode = currentNode.right;
            }

            return rs;
        }
    }
}
