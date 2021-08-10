using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/
    /// </summary>
    public class PlusOne
    {
        public static int[] Solution(int[] digits)
        {
            var carrier = 1;
            var i = digits.Length - 1;
            while (i >= 0 && carrier > 0)
            {
                var sum = digits[i] + 1;
                digits[i] = sum % 10;
                carrier = sum / 10;
                i--;
            }

            if (carrier == 0)
            {
                return digits;
            }

            var rs = new int[digits.Length + 1];
            rs[0] = carrier;
            for (var j = 0; j < digits.Length; j++)
            {
                rs[j + 1] = digits[j];
            }
            return rs;
        }
    }
}
