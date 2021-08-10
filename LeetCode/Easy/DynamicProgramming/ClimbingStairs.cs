using System.Collections.Generic;

namespace LeetCode.Easy.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    public class ClimbingStairs
    {
        public static int Solution(int n, int[] steps, Dictionary<int, int> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<int, int>();
            }

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            if (n < 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            var total = 0;
            foreach (var step in steps)
            {
                var remainder = n - step;
                var temp = Solution(remainder, steps, memo);
                total += temp;
            }

            if (!memo.ContainsKey(n))
            {
                memo.Add(n, total);
            }
            return total;
        }
    }
}
