namespace LeetCode.Easy
{
    public class IsPalindrome
    {
        public static bool Solution(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var original = x;
            var reverse = 0;
            while (x != 0)
            {
                var lastDigit = x % 10;
                reverse = reverse * 10 + lastDigit;
                x = x / 10;
            }
            return reverse == original;
        }
    }
}
