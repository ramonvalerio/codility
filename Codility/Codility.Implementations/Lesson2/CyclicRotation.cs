using System.Collections.Generic;

namespace Codility.Implementations.Lesson2
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            var result = new List<int[]>(K);

            for (int x = 0; x < K; x++)
            {
                if (result.Count > 0)
                    result.Add(Rotate(result[x - 1]));
                else
                    result.Add(Rotate(A));
            }

            return result[result.Count - 1];
        }

        public int[] Rotate(int[] A)
        {
            var lastElement = A[A.Length - 1];
            var newArray = new int[A.Length];

            newArray[0] = lastElement;

            for (int y = 0; y < A.Length; y++)
            {
                if (y + 1 == A.Length)
                    break;

                newArray[y + 1] = A[y];
            }

            return newArray;
        }
    }
}