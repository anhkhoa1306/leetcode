using System.Collections.Generic;

namespace LeetCode.DP
{
    public class CountConstruct
    {
        public static int Solution(string target, string[] wordBank, Dictionary<string, int> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<string, int>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            if (string.IsNullOrEmpty(target))
            {
                return 1;
            }

            var total = 0;
            foreach (var word in wordBank)
            {
                if (target.IndexOf(word) == 0)
                {
                    var suffix = target.Substring(word.Length);
                    total += Solution(suffix, wordBank, memo);
                }
            }

            if (!memo.ContainsKey(target))
            {
                memo.Add(target, total);
            }
            return total;
        }
    }
}
