using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/multiply-strings/
    /// </summary>
    public class MultiplyStrings
    {
        public static string Solution(string num1, string num2)
        {
            var result = new StringBuilder();

            var intArray = new int[num1.Length + num2.Length];

            var j = num2.Length - 1;
            while (j >= 0)
            {
                var i = num1.Length - 1;
                while (i >= 0)
                {
                    var currentIndex = i + j + 1;
                    var mutiply = (num2[j] - '0') * (num1[i] - '0');
                    var product = mutiply + intArray[currentIndex];
                    intArray[currentIndex] = product % 10;
                    intArray[currentIndex - 1] += product / 10;
                    i--;
                }
                j--;
            }

            foreach (var number in intArray)
            {
                if (result.Length != 0 || number != 0)
                {
                    result.Append(number);
                }
            }
            return string.IsNullOrEmpty(result.ToString()) ? "0" : result.ToString();
        }
    }
}
