using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class RemoveDuplicatesFromSortedArray
    {
        public static int Solution(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length;
            }

            var i = 0;
            var j = i + 1;
            while (j < nums.Length)
            {
                var current = nums[j];
                var front = nums[i];
                if (front != current)
                {
                    i++;
                    nums[i] = current;
                }
                j++;
            }
            return i + 1;
        }
    }
}
