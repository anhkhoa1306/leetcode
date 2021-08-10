using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://www.programmersought.com/article/51466642015/
    /// </summary>
    public class ParkingDilemma
    {
        public static int Solution(int[] parkingLots, int numberOfCarCovered)
        {
            var sortedParkingLots = parkingLots.OrderBy(p => p).ToArray();
            var totalParkingLots = sortedParkingLots.Count();
            var minDistance = sortedParkingLots[numberOfCarCovered - 1] - sortedParkingLots[0];
            for (var index = 1; index <= totalParkingLots - numberOfCarCovered; index++)
            {
                var a = sortedParkingLots[numberOfCarCovered - 1 + index] - sortedParkingLots[index];
                if (minDistance > a)
                {
                    minDistance = a;
                }
            }

            return minDistance;
        }
    }
}
