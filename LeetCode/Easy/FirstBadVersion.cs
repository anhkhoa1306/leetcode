using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/first-bad-version/
    /// </summary>
    public class FirstBadVersion
    {
        private static bool IsBadVersion(int version)
        {
            return version == 3;
        }
        public static int Solution(int n)
        {
            var left = 1;
            var right = n;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}
