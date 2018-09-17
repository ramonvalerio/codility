using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Implementations.Lesson3
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            var result = int.MaxValue;
            var upperPart = 0;
            var lowerPart = A.Sum();

            for (int i = 1; i < A.Length; i++)
            {
                upperPart += A[i - 1];
                lowerPart -= A[i - 1];

                var currentDifference = Math.Abs(upperPart - lowerPart);

                if (currentDifference < result)
                    result = currentDifference;
            }

            return result;
        }

        public int solution2(int[] A)
        {
            var places = new SortedSet<int>();

            int currentIndex = 0;
            int firstValue = 0;
            int accum = 0;

            int total = A.Length;
            int i = 0;

            while (i < total && currentIndex < total - 1)
            {
                if (i == currentIndex)
                    firstValue += A[i];
                else if (i > currentIndex)
                    accum += A[i];

                if (i == total - 1)
                {
                    places.Add(Math.Abs(firstValue - accum));
                    currentIndex++;
                    i = currentIndex;
                    accum = 0;
                }
                else
                    i++;
            }

            return places.Min();
        }
    }
}
