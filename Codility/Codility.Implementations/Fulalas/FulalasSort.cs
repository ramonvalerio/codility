using System.Collections.Generic;

namespace Codility.Implementations.Fulalas
{
    public class FulalasSort
    {
        /// <summary>
        /// Determinar se um vetor está ordenado.
        /// Desafio: código enxuto e O(N).
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public bool solution(int[] A)
        {
            int currentValue = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < currentValue)
                    return false;

                currentValue = A[i];
            }

            return true;
        }
    }
}