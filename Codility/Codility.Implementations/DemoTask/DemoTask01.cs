using System.Collections.Generic;
using System.Linq;

namespace Codility.Implementations.DemoTask
{
    public class DemoTask01
    {
        public int solution(int[] A)
        {
            var AOrdenado = A.Where(x => x > 0).OrderBy(x => x).Distinct().ToList();

            if (AOrdenado.Count == 0)
                return 1;

            var numerosSequenciais = Enumerable.Range(1, AOrdenado.Count).ToList();
            var numerosFaltantes = new List<int>(AOrdenado.Count);

            for (int i = 0; i < AOrdenado.Count; i++)
            {
                if (!AOrdenado.Contains(numerosSequenciais[i]))
                    numerosFaltantes.Add(numerosSequenciais[i]);
            }

            return (numerosFaltantes.Count == 0 ? AOrdenado.Max() + 1 : numerosFaltantes.Min());
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
    }
}
