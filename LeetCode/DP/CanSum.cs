using System.Collections.Generic;

namespace LeetCode.DP
{
    public class CanSum
    {
        public static bool Solution(int target, int[] numbers, Dictionary<int, bool> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<int, bool>();
            }

            if (target < 0)
            {
                return false;
            }
            if (target == 0)
            {
                return true;
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            foreach (var num in numbers)
            {
                var remainder = target - num;
                if (Solution(remainder, numbers, memo))
                {
                    if (!memo.ContainsKey(remainder))
                    {
                        memo.Add(remainder, true);
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

        public static bool Tabulation(int target, int[] numbers)
        {
            var boolArray = new bool[target + 1];
            boolArray[0] = true;

            for (var i = 0; i <= target; i++)
            {
                if (boolArray[i])
                {
                    foreach (var number in numbers)
                    {
                        var j = i + number;
                        if (j <= target)
                        {
                            boolArray[j] = true;
                        }
                    }
                }
            }

            return boolArray[target];
        }
    }
}
