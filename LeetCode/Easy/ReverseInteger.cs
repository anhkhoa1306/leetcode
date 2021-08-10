using System;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    public class ReverseInteger
    {
        public static int Solution(int x)
        {
            if (x > -10 && x < 10)
            {
                return x;
            }

            var lowerRange = Int32.MinValue;
            var upperRange = Int32.MaxValue;
            if (x == lowerRange)
            {
                return 0;
            }

            var isNegative = x < 0;
            x = isNegative ? -x : x;
            
            var remaining = 0;

            while (x != 0)
            {
                var lastDigit = x % 10;
                //if it is greater, and then we add another digit, it will be greater than int32.maxValue
                if (remaining > ((upperRange - lastDigit) / 10))
                {
                    return 0;
                }

                remaining = remaining * 10 + lastDigit;
                x = x / 10;
            }

            return isNegative ? -remaining : remaining;
        }
    }
}
