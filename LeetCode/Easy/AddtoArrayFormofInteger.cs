using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/add-to-array-form-of-integer/
    /// </summary>
    public class AddtoArrayFormofInteger
    {
        public static IList<int> Solution(int[] num, int k)
        {
            var list = new List<int>();

            var carrier = 0;

            var listOfK = new List<int>();
            while (k > 0)
            {
                listOfK.Add(k % 10);
                k = k / 10;
            }

            var i = num.Length - 1;
            var j = 0;
            while (i >= 0 || j < listOfK.Count)
            {
                var firstNumber = i >= 0 ? num[i] : 0;
                var secondNumber = j < listOfK.Count ? listOfK[j] : 0;
                var sum = firstNumber + secondNumber + carrier;
                list.Add(sum % 10);
                carrier = sum / 10;
                i--;
                j++;
            }

            if (carrier > 0)
            {
                list.Add(carrier);
            }

            list.Reverse();

            return list;
        }
    }
}
