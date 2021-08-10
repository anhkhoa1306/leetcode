using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters
    {
        //dvdf
        //pwwekw
        public static int Solution(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var max = 0;

            var dic = new Dictionary<char, int>();

            var i = 0;
            var j = 0;
            while (i < s.Length)
            {
                var character = s[i];
                while (dic.ContainsKey(character))
                {
                    dic.Remove(s[j]);
                    j++;
                }

                max = Math.Max(max, i - j + 1);
                dic.Add(character, i);
                i++;
            }

            return max;
        }
    }
}
