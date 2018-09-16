using System.Linq;

namespace Codility.Implementations.DemoTask
{
    public class DemoTask02
    {
        public int solution(int[] A)
        {
            var total = A.Length;
            var numeros = A.OrderBy(x => x).ToArray();

            int result = 1;

            for (int i = 0; i < total; i++)
            {
                if (numeros[i] == result)
                {
                    result++;
                }
                else if(numeros[i] > result)
                {
                    return result;
                }
            }

            return result;
        }
    }
}
