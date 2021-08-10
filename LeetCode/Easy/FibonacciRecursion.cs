using System.Collections.Generic;

namespace LeetCode.Easy
{
    public class FibonacciRecursion
    {
        public static int DynamicProgrammingSolution(int f, Dictionary<int, int> memo = null)
        {
            if (memo is null)
            {
                memo = new Dictionary<int, int>();
            }

            if (f <= 1)
            {
                return 1;
            }

            if (memo.ContainsKey(f))
            {
                return memo[f];
            }

            memo.Add(f, DynamicProgrammingSolution(f - 1, memo) + DynamicProgrammingSolution(f - 2, memo));

            return memo[f];
        }

        public static int Solution(int f)
        {
            var table = new int[f + 1];
            table[1] = 1;
            for (var i = 0; i <= f; i++)
            {
                var j = i + 1;
                var k = i + 2;
                if (j <= f)
                {
                    table[j] += table[i];
                }

                if (k <= f)
                {
                    table[k] += table[i];
                }
            }

            return table[f];
        }
    }
}
