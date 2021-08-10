using System.Collections.Generic;

namespace LeetCode.DP
{
    public class GridTraveler
    {
        public static int Solution(int n, int m, Dictionary<string, int> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<string, int>();
            }

            var key = $"{n},{m}";

            if (memo.ContainsKey(key))
            {
                return memo[key];
            }

            if (n == 0 || m == 0)
            {
                return 0;
            }

            if (n == 1 && m == 1)
            {
                return 1;
            }

            memo.Add(key, Solution(n - 1, m, memo) + Solution(n, m - 1, memo));
            return memo[key];
        }

        public static int Tabulation(int n, int m)
        {
            var table = new int[n + 1, m + 1];
            table[1, 1] = 1;
            for (var i = 0; i <= n; i++)
            {
                for (var j = 0; j <= m; j++)
                {
                    var current = table[i, j];
                    var a = i + 1;
                    var b = j + 1;
                    if (a <= n)
                    {
                        table[a, j] += table[i, j];
                    }
                    if (b <= m)
                    {
                        table[i, b] += table[i, j];
                    }
                }
            }

            return table[n, m];
        }
    }
}
