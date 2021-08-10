using System.Collections.Generic;

namespace LeetCode.DP
{
    public class BestSum
    {
        public static int[] Solution(int target, int[] numbers, Dictionary<int, int[]> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<int, int[]>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }
            if (target == 0)
            {
                return new int[0];
            }

            if (target < 0)
            {
                return null;
            }

            int[] shortestArray = null;

            foreach (var num in numbers)
            {
                var remainder = target - num;
                var combination = Solution(remainder, numbers);
                var result = new List<int> {remainder};
                result.AddRange(combination);
                if (shortestArray is null || shortestArray.Length < result.Count)
                {
                    shortestArray = result.ToArray();
                }
            }

            if (!memo.ContainsKey(target))
            {
                memo.Add(target, shortestArray);
            }
            return shortestArray;
        }

        public static int[] Tabulation(int target, int[] numbers)
        {
            var table = new List<List<int>>(target + 1);
            table[0] = new List<int>();
            for (var i = 0; i <= target; i++)
            {
                if (table[i] != null)
                {
                    foreach (var number in numbers)
                    {
                        var j = i + number;
                        if (j <= target)
                        {
                            var combination = new List<int>(table[i]) {number};
                            if (table[j] is null || table[j].Count > combination.Count)
                            {
                                table[j] = combination;
                            }
                        }
                    }
                }
            }

            return table[target].ToArray();
        }
    }
}
