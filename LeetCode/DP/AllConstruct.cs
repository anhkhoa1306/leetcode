using System.Collections.Generic;
using System.Linq;

namespace LeetCode.DP
{
    public class AllConstruct
    {
        public static List<List<string>> Solution(string target, string[] wordBank, Dictionary<string, List<List<string>>> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<string, List<List<string>>>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }
            if (string.IsNullOrEmpty(target))
            {
                return new List<List<string>>();
            }

            List<List<string>> result = new List<List<string>>();

            foreach (var word in wordBank)
            {
                if (target.IndexOf(word) == 0)
                {
                    var suffix = target.Substring(word.Length);
                    var suffixWays = Solution(suffix, wordBank, memo);
                    if (suffixWays != null)
                    {
                        if (suffixWays.Any())
                        {
                            foreach (var subList in suffixWays)
                            {
                                subList.Insert(0, word);
                                result.Add(subList);
                            }
                        }
                        else
                        {
                            result.Add(new List<string> { word });
                        }
                    }
                }
            }

            if (!memo.ContainsKey(target))
            {
                memo.Add(target, result);
            }

            return result.Any() ? result : null;
        }
    }
}
