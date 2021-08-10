using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    public class MergeSortedArray
    {
        public static void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            var i = m - 1;
            var j = n - 1;
            var current = m + n - 1;
            while (j >= 0)
            {
                if (i >= 0 && nums1[i] >= nums2[j])
                {
                    nums1[current] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[current] = nums2[j];
                    j--;
                }

                current--;
            }
        }
    }
}
