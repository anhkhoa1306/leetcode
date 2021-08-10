using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace LeetCode
{
    public class OrangeLogic
    {
        public static void First(int N)
        {
            int enable_print = N % 10;
            while (N > 0)
            {
                if (enable_print == 0 && N % 10 != 0)
                {
                    enable_print = 1;
                }

                if (enable_print != 0)
                {
                    Console.Write(N % 10);
                }

                N = N / 10;
            }
        }

        public static int Second(int[] A, int[] B, int X, int Y)
        {
            var totalPoints = A.Length;

            for (var index = 0; index < totalPoints; index++)
            {
                var distance = Math.Sqrt(Math.Pow(A[index] - X, 2) + Math.Pow(B[index] - Y, 2));
                if (distance <= 20)
                {
                    return index;
                }
            }

            return -1;
        }

        private static int zeros = 0;

        public static void Solution(int[][] A, int i, int j, int product, int row, int column)
        {
            if (i == row - 1 && j == column - 1)
            {
                product *= A[i][j];
                zeros = Math.Max(zeros, CountZeros(product));
                return;
            }

            if (i >= A.Length)
                return;
            if (j >= A[0].Length)
                return;

            Solution(A, i + 1, j, product * A[i][j], row, column);

            Solution(A, i, j + 1, product * A[i][j], row, column);
        }

        public static int CountZeros(int number)
        {
            var total = 0;

            while (number > 0 && number % 10 == 0)
            {
                total++;
                number /= 10;
            }

            return total;
        }
    }

}
