using System;
using System.Collections.Generic;

namespace Codility.Implementations.Lesson5
{
    public class PassingCars
    {
        public int solution(int[] A)
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

        public int solution2(int[] A)
        {


            return 0;
        }
    }
}
