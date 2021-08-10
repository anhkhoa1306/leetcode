using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game-ii/
    /// </summary>
    public class JumpGameII
    {
        public static int Solution(int[] nums)
        {
            //var rs = DpSolution(nums, 0);
            var rs = GreedySolution(nums);
            return rs;
        }

        //2,3,1,0,4
        private static int DpSolution(int[] nums, int index, Dictionary<int, int> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<int, int>();
            }

            if (memo.ContainsKey(index))
            {
                return memo[index];
            }

            if (index == nums.Length - 1)
            {
                return 0;
            }

            var minSteps = int.MaxValue;

            for (var i = 1; i <= nums[index]; i++)
            {
                var steps = i + index;
                if (steps > nums.Length - 1)
                {
                    break;
                }

                minSteps = Math.Min(minSteps, 1 + DpSolution(nums, index + 1, memo));
            }

            if (!memo.ContainsKey(index))
            {
                memo.Add(index, minSteps);
            }
            return minSteps;
        }

        public static int GreedySolution(int[] nums)
        {
            var result = 0;

            var left = 0;
            var right = 0;

            while (right < nums.Length - 1)
            {
                var farthes = 0;
                for (var i = left; i < right + 1; i++)
                {
                    farthes = Math.Max(farthes, nums[i] + i);
                }

                left = right + 1;
                right = farthes;
                result++;
            }

            return result;
        }
    }
}
