using System.Linq;

namespace Codility.Implementations.Lesson3
{
    public class PermMissingElem
    {
        public int solution(int[] A)
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
