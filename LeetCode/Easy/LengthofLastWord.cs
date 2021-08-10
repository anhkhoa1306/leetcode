using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    public class LengthofLastWord
    {
        public static int Solution(string s)
        {
            var total = 0;
            var n = s.Length - 1;
            while (n >= 0)
            {
                var character = s[n];
                if (character == ' ' && total > 0)
                {
                    break;
                }

                if (character != ' ')
                {
                    total++;
                }
                n--;
            }
            return total;
        }
    }
}
