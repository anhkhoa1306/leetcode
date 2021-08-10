using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/same-tree/
    /// </summary>
    public class SameTree
    {
        public static bool Solution(TreeNode p, TreeNode q)
        {
            if (p is null && q is null)
            {
                return true;
            }

            if ((p is null && q != null) || (p != null && q is null))
            {
                return false;
            }

            var left = Solution(p.left, q.left);
            var top = p.val == q.val;
            var right = Solution(p.right, q.right);

            return left && top && right;
        }
    }
}
