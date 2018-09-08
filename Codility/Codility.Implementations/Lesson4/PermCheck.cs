using System.Collections.Generic;
using System.Linq;

namespace Codility.Implementations.Lesson4
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            var numeros = new Dictionary<int, int>();
            var max = A.Max();

            for (int i = 0; i < A.Length; i++)
            {
                if (!numeros.ContainsKey(A[i]))
                    numeros.Add(A[i], 1);
            }

            if (numeros.Count < A.Length)
                return 0;

            for (int i = 1; i < max; i++)
            {
                if (!numeros.ContainsKey(i))
                    return 0;
            }

            return 1;
        }
    }
}