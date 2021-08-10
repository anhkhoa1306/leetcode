using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class LongestCommonPrefix
    {
        public static string Solution(string[] strs)
        {
            var totalString = strs.Length;
            if (totalString == 1)
            {
                if (string.IsNullOrEmpty(strs[0]))
                {
                    return "";
                }
                return strs[0].FirstOrDefault().ToString();
            }

            var shortest = strs.OrderBy(s => s.Length).First();

            var index = 0;

            var result = new StringBuilder();

            while (index < shortest.Length)
            {
                var counter = 0;
                foreach (var str in strs)
                {
                    if (str[index] != shortest[index])
                    {
                        break;
                    }

                    counter++;
                }

                if (counter < totalString)
                {
                    break;
                }

                result.Append(shortest[index].ToString());
                index++;
            }

            return result.ToString();
        }
    }
}
