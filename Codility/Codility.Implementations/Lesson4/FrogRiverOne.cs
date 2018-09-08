using System.Collections.Generic;

namespace Codility.Implementations.Lesson4
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            var folhas = new Dictionary<int, bool>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!folhas.ContainsKey(A[i]))
                    folhas.Add(i, false);

                if (folhas.Count == X)
                    return i;
            }

            return -1;
        }
    }
}