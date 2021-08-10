using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public class RomanToInteger
    {
        public static int Solution(string s)
        {
            var romanDictionary = new Dictionary<char, int>
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
            };

            var result = 0;

            var previousNumber = 0;

            for (var index = 0; index < s.Length; index++)
            {
                var number = romanDictionary[s[index]];
                if (index == 0)
                {
                    result = number;
                }
                else
                {
                    if (number > previousNumber)
                    {
                        result += (number - previousNumber * 2);
                    }
                    else
                    {
                        result += number;
                    }
                }

                previousNumber = number;
            }

            return result;
        }
    }
}
