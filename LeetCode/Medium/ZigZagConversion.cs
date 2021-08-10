using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/zigzag-conversion/
    /// </summary>
    public class ZigZagConversion
    {
        public static string Solution(string s, int numRows)
        {
            if (s.Length == 1 || numRows == 1)
            {
                return s;
            }

            var totalRows = numRows > s.Length ? s.Length : numRows;

            var listOfRows = new List<StringBuilder>(totalRows);
            while (totalRows > 0)
            {
                listOfRows.Add(new StringBuilder());
                totalRows--;
            }
            var moveDown = false;
            var rowIndex = 0;
            foreach (var character in s)
            {
                listOfRows[rowIndex].Append(character);
                if (rowIndex == 0 || rowIndex == numRows - 1)
                {
                    moveDown = !moveDown;
                }

                rowIndex += moveDown ? 1 : -1;
            }

            var result = new StringBuilder();
            foreach (var row in listOfRows)
            {
                result.Append(row);
            }

            return result.ToString();
        }
        public static string MySolution(string s, int numRows)
        {
            if (s.Length == 1 || numRows == 1)
            {
                return s;
            }

            var totalCharacterToTake = (numRows * 2) - 2;

            var listOfCharacter = new List<List<char>>();

            var counter = 0;

            var subList = new List<char>(totalCharacterToTake);

            for (var i = 0; i < s.Length; i++)
            {
                if (counter < totalCharacterToTake)
                {
                    subList.Add(s[i]);
                    counter++;
                }

                if (subList.Count == totalCharacterToTake)
                {
                    listOfCharacter.Add(subList);
                    subList = new List<char>(totalCharacterToTake);
                    counter = 0;
                }

                if (i == s.Length - 1 && subList.Count != 0)
                {
                    listOfCharacter.Add(subList);
                }
            }
            var result = new StringBuilder();
            var index = 0;
            while (true)
            {
                foreach (var list in listOfCharacter)
                {
                    if (index < list.Count)
                    {
                        result.Append(list[index]);
                        if (index != 0 && index != numRows - 1 && index + 1 < list.Count)
                        {
                            result.Append(list[list.Count - index]);
                        }
                    }
                }

                index++;

                if (result.Length == s.Length)
                {
                    break;
                }
            }

            return result.ToString();
        }
    }
}
