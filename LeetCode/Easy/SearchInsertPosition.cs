namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position/
    /// </summary>
    public class SearchInsertPosition
    {
        public static int Solution(int[] nums, int target)
        {
            var rs = DivideAndConquer(nums, target, 0, nums.Length - 1);
            return rs;
        }

        private static int DivideAndConquer(int[] nums, int target, int left, int right)
        {
            if (left == right)
            {
                if (nums[left] < target)
                {
                    return left + 1;
                }

                return left;
            }
            var middle = (left + right) / 2;
            var number = nums[middle];
            if (number > target)
            {
                return DivideAndConquer(nums, target, left, middle);
            }
            else if (number < target)
            {
                return DivideAndConquer(nums, target, middle + 1, right);
            }
            else
            {
                return middle;
            }
        }
    }
}
