using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public class RemoveElement
    {
        public static int Solution(int[] nums, int val)
        {
            var i = 0;
            for (var j = 0; j < nums.Length; j++)
            {
                var number = nums[j];
                if (number != val)
                {
                    nums[i] = number;
                    i++;
                }
            }
            return i;
        }
    }
}
