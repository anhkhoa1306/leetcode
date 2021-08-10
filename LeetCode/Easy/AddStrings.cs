using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/add-strings/
    /// </summary>
    public class AddStrings
    {
        public static string Solution(string num1, string num2)
        {
            var carrier = 0;
            var indexOfFirst = num1.Length - 1;
            var indexOfSecond = num2.Length - 1;
            var result = new StringBuilder();
            while (indexOfFirst >= 0 || indexOfSecond >= 0)
            {
                var x = indexOfFirst >= 0 ? num1[indexOfFirst] - '0' : 0;
                var y = indexOfSecond >= 0 ? num2[indexOfSecond] - '0' : 0;
                var sum = (x + y + carrier) % 10;
                carrier = (x + y + carrier) / 10;
                result.Append(sum);
                indexOfFirst--;
                indexOfSecond--;
            }

            if (carrier > 0)
            {
                result.Append(carrier);
            }

            var charArray = result.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
