using System.Collections.Generic;
using System.Linq;

namespace Codility.Implementations.DemoTask
{
    public class DemoTask01
    {
        public int solution(int[] A)
        {
            A = A.OrderBy(x => x).ToArray();

            int result = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == result)
                {
                    result++;
                }
                else if (A[i] > result)
                {
                    return result;
                }
            }

            return result;
        }

        public int solution2(int[] A)
        {
            var AOrdenado = A.Where(x => x > 0).OrderBy(x => x).Distinct().ToList();

            if (AOrdenado.Count == 0)
                return 1;

            var currentLowestTarget = 1;

            foreach (var item in AOrdenado)
            {
                if (item > currentLowestTarget)
                    return currentLowestTarget;

                currentLowestTarget++;
            }

            return AOrdenado[AOrdenado.Count - 1] + 1;
        }

        public int solution3(int[] A)
        {
            var aOrdenado = new SortedList<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && !aOrdenado.ContainsKey(A[i]))
                    aOrdenado.Add(A[i], A[i]);
            }

            if (aOrdenado.Count == 0)
                return 1;

            var total = aOrdenado.Count;
            var numerosSequenciais = new List<int>(total);
            var numerosFaltantes = new List<int>(total);

            for (int i = 1; i < aOrdenado.Count + 1; i++)
                numerosSequenciais.Add(i);

            for (int i = 0; i < total; i++)
            {
                if (!aOrdenado.ContainsKey(numerosSequenciais[i]))
                    numerosFaltantes.Add(numerosSequenciais[i]);
            }

            return numerosFaltantes.Count == 0 ? aOrdenado[total] + 1 : numerosFaltantes.Min();
        }
    }
}
