using System.Collections.Generic;
using System.Linq;

namespace LeetCode.DP
{
    public class HowSum
    {
        public static int[] Solution(int target, int[] numbers, Dictionary<int, List<int>> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<int, List<int>>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target].ToArray();
            }
            if (target == 0)
            {
                return new int[0];
            }

            if (target < 0)
            {
                return null;
            }
            foreach (var num in numbers)
            {
                var remainder = target - num;
                var result = Solution(remainder, numbers);
                if (result != null)
                {
                    var list = new List<int> { num };
                    list.AddRange(result);
                    if (!memo.ContainsKey(remainder))
                    {
                        memo.Add(remainder, list);
                    }
                    return list.ToArray();
                }
            }

            if (!memo.ContainsKey(target))
            {
                memo.Add(target, null);
            }

            return null;
        }

        public static int[] Tabulation(int target, int[] numbers)
        {
            var listOfListInt = new List<List<int>>(target + 1);

            listOfListInt[0] = new List<int>();

            for (var i = 0; i <= target; i++)
            {
                if (listOfListInt[i] != null)
                {
                    foreach (var number in numbers)
                    {
                        var j = i + number;
                        if (j <= target)
                        {
                            listOfListInt[j] = new List<int>(listOfListInt[i]) { number };
                        }
                    }
                }
            }

            return listOfListInt[target].ToArray();
        }
    }
}
