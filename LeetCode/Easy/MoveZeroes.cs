using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/
    /// </summary>
    public class MoveZeroes
    {
        public static void Solution(int[] nums)
        {
            var i = 0;
            for (var j = 0; j < nums.Length; j++)
            {
                var number = nums[j];
                if (number != 0)
                {
                    var current = nums[i];
                    nums[i] = number;
                    nums[j] = current;
                    i++;
                }
            }
        }
    }
}
