using System.Linq;

namespace Codility.Implementations.Lesson3
{
    public class PermMissingElem
    {
        public int solution(int[] A)
        {
            var total = A.Length;
            int result = 1;
            A = A.OrderBy(x => x).ToArray();

            for (int i = 0; i < total; i++)
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
            // verificar o caso de 0, 1 ou 2 elementos
            var sortedA = A.OrderBy(x => x).ToArray();

            for (int i = 0; i < sortedA.Count(); i++)
            {
                if ((i + 1) != sortedA[i])
                    return i + 1;
            }

            return sortedA[0];
        }
    }
}