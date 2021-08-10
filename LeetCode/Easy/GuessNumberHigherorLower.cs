namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/guess-number-higher-or-lower/
    /// </summary>
    public class GuessNumberHigherorLower
    {
        public static int Solution(int n)
        {
            var left = 1;
            var right = n;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                var rs = guess(mid);
                if (rs == 0)
                {
                    return mid;
                }
                else if (rs < 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private static int guess(int num)
        {
            return num == 1 ? 0 : num < 6 ? 1 : -1;
        }
    }
}
