using System.Linq;
using LeetCode.Easy;
using LeetCode.Utilities;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class TestCaseForEasy
    {
        [Theory]
        [InlineData(1001)]
        [InlineData(2002)]
        public void IsPalindrome_Ok(int input)
        {
            var result = IsPalindrome.Solution(input);
            Assert.True(result);
        }

        [Fact]
        public void MergeTwoSortedLists_Ok()
        {
            var rs = MergeTwoSortedLists.Solution(new ListNode(1, new ListNode(2, new ListNode(4))),
                new ListNode(1, new ListNode(3, new ListNode(4))));

            Assert.NotNull(rs);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedArray_Ok()
        {
            var rs = RemoveDuplicatesFromSortedArray.Solution(new int[] { 1, 1, 2, 3, 4, 4, 4, 5, 6, 7 });
            Assert.True(rs == 7);
        }

        [Fact]
        public void RemoveElement_Ok()
        {
            var rs = RemoveElement.Solution(new int[] { 1, 1, 2, 3, 4, 4, 4, 5, 6, 7 }, 1);
            Assert.True(rs == 8);
        }

        [Fact]
        public void RemoveLinkedListElements_Ok()
        {
            var rs = RemoveLinkedListElements.Solution(new ListNode(6), 6);
            Assert.True(rs != null);
        }

        [Fact]
        public void SearchInsertPosition_Ok()
        {
            var rs = SearchInsertPosition.Solution(new int[] { 1 }, 0);
            Assert.True(rs == 7);
        }

        [Fact]
        public void GuessNumberHigherorLower_Ok()
        {
            var rs = GuessNumberHigherorLower.Solution(1);
            Assert.True(rs == 6);
        }

        [Fact]
        public void MaximumSubarray_Ok()
        {
            var rs = MaximumSubarray.Solution(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.True(rs == 6);
        }

        [Fact]
        public void LengthofLastWord_Ok()
        {
            var rs = LengthofLastWord.Solution(" ");
            Assert.True(rs == 5);
        }

        [Fact]
        public void PlusOne_Ok()
        {
            var rs = PlusOne.Solution(new int[] { 1, 2, 3 });
            Assert.True(rs.Length == 3);
        }

        [Fact]
        public void AddtoArrayFormofInteger_Ok()
        {
            var rs = AddtoArrayFormofInteger.Solution(new int[] { 1, 2, 0, 0 }, 34);
            Assert.True(rs.Count == 3);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedList_Ok()
        {
            var rs = RemoveDuplicatesFromSortedList.Solution(new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1))))));
            Assert.True(rs != null);
        }

        [Fact]
        public void MergeSortedArray_Ok()
        {
            var nums = new int[] { 1, 2, 3, 0, 0, 0 };
            MergeSortedArray.Solution(nums, 3, new int[] { 2, 5, 6 }, 3);
            Assert.True(nums.Any(n => n == 0) == false);
        }

        [Fact]
        public void SameTree_Ok()
        {
            var rs = SameTree.Solution(new TreeNode(1, new TreeNode(2), new TreeNode(3)), new TreeNode(1, new TreeNode(2), new TreeNode(3)));
            Assert.True(rs);
        }

        [Fact]
        public void SymmetricTree_Ok()
        {
            var rs = SymmetricTree.Solution(new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3))));
            Assert.True(rs);
        }

        [Fact]
        public void MaximumDepthOfBinaryTree_Ok()
        {
            var rs = MaximumDepthOfBinaryTree.Solution(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15, new TreeNode(8)), new TreeNode(7))));
            Assert.True(rs == 4);
        }
    }
}
