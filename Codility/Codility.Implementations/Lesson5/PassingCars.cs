using System;
using System.Collections.Generic;

namespace Codility.Implementations.Lesson5
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            var totalPairs = 0;
            var totalOnes = 0;

            var total = A.Length;

            for (int i = total - 1; i >= 0; i--)
            {
                if (A[i] == 0)
                    totalPairs += totalOnes;
                else
                    totalOnes++;

                if (totalPairs > 1000000000)
                    return -1;
            }

            return totalPairs;
        }

        public int solution2(int[] A)
        {
            int result = 0;
            int currentIndext = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[currentIndext] < A[i + 1])
                {
                    result++;
                    currentIndext++;
                }
            }

            return result > 1000000000 ? -1 : result;
        }

        public int solution3(int[] A)
        {
            const int east = 0;
            const int west = 1;

            var carsEast = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == east)
                    carsEast.Add(i);
            }

            var result = new List<Tuple<int, int>>();

            foreach (var carEast in carsEast)
            {
                for(int i = 0; i < A.Length; i++)
                {
                    if (carEast < i && A[i] == west)
                        result.Add(new Tuple<int, int>(carEast, i));
                }
            }

            var limitCars = 1000000000;

            return (result.Count > limitCars? -1 : result.Count);
        }
    }
}
