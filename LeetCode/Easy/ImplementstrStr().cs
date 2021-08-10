namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/implement-strstr/
    /// </summary>
    public class ImplementstrStr__
    {
        public static int Solution(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (string.IsNullOrEmpty(haystack))
            {
                return -1;
            }

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            var index = needle.Length - 1;
            var previousMatch = haystack.Length;
            while (index >= 0)
            {
                for (var i = previousMatch - 1; i >= 0; i--)
                {
                    if (needle[index] == haystack[i])
                    {
                        if (previousMatch == haystack.Length)
                        {
                            previousMatch = i;
                            break;
                        }

                        if (i < previousMatch - 1)
                        {
                            return -1;
                        }

                        previousMatch = i;
                        break;
                    }
                }

                if (previousMatch == haystack.Length)
                {
                    return -1;
                }
                index--;
            }

            return previousMatch;
        }
    }
}
