using System.Collections.Generic;
using Xunit;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (var index = 0; index < nums.Length; index++)
            {
                var key = target - nums[index];
                if (dictionary.ContainsKey(key))
                {
                    return new int[] { dictionary[key], index };
                }
                dictionary.Add(nums[index], index);
            }
            return new int[2];
        }
    }
}
