using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class ValidParentheses
    {
        public static bool Solution(string s)
        {
            var length = s.Length;
            if (length % 2 != 0)
            {
                return false;
            }

            var roundParanthese = '(';
            var reverseRoundParanthese = ')';
            var squareBracket = '[';
            var reverseSquareBracket = ']';
            var pointyParanthese = '{';
            var reversePointyParanthese = '}';

            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == roundParanthese || c == squareBracket || c == pointyParanthese)
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Any())
                    {
                        var item = stack.Pop();

                        if (c == reverseRoundParanthese && item != roundParanthese)
                        {
                            return false;
                        }

                        if (c == reverseSquareBracket && item != squareBracket)
                        {
                            return false;
                        }

                        if
                            (c == reversePointyParanthese && item != pointyParanthese)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
