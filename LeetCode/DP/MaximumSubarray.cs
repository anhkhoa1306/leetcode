using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DP
{
    public class MaximumSubarray
    {
        public static int Solution(int[] nums)
        {
            var result = MaxIndex(nums, 0, nums.Length - 1);
            return result;
        }

        private static int MaxIndex(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return nums[left];
            }

            var mid = (left + right) / 2;
            var maxLeft = MaxIndex(nums, left, mid);
            var maxRight = MaxIndex(nums, mid + 1, right);
            return Math.Max(maxLeft, maxRight);
        }
    }
}
