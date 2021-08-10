using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game/
    /// </summary>
    public class JumpGame
    {
        public static bool Solution(int[] nums)
        {
            //var rs = RecursiveSolution(nums, 0);

            var rs = GreedySolution(nums);

            return rs;
        }

        private static bool RecursiveSolution(int[] nums, int index, Dictionary<int, bool> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<int, bool>();
            }

            if (memo.ContainsKey(index))
            {
                return memo[index];
            }

            if (index == nums.Length - 1)
            {
                return true;
            }

            if (index >= nums.Length)
            {
                return false;
            }

            var maximumSteps = nums[index];

            while (maximumSteps > 0)
            {
                var check = RecursiveSolution(nums, index + maximumSteps, memo);

                if (!memo.ContainsKey(index))
                {
                    memo.Add(index, check);
                }

                if (check)
                {
                    return true;
                }

                maximumSteps--;
            }

            if (!memo.ContainsKey(index))
            {
                memo.Add(index, false);
            }

            return false;
        }

        private static bool GreedySolution(int[] nums)
        {
            var goal = nums.Length - 1;
            for (var index = nums.Length - 1; index >= 0; index --)
            {
                var steps = index + nums[index];
                if (steps >= goal)
                {
                    goal = index;
                }
            }

            return goal == 0;
        }
    }
}
