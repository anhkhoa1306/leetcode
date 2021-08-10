using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    public class LongestIncreasingSubsequence
    {
        public static int Solution(List<int> A)
        {
            if (A.Count == 1)
            {
                return 1;
            }
            
            var stack = new Stack<int>();

            foreach (var num in A)
            {
                if (stack.Count == 0)
                {
                    stack.Push(num);
                }
                else
                {
                    var item = stack.Peek();
                    if (num == item)
                    {
                        continue;
                    }
                    if (num < item)
                    {
                        stack.Pop();
                    }
                    stack.Push(num);
                }
            }

            return stack.Count;
        }
    }
}
