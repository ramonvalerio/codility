using System.Collections.Generic;
using System.Linq;

namespace Codility.Implementations.Lesson2
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            var numerosComPares = new Dictionary<int, bool>(A.Length);

            for (int i = 0; i < A.Length; i++)
            {
                if (numerosComPares.ContainsKey(A[i]))
                    numerosComPares.Remove(A[i]);
                else
                    numerosComPares.Add(A[i], false);
            }

            return numerosComPares.ElementAt(0).Key;
        }
    }
}
