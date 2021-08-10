using System.Collections.Generic;
using System.Net.Http.Headers;

namespace LeetCode.DP
{
    public class CanConstruct
    {
        public static bool Solution(string target, string[] wordBank, Dictionary<string, bool> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<string, bool>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            if (string.IsNullOrEmpty(target))
            {
                return true;
            }

            foreach (var word in wordBank)
            {
                if (target.IndexOf(word) == 0)
                {
                    var suffix = target.Substring(word.Length);
                    var check = Solution(suffix, wordBank, memo);
                    if (check)
                    {
                        if (!memo.ContainsKey(target))
                        {
                            memo.Add(target, true);
                        }
                        return true;
                    }
                }
            }
            if (!memo.ContainsKey(target))
            {
                memo.Add(target, false);
            }
            return false;
        }

        public static bool Tabulation(string target, string[] wordBank)
        {
            var table = new bool[target.Length + 1];
            table[0] = true;

            for (var i = 0; i <= target.Length; i++)
            {
                if (table[i])
                {
                    foreach (var word in wordBank)
                    {
                        if (target.Substring(i, i + word.Length) == word)
                        {
                            var j = i + word.Length;
                            if (j <= target.Length)
                            {
                                table[j] = true;
                            }
                        }
                    }
                }
            }

            return table[target.Length];
        }
    }
}
