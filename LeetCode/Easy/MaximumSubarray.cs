using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    public class MaximumSubarray
    {
        public static int Solution(int[] nums)
        {
            var currentMax = nums[0];
            var globalMax = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                currentMax = Math.Max(nums[i], nums[i] + currentMax);
                if (currentMax > globalMax)
                {
                    globalMax = currentMax;
                }
            }

            return globalMax;
        }
    }
}
