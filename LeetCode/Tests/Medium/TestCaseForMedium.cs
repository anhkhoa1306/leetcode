using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Medium;
using LeetCode.Utilities;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class TestCaseForMedium
    {
        [Fact]
        public void RemoveDuplicatesFromSortedListII_Ok()
        {
            var rs = RemoveDuplicatesFromSortedListII.Solution(new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))))));
            Assert.True(rs != null);
        }

        [Fact]
        public void JumpGame_Ok()
        {
            var rs = JumpGame.Solution(new int[] { 3, 2, 1, 0, 4 });
            Assert.False(rs);
        }

        [Fact]
        public void JumpGameII_Ok()
        {
            var rs = JumpGameII.Solution(new int[] { 2, 3, 1, 1, 4, 5, 6 });
            Assert.True(rs == 3);
        }

        [Fact]
        public void LongestSubstringWithoutRepeatingCharacters_Ok()
        {
            var rs = LongestSubstringWithoutRepeatingCharacters.Solution("pwwkew");
            Assert.True(rs == 3);
        }
    }
}
